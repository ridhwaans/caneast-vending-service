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
    public partial class frmOrders : Form
    {
        public const string strMakeOrderMessage = "Make a New Order";
        public const string strEditOrderMessage = "Edit an Order";

        public frmOrders()
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


        private void frmOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Rentals' table. You can move, or remove it, as needed.
            this.rentalsTableAdapter.Fill(this.databaseDataSet.Rentals);
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
            Color c = Color.FromArgb(255, 221, 220, 220);
            this.TransparencyKey = c;
            panel1.BackColor = c;
            this.ShowIcon = false;
            this.Size = new Size(842, 314);

            cboEmployee.Items.Clear();
            using (SqlCommand command = new SqlCommand("SELECT EmployeeID, CONCAT(FirstName,' ',LastName) FROM Employee", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboEmployee.Items.Add(Convert.ToString(reader[0] + " " + Convert.ToString(reader[1])));
                }
            }

            cboProduct.Items.Clear();
            using (SqlCommand command = new SqlCommand("SELECT ProductID, ProductName, Weight, Volume FROM Product", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboProduct.Items.Add(Convert.ToString(reader[0]) + " " + Convert.ToString(reader[1]) + " " + Convert.ToString(reader[2]) + Convert.ToString(reader[3]));
                }
            }

            //cboContractID.Items.Clear();
            //using (SqlCommand command = new SqlCommand("SELECT ContractID FROM Rentals ORDER BY ContractID", Global.con))
            //using (SqlDataReader reader = command.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        cboContractID.Items.Add(Convert.ToString(reader[0]));
            //    }
            //}
        }


        private void chkMakeOrder_CheckedChanged(object sender, EventArgs e)
        {
            chkEditOrder.Checked = false;
            if (chkMakeOrder.Checked == true)
            {
                this.Size = new Size(842, 466);
                chkMakeOrder.BackColor = Color.LightGray;
                lblAddorEdit.Text = strMakeOrderMessage;
                lblAddorEdit.Visible = true;
                txtOrderID.Text = "";
                cboContractID.SelectedIndex = 0;
                nudQuantity.Value = 1;
                cboEmployee.SelectedIndex = 0;
                cboProduct.SelectedIndex = 0;
                dtpOrderDate.Value = DateTime.Today;
                //dtpOrderDate.MinDate = DateTime.Today;
                //dtpShippedDate.MinDate = dtpOrderDate.Value;
                //dtpRequiredDate.MinDate = dtpShippedDate.Value.AddDays(1);
            }
            else if (chkMakeOrder.Checked == false)
            {
                this.Size = new Size(842, 314);
                chkMakeOrder.BackColor = Color.White;
                lblAddorEdit.Visible = false;
            }
        }

        private void chkDeleteOrder_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if ((isOrderUnique().ToString()=="False") & (chkMakeOrder.Checked==true))
            {
                MessageBox.Show("OrderID already exists. Please enter a unique OrderID", "Error");
                return;
            }
            else if (txtOrderID.Text.Trim() == "")
            {
                MessageBox.Show("Invalid OrderID. Please enter a unique OrderID", "Error");
                return;
            }
            else
            {
                int v;
                if (Int32.TryParse(txtOrderID.Text.Trim(), out v))
                {
                    if ((txtOrderID.Text.Length == txtOrderID.MaxLength) & txtOrderID.Text.StartsWith("5"))
                    {
                        if (chkMakeOrder.Checked == true)
                        {
                            DialogResult dialogResult = MessageBox.Show("Make Order \"" + txtOrderID.Text + "\"?", "Make Order", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string[] strEmployee = cboEmployee.SelectedItem.ToString().Split(new char[] { ' ' });
                                string[] strProduct = cboProduct.SelectedItem.ToString().Split(new char[] { ' ' });

                                SqlCommand command = new SqlCommand("INSERT INTO Orders VALUES (" + txtOrderID.Text + ", " + cboContractID.SelectedValue + ", " + strProduct[0] + ", " + nudQuantity.Value + ", '" + dtpOrderDate.Value.ToString("yyyy-MM-dd") + "', '" + dtpRequiredDate.Value.ToString("yyyy-MM-dd") + "', '" + dtpShippedDate.Value.ToString("yyyy-MM-dd") + "', " + strEmployee[0] + ")", Global.con);

                                Console.WriteLine(command.CommandText);
                                command.ExecuteNonQuery();
                                BindingSource bsOrders = new BindingSource();
                                bsOrders.DataSource = Global.GetData("SELECT * FROM Orders");
                                dgvOrders.DataSource = bsOrders;
                                chkMakeOrder.Checked = false;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                        else if (chkEditOrder.Checked == true)
                        {
                            DialogResult dialogResult = MessageBox.Show("Edit Order \"" + txtOrderID.Text + "\"?", "Edit Order", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string[] strEmployee = cboEmployee.SelectedItem.ToString().Split(new char[] { ' ' });
                                string[] strProduct = cboProduct.SelectedItem.ToString().Split(new char[] { ' ' });

                                SqlCommand command = new SqlCommand("UPDATE Orders SET OrderID = " + txtOrderID.Text + ", ContractID = " + cboContractID.SelectedValue + ", ProductID = " + strProduct[0] + ", Quantity = " + nudQuantity.Value + ", OrderDate = '" + dtpOrderDate.Value.ToString("yyyy-MM-dd") + "', RequiredDate = '" + dtpRequiredDate.Value.ToString("yyyy-MM-dd") + "', ShippedDate = '" + dtpShippedDate.Value.ToString("yyyy-MM-dd") + "', EmployeeID = " + strEmployee[0] + " WHERE OrderID = '" + txtOrderID.Text + "'", Global.con);

                                Console.WriteLine(command.CommandText);
                                command.ExecuteNonQuery();
                                BindingSource bsOrders = new BindingSource();
                                bsOrders.DataSource = Global.GetData("SELECT * FROM Orders");
                                dgvOrders.DataSource = bsOrders;
                                chkMakeOrder.Checked = false;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid OrderID. Please enter a 5-digit number that starts with 5", "Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid OrderID. Please enter a 5-digit number that starts with 5", "Error");
                    return;
                }
            }
            
        }

        private bool isOrderUnique()
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if ((!row.IsNewRow))
                {
                    DataGridViewCell cell = row.Cells[0];
                    if (txtOrderID.Text == cell.Value.ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            chkMakeOrder.Checked = false;
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpShippedDate.MinDate = dtpOrderDate.Value;
            //dtpRequiredDate.MinDate = dtpShippedDate.Value.AddDays(1);
        }

        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpRequiredDate.MinDate = dtpShippedDate.Value.AddDays(1);
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {//Cancel order edit if order isnt selected
            chkEditOrder.Checked = false;
        }

        private void chkEditOrder_CheckedChanged(object sender, EventArgs e)
        {
            chkMakeOrder.Checked = false;
            if (chkEditOrder.Checked == true)
            {
                if (dgvOrders.SelectedRows.Count == 1)
                {
                    this.Size = new Size(842, 466);
                    chkEditOrder.BackColor = Color.LightGray;
                    lblAddorEdit.Text = strEditOrderMessage;
                    lblAddorEdit.Visible = true;
                    txtOrderID.Text = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
                    cboContractID.SelectedValue = dgvOrders.SelectedRows[0].Cells[1].Value;
                    nudQuantity.Value = Convert.ToDecimal(dgvOrders.SelectedRows[0].Cells[3].Value);
                    cboProduct.SelectedIndex = cboProduct.FindString(dgvOrders.SelectedRows[0].Cells[2].Value.ToString());
                    cboEmployee.SelectedIndex = cboEmployee.FindString(dgvOrders.SelectedRows[0].Cells[7].Value.ToString());
                    dtpOrderDate.Value = Convert.ToDateTime(dgvOrders.SelectedRows[0].Cells[4].Value.ToString());
                    dtpRequiredDate.Value = Convert.ToDateTime(dgvOrders.SelectedRows[0].Cells[5].Value.ToString());
                    dtpShippedDate.Value = Convert.ToDateTime(dgvOrders.SelectedRows[0].Cells[6].Value.ToString());
                }
                else
                {
                    MessageBox.Show("No Order selected", "Error");
                }
            }
            else if (chkEditOrder.Checked == false)
                {
                    this.Size = new Size(842, 314);
                    chkEditOrder.BackColor = Color.White;
                    lblAddorEdit.Visible = false;
                }
            }
        

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            chkMakeOrder.Checked = false;
            chkEditOrder.Checked = false;
            if (dgvOrders.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Delete Order \"" + dgvOrders.SelectedRows[0].Cells[0].Value + "\"?", "Delete Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE OrderID = '" + dgvOrders.SelectedRows[0].Cells[0].Value + "'", Global.con);

                    Console.WriteLine(command.CommandText);
                    command.ExecuteNonQuery();

                    dgvOrders.DataSource = null;
                    this.ordersTableAdapter.Update(this.databaseDataSet.Orders);
                    dgvOrders.DataSource = ordersBindingSource;


                    BindingSource bsOrders = new BindingSource();
                    bsOrders.DataSource = Global.GetData("SELECT * FROM Orders");
                    dgvOrders.DataSource = bsOrders;
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No Order selected", "Error");
            }
        }

        //private static DataTable GetData(string sqlCommand)
        //{
        //    SqlCommand command = new SqlCommand(sqlCommand, Global.con);
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.SelectCommand = command;

        //    DataTable table = new DataTable();
        //    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //    adapter.Fill(table);

        //    return table;
        //}


        }

    }
