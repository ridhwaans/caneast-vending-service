using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanEastVending
{
    public partial class frmEmployees : Form
    {
        public const string strAddEmployeeMessage = "Add a New Employee";
        public const string strEditEmployeeMessage = "Edit an Employee";

        public frmEmployees()
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

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(255, 221, 220, 220);
            this.TransparencyKey = c;
            panel1.BackColor = c;
            pnlCustomerInfo.BackColor = Color.White;
            this.ShowIcon = false;
            lblAddorEdit.Visible = false;
            btnEdit.Visible = false;
            pnlNewRemove.Location = new Point(12, 323);
            pnlNewRemove.Visible = true;            
            pnlOkCancel.Visible = false;
            txtBirthDate.Visible = true;
            txtHireDate.Visible = true;
            dtpBirthDate_Add.MaxDate = DateTime.Now.AddDays(-1);
            dtpHireDate_Add.MaxDate = DateTime.Now;
            dtpBirthDate_Add.Visible = false;
            dtpHireDate_Add.Visible = false;
            txtEmployeeID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtPosition.ReadOnly = false;
            txtHireDate.ReadOnly = false;
            txtBirthDate.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtPostalCode.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            loadEmployeeList();
            
        }

        private void loadEmployeeList()
        {
            lvEmployees.Items.Clear();
            using (SqlCommand command = new SqlCommand("SELECT EmployeeID, CONCAT(FirstName,' ',LastName) FROM Employee", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));
                    ListViewItem item = new ListViewItem(Convert.ToString(reader[0]));
                    item.SubItems.Add(reader.GetString(1));
                    lvEmployees.Items.Add(item);
                }
            }
        }

        private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            CancelAddorEdit();
            ListView.SelectedListViewItemCollection selectedItem = this.lvEmployees.SelectedItems;

            foreach (ListViewItem item in selectedItem)   
            {
                using (SqlCommand command = new SqlCommand("SELECT EmployeeID, Firstname, LastName, Position, CONVERT(CHAR(10),BirthDate,103) AS BirthDate, CONVERT(CHAR(10), HireDate,103) AS HireDate, Address, City, Province, PostalCode, PhoneNumber FROM Employee WHERE EmployeeID='" + item.Text + "'", Global.con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        btnEdit.Visible = true;
                        txtEmployeeID.Text = Convert.ToString(reader["EmployeeID"]);
                        txtPosition.Text = Convert.ToString(reader["Position"]);
                        txtFirstName.Text = Convert.ToString(reader["FirstName"]);
                        txtLastName.Text = Convert.ToString(reader["LastName"]);
                        txtHireDate.Text = Convert.ToString(reader["HireDate"]);
                        txtBirthDate.Text = Convert.ToString(reader["BirthDate"]);
                        txtAddress.Text = Convert.ToString(reader["Address"]);
                        txtCity.Text = Convert.ToString(reader["City"]);
                        txtProvince.Text = Convert.ToString(reader["Province"]);
                        txtPostalCode.Text = Convert.ToString(reader["PostalCode"]);
                        txtPhoneNumber.Text = Convert.ToString(reader["PhoneNumber"]);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblAddorEdit.Text = strAddEmployeeMessage;
            btnEdit.Visible = false;
            lblAddorEdit.Visible = true;
            txtEmployeeID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPosition.Text = "";
            txtHireDate.Text = "";
            txtBirthDate.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostalCode.Text = "";
            txtPhoneNumber.Text = "";

            pnlOkCancel.Location = new Point(12, 323);
            pnlNewRemove.Visible = false;
            pnlOkCancel.Visible = true;
            txtBirthDate.Visible = false;
            txtHireDate.Visible = false;
            dtpBirthDate_Add.Visible = true;
            dtpHireDate_Add.Visible = true;

            txtEmployeeID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtPosition.ReadOnly = false;
            txtHireDate.ReadOnly = false;
            txtBirthDate.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtPostalCode.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelAddorEdit();
        }

        private void CancelAddorEdit()
        {
            lblAddorEdit.Visible = false;
            txtEmployeeID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPosition.Text = "";
            txtHireDate.Text = "";
            txtBirthDate.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostalCode.Text = "";
            txtPhoneNumber.Text = "";

            btnEdit.Visible = false;
            pnlNewRemove.Location = new Point(12, 323);
            pnlNewRemove.Visible = true;
            pnlOkCancel.Visible = false;
            txtBirthDate.Visible = true;
            txtHireDate.Visible = true;
            txtBirthDate.Visible = true;
            dtpBirthDate_Add.Visible = false;
            dtpHireDate_Add.Visible = false;

            txtEmployeeID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtPosition.ReadOnly = true;
            txtHireDate.ReadOnly = true;
            txtBirthDate.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProvince.ReadOnly = true;
            txtPostalCode.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
        }
        

        private void btnRemove_Click(object sender, EventArgs e)
        {
                foreach (ListViewItem item in lvEmployees.Items)
                {
                    if (item.Selected)
                    {
                        DialogResult dialogResult = MessageBox.Show("Remove \"" + item.SubItems[1].Text + "\" (ID: " + item.Text + ")?", "Remove Employee", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = '" + item.SubItems[0].Text + "'", Global.con);

                            Console.WriteLine(command.CommandText);
                            command.ExecuteNonQuery();

                            MessageBox.Show("You fired " + item.SubItems[1].Text);
                            loadEmployeeList();
                            CancelAddorEdit();
                            return;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            MessageBox.Show("Employee not selected", "Error");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                ListViewItem lviEmployeeID = lvEmployees.FindItemWithText(txtEmployeeID.Text, false, 0, false); //search first column of listview items if employeeID exists
                Regex rgxPhoneNumber = new Regex(@"^((\d{3}-))?\d{3}-\d{4}$");  //check if phone number is ___-___-____ format @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$"

                if ((lviEmployeeID != null) & (lblAddorEdit.Visible = true) & (lblAddorEdit.Text == strAddEmployeeMessage)) 
                {
                    MessageBox.Show("EmployeeID already exists. Please enter a new EmployeeID", "Error");
                    return;
                }
                else if (dtpBirthDate_Add.Value > DateTime.Now)
                {
                    MessageBox.Show("Invalid BirthDate", "Error");
                    return;
                }
                else if (dtpHireDate_Add.Value > DateTime.Now)
                {
                    MessageBox.Show("Invalid HireDate", "Error");
                    return;
                }
                else if (dtpHireDate_Add.Value < dtpBirthDate_Add.Value)
                {
                    MessageBox.Show("BirthDate cannot be after HireDate", "Error");
                    return;
                }
                else if ((txtPhoneNumber.Text != "") & (!rgxPhoneNumber.IsMatch(txtPhoneNumber.Text)))
                {
                    MessageBox.Show("Invalid PhoneNumber (phone format: ###-###-####)", "Error");
                    return;
                }
                else
                {
                    int v;
                    if (Int32.TryParse(txtEmployeeID.Text.Trim(), out v))
                    {
                        if ((txtEmployeeID.Text.Length == txtEmployeeID.MaxLength) & txtEmployeeID.Text.StartsWith("2"))
                        {//All parameters and arguments are valid at this point
                            if (lblAddorEdit.Text == strAddEmployeeMessage)
                            {
                                DialogResult dialogResult = MessageBox.Show("Add '" + txtFirstName.Text + " " + txtLastName.Text + "' (OrderID: " + txtEmployeeID.Text + ")?", "Add Employee", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    SqlCommand command = new SqlCommand("INSERT INTO Employee VALUES (" + txtEmployeeID.Text + ", '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtPosition.Text + "', '" + dtpBirthDate_Add.Value.ToString("yyyy-MM-dd") + "', '" + dtpHireDate_Add.Value.ToString("yyyy-MM-dd") + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtPostalCode.Text + "', '" + txtPhoneNumber.Text + "')", Global.con);
                                    Console.WriteLine(command.CommandText);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Added '" + txtFirstName.Text + " " + txtLastName.Text + "' successfully", "Success");
                                    loadEmployeeList();
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    return;
                                }
                                
                            }
                            else if (lblAddorEdit.Text == strEditEmployeeMessage)
                            {
                                DialogResult dialogResult = MessageBox.Show("Update '" + txtFirstName.Text + " " + txtLastName.Text + "' (OrderID: " + txtEmployeeID.Text + ") employee information?", "Update", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    SqlCommand command = new SqlCommand("UPDATE Employee SET EmployeeID = " + txtEmployeeID.Text + ", FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', Position = '" + txtPosition.Text + "', BirthDate = '" + dtpBirthDate_Add.Value.ToString("yyyy-MM-dd") + "', HireDate = '" + dtpHireDate_Add.Value.ToString("yyyy-MM-dd") + "', Address = '" + txtAddress.Text + "', City = '" + txtCity.Text + "', Province = '" + txtProvince.Text + "', PostalCode = '" + txtPostalCode.Text + "', PhoneNumber = '" + txtPhoneNumber.Text + "' WHERE EmployeeID = '" + txtEmployeeID.Text + "'", Global.con);
                                    Console.WriteLine(command.CommandText);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Updated '" + txtFirstName.Text + " " + txtLastName.Text + "' (OrderID: " + txtEmployeeID.Text + ") employee information successfully", "Success");
                                    loadEmployeeList();
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid EmployeeID. Please enter a 5-digit number that starts with 2", "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid EmployeeID. Please enter a 5-digit number that starts with 2", "Error");
                        return;
                    }
                }
            }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblAddorEdit.Text = strEditEmployeeMessage;
            btnEdit.Visible = false;
            lblAddorEdit.Visible = true;

            pnlOkCancel.Location = new Point(12, 323);
            pnlNewRemove.Visible = false;
            pnlOkCancel.Visible = true;
            txtBirthDate.Visible = false;
            txtHireDate.Visible = false;
            dtpBirthDate_Add.Visible = true;
            dtpHireDate_Add.Visible = true;
            dtpBirthDate_Add.Value = Convert.ToDateTime(txtBirthDate.Text);
            dtpHireDate_Add.Value = Convert.ToDateTime(txtHireDate.Text);

            txtEmployeeID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtPosition.ReadOnly = false;
            txtHireDate.ReadOnly = false;
            txtBirthDate.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtPostalCode.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
        }

        private void dtpHireDate_Add_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpBirthDate_Add_ValueChanged(object sender, EventArgs e)
        {
            dtpHireDate_Add.MinDate = dtpBirthDate_Add.Value;
        }
    }
}
