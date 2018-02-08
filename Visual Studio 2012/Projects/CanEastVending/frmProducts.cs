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
    public partial class frmProducts : Form
    {
        public frmProducts()
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


        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.databaseDataSet.Product);
            Color c = Color.FromArgb(255, 221, 220, 220);
            this.TransparencyKey = c;
            panel1.BackColor = c;
            this.ShowIcon = false;
            this.Size = new Size(652, 452);
            lblFilter.Visible = false;
            setupCheckLists("ProductType", "Product", chklstProductType);
            setupCheckLists("UnitPrice", "Product", chklstUnitPrice);
            setupCheckLists("ManufacturerName", "Product", chklstManufacturerName);
            chklstProductType.SetItemChecked(0, true);
            chklstUnitPrice.SetItemChecked(0, true);
            chklstManufacturerName.SetItemChecked(0, true);
            lblResults.Text = drProducts.ItemCount.ToString() + " result(s) found";
        }

        private void setupCheckLists(string columnName, string tableName, CheckedListBox chklstControl)
        {
            chklstControl.Items.Add("<all>");
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT " + columnName + " FROM " + tableName + " ORDER BY " + columnName + " ASC", Global.con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string item = Convert.ToString(reader[0]);
                    if (item.Equals("	Dr Pepper Snapple Group")==false)
                    {
                        chklstControl.Items.Add(item);
                    }
                }
            }
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilter.Checked == true)
            {
                this.Size = new Size(831, 452); 
                chkFilter.Visible = false;
                lblFilter.Visible = true;
            }
            else if (chkFilter.Checked == false)
            {
                this.Size = new Size(652, 452); 
                chkFilter.Visible = true;
                lblFilter.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (chkFilter.Checked == true)
            {
                chkFilter.Checked = false;
            }
            else if (chkFilter.Checked == false)
            {
                chkFilter.Checked = true;
            }
        }

        private void chklstManufacturerName_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void chklstManufacturerName_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index.Equals(0))
            {
                if (e.NewValue.ToString() == "Unchecked")
                {
                    for (int i = 1; i < chklstManufacturerName.Items.Count; i++)
                    {
                        chklstManufacturerName.SetItemChecked(i, false);
                    }
                }
                else if (e.NewValue.ToString() == "Checked")
                {

                    for (int i = 1; i < chklstManufacturerName.Items.Count; i++)
                    {
                        chklstManufacturerName.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void chklstUnitPrice_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index.Equals(0))
            {
                if (e.NewValue.ToString() == "Unchecked")
                {
                    for (int i = 1; i < chklstUnitPrice.Items.Count ; i++)
                    {
                        chklstUnitPrice.SetItemChecked(i, false);
                    }
                }
                else if (e.NewValue.ToString() == "Checked")
                {

                    for (int i = 1; i < chklstUnitPrice.Items.Count ; i++)
                    {
                        chklstUnitPrice.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void chklstProductType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index.Equals(0))
            {
                if (e.NewValue.ToString() == "Unchecked")
                {
                    for (int i = 1; i < chklstProductType.Items.Count ; i++)
                    {
                        chklstProductType.SetItemChecked(i, false);
                    }
                }
                else if (e.NewValue.ToString() == "Checked")
                {

                    for (int i = 1; i < chklstProductType.Items.Count ; i++)
                    {
                        chklstProductType.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void manufacturerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chklstProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindingSource bsFilterQueryData = new BindingSource();
            string strFilterQuery = buildFilterQueryString();
            bsFilterQueryData.DataSource = Global.GetData(strFilterQuery);
            drProducts.DataSource = bsFilterQueryData;
            lblResults.Text = drProducts.ItemCount.ToString() + " result(s) found";

            if (drProducts.ItemCount.Equals(0))
            {
                lblNoResults.Visible = true;
                lblNoResults.BringToFront();
            }
            else
            {
                lblNoResults.Visible = false;
                lblNoResults.SendToBack();
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

        private string buildFilterQueryString()
        {
            string strFilterQuery = "SELECT * FROM Product ";
            string productTypePortion = "", unitPricePortion = "", manufacturerNamePortion = "";

            if (chklstProductType.CheckedItems.Count > 0)
            {
                if (chklstProductType.GetItemChecked(0) == false)
                {
                    productTypePortion = " ProductType IN (";
                    foreach (object i in chklstProductType.CheckedItems)
                    {
                        productTypePortion = productTypePortion + " '" + i.ToString() + "',";
                    }
                    productTypePortion = productTypePortion.Remove(productTypePortion.Length - 1);
                    productTypePortion = productTypePortion + ")";
                }
            }

            if (chklstManufacturerName.CheckedItems.Count > 0)
            {
                if (chklstManufacturerName.GetItemChecked(0) == false)
                {
                    manufacturerNamePortion = " ManufacturerName IN (";
                    foreach (object i in chklstManufacturerName.CheckedItems)
                    {
                        manufacturerNamePortion = manufacturerNamePortion + " '" + i.ToString() + "',";
                    }
                    manufacturerNamePortion = manufacturerNamePortion.Remove(manufacturerNamePortion.Length - 1);
                    manufacturerNamePortion = manufacturerNamePortion + ")";
                }
            }

            if (chklstUnitPrice.CheckedItems.Count > 0)
            {
                if (chklstUnitPrice.GetItemChecked(0) == false)
                {
                    unitPricePortion = " UnitPrice IN (";
                    foreach (object i in chklstUnitPrice.CheckedItems)
                    {
                        unitPricePortion = unitPricePortion + " '" + i.ToString() + "',";
                    }
                    unitPricePortion = unitPricePortion.Remove(unitPricePortion.Length - 1);
                    unitPricePortion = unitPricePortion + ")";
                }
            }

            strFilterQuery = strFilterQuery + " WHERE ";
            if (string.IsNullOrEmpty(unitPricePortion) == false)
            {
                strFilterQuery = strFilterQuery + unitPricePortion + " AND ";
            }

            if (string.IsNullOrEmpty(manufacturerNamePortion) == false)
            {
                strFilterQuery = strFilterQuery + manufacturerNamePortion + " AND ";
            }

            if (string.IsNullOrEmpty(productTypePortion) == false)
            {
                strFilterQuery = strFilterQuery + productTypePortion + " AND ";
            }

            if (strFilterQuery.EndsWith(" WHERE "))
            {
                strFilterQuery = strFilterQuery.Remove(strFilterQuery.Length - 7);
            }
            if (strFilterQuery.EndsWith(" AND "))
            {
                strFilterQuery = strFilterQuery.Remove(strFilterQuery.Length - 5);
            }
            Console.WriteLine(strFilterQuery);
            return strFilterQuery;
        }

        private void drProducts_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

