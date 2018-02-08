using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanEastVending
{
    public partial class frmMachines : Form
    {
        public frmMachines()
        {
            InitializeComponent();

            if (!this.IsGlassEnabled())
            {
                return;
            }

            VistaApi.Margins marg;
            marg.Top = panel1.Height;
            marg.Left = 0;
            marg.Right = 0;
            marg.Bottom = 0;

            VistaApi.DwmExtendFrameIntoClientArea(this.Handle, ref marg); 
        }

        private bool IsGlassEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6)
            {
                return false;
            }

            bool isGlassSupported = false;
            VistaApi.DwmIsCompositionEnabled(ref isGlassSupported);
            return isGlassSupported;
        }

        private void frmMachines_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(255, 221, 220, 220);
            this.TransparencyKey = c;
            panel1.BackColor = c;
            this.ShowIcon = false;
            //this.Size = new Size(842, 314);
            setupMachinesListView();
            clearSelection();

            cboCustomer.Items.Clear();
            using (SqlCommand command = new SqlCommand("SELECT CustomerID, CONCAT(FirstName,' ',LastName) FROM Customer", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboCustomer.Items.Add(Convert.ToString(reader[0] + " " + Convert.ToString(reader[1])));
                }
            }
        }

        private void setupMachinesListView()
        {
            lvMachines.View = View.Tile;
            lvMachines.TileSize = new Size(400, 64);
            imgMachinePictures.ImageSize = new Size(64, 64);
            lvMachines.Columns.Add("MachineID", -2, HorizontalAlignment.Left);
            lvMachines.Columns.Add("Status", -2, HorizontalAlignment.Left);
            lvMachines.Columns.Add("ModelName", -2, HorizontalAlignment.Left);
            lvMachines.Columns.Add("ModelNumber", -2, HorizontalAlignment.Left);

            using (SqlCommand command = new SqlCommand("SELECT * FROM Machine", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem("MachineID: " + Convert.ToString(reader[0]));
                    item.SubItems.Add("Status: " + Convert.ToString(reader[1]));
                    item.SubItems.Add("ModelName: " + Convert.ToString(reader[2]));
                    item.SubItems.Add("ModelNumber: " + Convert.ToString(reader[3]));

                    switch (Convert.ToString(reader[2]))
                    {
                        case "Vendmaster 2000":
                            item.ImageKey = "Vendmaster 2000.jpg";
                            break;
                        case "Vendmaster 3000":
                            item.ImageKey = "Vendmaster 3000.jpg";
                            break;
                        case "Vendmaster 4000":
                            item.ImageKey = "Vendmaster 4000.jpg";
                            break;
                        case "ProVendor":
                            item.ImageKey = "ProVendor.jpg";
                            break;
                        case "UltraVendmaster":
                            item.ImageKey = "UltraVendmaster.jpg";
                            break;
                        case "iVend":
                            item.ImageKey = "iVend.jpg";
                            break;
                        case "iVend 2.0":
                            item.ImageKey = "iVend 2.0.jpg";
                            break;
                    }
                    lvMachines.Items.Add(item);
                }
            }
        }


        private void lvMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMachines.SelectedItems.Count == 1)
            {
                cboCustomer.SelectedIndex = -1;
                string strMachineID = lvMachines.SelectedItems[0].Text;
                strMachineID = strMachineID.Replace("MachineID: ", "");
                lblMachineID.Text = strMachineID;

                using (SqlCommand command = new SqlCommand("SELECT Status, ModelName, ModelNumber, CONVERT(CHAR(10),ManufactureDate,103) AS ManufactureDate, CONVERT(CHAR(10),DateLastRestocked,103) AS DateLastRestocked, CONVERT(CHAR(10),NextRestock,103) AS NextRestock, Capacity FROM Machine WHERE MachineID = " + strMachineID, Global.con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(command.CommandText);
                    while (reader.Read())
                    {
                        lblStatus.Text = Convert.ToString(reader[0]);
                        lblModelName.Text = Convert.ToString(reader[1]);
                        lblModelNumber.Text = Convert.ToString(reader[2]);
                        lblManufactureDate.Text = Convert.ToString(reader[3]);
                        lblDateLastRestocked.Text = Convert.ToString(reader[4]);
                        lblNextRestockDate.Text = Convert.ToString(reader[5]);
                        lblCapacity.Text = Convert.ToString(reader[6]);
                    }
                }
                BindingSource bsInventory = new BindingSource();
                bsInventory.DataSource = Global.GetData("SELECT M.ProductID, P.ProductName,P.UnitPrice, M.Quantity FROM MachineInventory AS M, Product AS P WHERE M.ProductID = P.ProductID AND M.MachineID = " + lblMachineID.Text);
                dgvInventory.DataSource = bsInventory;

                if (lvMachines.SelectedItems[0].SubItems[1].Text.Contains("In Storage") == true)
                {
                    btnEndRental.Visible = false;
                    btnMakeRental.Visible = true;
                    btnEndRental1.Visible = false;
                    btnMakeRental1.Visible = true;
                }
                else if (lvMachines.SelectedItems[0].SubItems[1].Text.Contains("On Location") == true)
                {
                    btnEndRental.Visible = true;
                    btnMakeRental.Visible = false;
                    btnEndRental1.Visible = true;
                    btnMakeRental1.Visible = false;
                }

                using (SqlCommand command = new SqlCommand("SELECT R.ContractID,CONVERT(CHAR(10),R.ContractStartDate,103) AS ContractStartDate,R.LocationID,L.Address, L.City, L.Province, L.PostalCode, L.PhysicalPlacement, R.CustomerID FROM Rentals AS R, Location AS L WHERE R.LocationID = L.LocationID AND R.MachineID = " + strMachineID, Global.con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(command.CommandText);
                    while (reader.Read())
                    {
                        msktxtContractID.Text = Convert.ToString(reader[0]);
                        txtContractStartDate.Text = Convert.ToString(reader[1]);
                        msktxtLocationID.Text = Convert.ToString(reader[2]);
                        txtAddress.Text = Convert.ToString(reader[3]);
                        txtCity.Text = Convert.ToString(reader[4]);
                        txtProvince.Text = Convert.ToString(reader[5]);
                        txtPostalCode.Text = Convert.ToString(reader[6]);
                        txtPhysicalPlacement.Text = Convert.ToString(reader[7]);

                        if (String.IsNullOrEmpty(Convert.ToString(reader[8]).Trim()))
                        {
                            cboCustomer.SelectedIndex = -1;
                        }
                        else
                        {
                            cboCustomer.SelectedIndex = cboCustomer.FindString(Convert.ToString(reader[8]));
                        }
                    }
                }
            }
            else
            {
                clearSelection();
            }
        }

        private void clearSelection()
        {
            lblAction.Text = "";
            lblMachineID.Text = "";
            lblStatus.Text = "";
            lblModelName.Text = "";
            lblModelNumber.Text = "";
            lblManufactureDate.Text = "";
            lblDateLastRestocked.Text = "";
            lblNextRestockDate.Text = "";
            lblCapacity.Text = "";
            btnMakeRental.Visible = false;
            btnEndRental.Visible = false;
            dgvInventory.DataSource = null;
            msktxtContractID.Clear();
            msktxtLocationID.Clear();
            txtContractStartDate.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();
            txtPhysicalPlacement.Clear();

            dtpContractStartDate.Visible = false;
            txtContractStartDate.Visible = true;

            btnCancel.Visible = false;
            btnMakeRental1.Visible = false;
            btnEndRental1.Visible = false;

            msktxtContractID.ReadOnly = true;
            msktxtLocationID.ReadOnly = true;
            txtContractStartDate.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProvince.ReadOnly = true;
            txtPostalCode.ReadOnly = true;
            txtPhysicalPlacement.ReadOnly = true;
            cboCustomer.Enabled = false;
            cboCustomer.SelectedIndex = -1;
        }

        private void btnSeeInventory_Click(object sender, EventArgs e)
        {
            

        }

        private void msktxtContractID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnMakeRental_Click(object sender, EventArgs e)
        {
            tcMachineDetail.SelectedTab = tbpRentalInfo;
            btnMakeRental1.PerformClick();
        }

        private void btnMakeRental1_Click(object sender, EventArgs e)
        {
            if (lblAction.Text != "Make Machine Rental")
            {
                lblAction.Text = "Make Machine Rental";

                dtpContractStartDate.Visible = true;
                txtContractStartDate.Visible = false;

                btnCancel.Visible = true;
                btnMakeRental1.Visible = true;
                btnEndRental1.Visible = false;

                msktxtContractID.ReadOnly = false;
                msktxtLocationID.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtCity.ReadOnly = false;
                txtProvince.ReadOnly = false;
                txtPostalCode.ReadOnly = false;
                txtPhysicalPlacement.ReadOnly = false;
                cboCustomer.Enabled = true;
                cboCustomer.SelectedIndex = -1;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Rent '" + lblMachineID.Text + " " + lblModelName.Text + " (" + lblModelNumber.Text + ")' to customer '" + cboCustomer.SelectedItem.ToString() + "'?", "Make Rental", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //SqlCommand command = new SqlCommand("INSERT INTO Employee VALUES (" + txtEmployeeID.Text + ", '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtPosition.Text + "', '" + dtpBirthDate_Add.Value.ToString("yyyy-MM-dd") + "', '" + dtpHireDate_Add.Value.ToString("yyyy-MM-dd") + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtPostalCode.Text + "', '" + txtPhoneNumber.Text + "')", Global.con);
                    //Console.WriteLine(command.CommandText);
                    //command.ExecuteNonQuery();
                    MessageBox.Show("Customer contract created and machine successfully rented on location", "Success");

                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            msktxtContractID.Clear();
            msktxtLocationID.Clear();
            txtContractStartDate.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();
            txtPhysicalPlacement.Clear();

            lblAction.Text = "";
            dtpContractStartDate.Visible = false;
            txtContractStartDate.Visible = true;

            btnCancel.Visible = false;
            btnMakeRental1.Visible = true;
            btnEndRental1.Visible = false;

            msktxtContractID.ReadOnly = true;
            msktxtLocationID.ReadOnly = true;
            txtContractStartDate.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProvince.ReadOnly = true;
            txtPostalCode.ReadOnly = true;
            txtPhysicalPlacement.ReadOnly = true;
            cboCustomer.Enabled = false;
            cboCustomer.SelectedIndex = -1;
        }

        private void btnEndRental1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("End machine rental of '" + lblMachineID.Text + " " + lblModelName.Text + " (" + lblModelNumber.Text + ")' to customer '" + cboCustomer.SelectedItem.ToString() + "'?", "End Rental", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //SqlCommand command = new SqlCommand("INSERT INTO Employee VALUES (" + txtEmployeeID.Text + ", '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtPosition.Text + "', '" + dtpBirthDate_Add.Value.ToString("yyyy-MM-dd") + "', '" + dtpHireDate_Add.Value.ToString("yyyy-MM-dd") + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtPostalCode.Text + "', '" + txtPhoneNumber.Text + "')", Global.con);
                //Console.WriteLine(command.CommandText);
                //command.ExecuteNonQuery();
                MessageBox.Show("Customer rental contract terminated and machine returned to storage", "Message");

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnEndRental_Click(object sender, EventArgs e)
        {
            tcMachineDetail.SelectedTab = tbpRentalInfo;
            btnEndRental1.PerformClick();
        }
    }
}
