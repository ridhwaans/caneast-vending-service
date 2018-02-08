using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanEastVending
{
    public partial class frmCustomers : Form
    {
        public const string strAddCustomerMessage = "Add a New Customer";
        public const string strEditCustomerMessage = "Edit a Customer";

        public frmCustomers()
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

        private void frmCustomers_Load(object sender, EventArgs e)
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
            txtCustomerID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtCompanyName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtPostalCode.ReadOnly = false;
            txtFaxNumber.ReadOnly = false;
            loadCustomerList();


            lvCustomers.Items.Clear();
            using (SqlCommand command = new SqlCommand("SELECT CustomerID, CONCAT(FirstName,' ',LastName) FROM Customer", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1}",reader.GetInt32(0), reader.GetString(1));
                    ListViewItem item = new ListViewItem(Convert.ToString(reader[0]));
                    item.SubItems.Add(reader.GetString(1));
                    lvCustomers.Items.Add(item);
                }
            }
        }

        private void loadCustomerList()
        {
            lvCustomers.Items.Clear();
            using (SqlCommand command = new SqlCommand("SELECT CustomerID, CONCAT(FirstName,' ',LastName) FROM Customer", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));
                    ListViewItem item = new ListViewItem(Convert.ToString(reader[0]));
                    item.SubItems.Add(reader.GetString(1));
                    lvCustomers.Items.Add(item);
                }
            }
        }


        private void lvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CancelAddorEdit();
            ListView.SelectedListViewItemCollection selectedItem = this.lvCustomers.SelectedItems;

            foreach (ListViewItem item in selectedItem)
            {
                using (SqlCommand command = new SqlCommand("SELECT CustomerID, CompanyName, Firstname, LastName, Email, Address, City, Province, PostalCode, PhoneNumber, FaxNumber FROM Customer WHERE CustomerID='" + item.Text + "'", Global.con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        btnEdit.Visible = true;
                        txtCustomerID.Text = Convert.ToString(reader["CustomerID"]);
                        txtCompanyName.Text = Convert.ToString(reader["CompanyName"]);
                        txtFirstName.Text = Convert.ToString(reader["FirstName"]);
                        txtLastName.Text = Convert.ToString(reader["LastName"]);
                        txtEmail.Text = Convert.ToString(reader["Email"]);
                        txtAddress.Text = Convert.ToString(reader["Address"]);
                        txtCity.Text = Convert.ToString(reader["City"]);
                        txtProvince.Text = Convert.ToString(reader["Province"]);
                        txtPostalCode.Text = Convert.ToString(reader["PostalCode"]);
                        txtPhoneNumber.Text = Convert.ToString(reader["PhoneNumber"]);
                        txtFaxNumber.Text = Convert.ToString(reader["FaxNumber"]);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblAddorEdit.Text = strAddCustomerMessage;
            btnEdit.Visible = false;
            lblAddorEdit.Visible = true;
            txtCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCompanyName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostalCode.Text = "";
            txtFaxNumber.Text = "";

            pnlOkCancel.Location = new Point(12, 323);
            pnlNewRemove.Visible = false;
            pnlOkCancel.Visible = true;

            txtCustomerID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtCompanyName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtPostalCode.ReadOnly = false;
            txtFaxNumber.ReadOnly = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelAddorEdit();
        }

        private void CancelAddorEdit()
        {
            lblAddorEdit.Visible = false;
            txtCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCompanyName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostalCode.Text = "";
            txtFaxNumber.Text = "";

            btnEdit.Visible = false;
            pnlNewRemove.Location = new Point(12, 323);
            pnlNewRemove.Visible = true;
            pnlOkCancel.Visible = false;

            txtCustomerID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtCompanyName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProvince.ReadOnly = true;
            txtPostalCode.ReadOnly = true;
            txtFaxNumber.ReadOnly = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCustomers.Items)
            {
                if (item.Selected)
                {
                    DialogResult dialogResult = MessageBox.Show("Remove \"" + item.SubItems[1].Text + "\" (ID: " + item.Text + ")?", "Remove Customer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = '" + item.SubItems[0].Text + "'", Global.con);

                        Console.WriteLine(command.CommandText);
                        command.ExecuteNonQuery();

                        MessageBox.Show("You removed " + item.SubItems[1].Text);
                        loadCustomerList();
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
            ListViewItem lviCustomerID = lvCustomers.FindItemWithText(txtCustomerID.Text, false, 0, false); //search first column of listview items if employeeID exists
            Regex rgxPhoneNumber = new Regex(@"^((\d{3}-))?\d{3}-\d{4}$");  //check if phone number is ___-___-____ format @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$"

            if ((lviCustomerID != null) & (lblAddorEdit.Visible = true) & (lblAddorEdit.Text == strAddCustomerMessage))
            {
                MessageBox.Show("CustomerID already exists. Please enter a new CustomerID", "Error");
                return;
            }
            else if ((txtPhoneNumber.Text.Trim() != "") & (!rgxPhoneNumber.IsMatch(txtPhoneNumber.Text)))
            {
                MessageBox.Show("Invalid PhoneNumber (phone format: ###-###-####)", "Error");
                return;
            }
            else if ((txtFaxNumber.Text.Trim() != "") & (!rgxPhoneNumber.IsMatch(txtFaxNumber.Text)))
            {
                MessageBox.Show("Invalid FaxNumber (fax format: ###-###-####)", "Error");
                return;
            }
            else
            {
                int v;
                if (Int32.TryParse(txtCustomerID.Text.Trim(), out v))
                {
                    Console.WriteLine("first");
                    if ((txtCustomerID.Text.Length == txtCustomerID.MaxLength) & txtCustomerID.Text.StartsWith("1"))
                    {//All parameters and arguments are valid at this point
                        Console.WriteLine("second");
                        if (lblAddorEdit.Text == strAddCustomerMessage)
                        {
                            DialogResult dialogResult = MessageBox.Show("Add '" + txtFirstName.Text + " " + txtLastName.Text + "' (OrderID: " + txtCustomerID.Text + ")?", "Add Customer", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO Customer VALUES (" + txtCustomerID.Text + ", '" + txtCompanyName.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtPostalCode.Text + "', '" + txtPhoneNumber + "', '" + txtFaxNumber.Text + "')", Global.con);
                                Console.WriteLine(command.CommandText);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Added '" + txtFirstName.Text + " " + txtLastName.Text + "' successfully", "Success");
                                loadCustomerList();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }

                        }
                        else if (lblAddorEdit.Text == strEditCustomerMessage)
                        {
                            DialogResult dialogResult = MessageBox.Show("Update '" + txtFirstName.Text + " " + txtLastName.Text + "' (OrderID: " + txtCustomerID.Text + ") employee information?", "Update", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SqlCommand command = new SqlCommand("UPDATE Customer SET CustomerID = " + txtCustomerID.Text + ", FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', CompanyName = '" + txtCompanyName.Text + "', Email = '" + txtEmail.Text + "', Address = '" + txtAddress.Text + "', City = '" + txtCity.Text + "', Province = '" + txtProvince.Text + "', PostalCode = '" + txtPostalCode.Text + "', PhoneNumber = '" + txtPhoneNumber.Text + "', FaxNumber = '" + txtFaxNumber.Text + "' WHERE CustomerID = '" + txtCustomerID.Text + "'", Global.con);
                                Console.WriteLine(command.CommandText);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Updated '" + txtFirstName.Text + " " + txtLastName.Text + "' (OrderID: " + txtCustomerID.Text + ") customer information successfully", "Success");
                                loadCustomerList();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid CustomerID. Please enter a 5-digit number that starts with 1", "Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid CustomerID. Please enter a 5-digit number that starts with 1", "Error");
                    return;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblAddorEdit.Text = strEditCustomerMessage;
            btnEdit.Visible = false;
            lblAddorEdit.Visible = true;

            pnlOkCancel.Location = new Point(12, 323);
            pnlNewRemove.Visible = false;
            pnlOkCancel.Visible = true;

            txtCustomerID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtCompanyName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtPostalCode.ReadOnly = false;
            txtFaxNumber.ReadOnly = false;
        }

    }

    }
