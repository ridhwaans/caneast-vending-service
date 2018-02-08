using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Here, the desktop database application makes use of the same web services found in the web interface and makes a web service reference to it (SOAP client)
namespace CanEastVending
{
    public partial class frmWebServices : Form
    {
        public frmWebServices()
        {
            InitializeComponent();
        }

        private void tlpWebServices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtViewCurrentInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flpWebServices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInvoke1_Click(object sender, EventArgs e)
        {
            CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient myCanEastVendingWebServices = new CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient();
            lblTimeSpanOutput.Text = myCanEastVendingWebServices.findTimeSpan(txtFindTimeSpan.Text);
        }

        private void btnInvoke2_Click(object sender, EventArgs e)
        {
            CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient myCanEastVendingWebServices = new CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient();
            dgvViewCurrentInventory.DataSource = myCanEastVendingWebServices.viewCurrentInventory(txtViewCurrentInventory.Text).Tables[0];
        }

        private void btnInvoke3_Click(object sender, EventArgs e)
        {
            CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient myCanEastVendingWebServices = new CanEastVendingWebServiceReference.CanEastVendingWebServicesSoapClient();
            lblDateShippedOutput.Text = myCanEastVendingWebServices.checkDateShipped(txtCheckDateShipped.Text);
        }

        private void dgvViewCurrentInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
