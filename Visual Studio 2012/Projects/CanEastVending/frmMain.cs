using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// This is our C# desktop application program which makes use of the same database as the web interface and allows the user to do a variety of different things.
// The GUI and forms carry out SQL select, insert into, update and delete statements to add, edit, or remove data and records into or from each of our CanEastVending database relations

namespace CanEastVending
{
    public partial class frmMain : Form
    {
        public const string strGuestUserName = "guest";
        public const string strGuestPassword = "thedataminers";

        public frmMain()
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(255, 221, 220, 220);
            this.TransparencyKey = c;
            panel1.BackColor = c;
            this.ShowIcon = false;
            this.lblCanEastVending.Visible = false;
            this.btnLogInOut.Text = "Login";
            this.txtUsername.Focus();

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://localhost:37926/Home.html";
            this.llblVisitWebsite.Links.Add(link);
            this.llblVisitCanEastVendingWebSite.Links.Add(link);

            Global.openConnection();
            txtUsername.Text = strGuestUserName;
            txtPassword.Text = strGuestPassword;

        }

        private void llblVisitWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }


        private void pnlCustomers_MouseEnter(object sender, System.EventArgs e) 
        {
            clearSelection();
            pnlCustomers.BackColor = Color.LightCyan;
        }

        private void pnlEmployees_MouseEnter(object sender, System.EventArgs e)
        {
            clearSelection();
            pnlEmployees.BackColor = Color.LightCyan;
        }

        private void pnlMachines_MouseEnter(object sender, System.EventArgs e)
        {
            clearSelection();
            pnlMachines.BackColor = Color.LightCyan;
        }

        private void pnlOrders_MouseEnter(object sender, System.EventArgs e)
        {
            clearSelection();
            pnlOrders.BackColor = Color.LightCyan;
        }

        private void pnlProducts_MouseEnter(object sender, System.EventArgs e)
        {
            clearSelection();
            pnlProducts.BackColor = Color.LightCyan;
        }

        private void pnlAbout_MouseEnter(object sender, System.EventArgs e)
        {
            clearSelection();
            pnlAbout.BackColor = Color.LightCyan;
        }

        private void frmMain_MouseEnter(object sender, System.EventArgs e)
        {
            clearSelection();
        }

        private void clearSelection()
        {
            pnlCustomers.BackColor = Color.Transparent;
            pnlEmployees.BackColor = Color.Transparent;
            pnlMachines.BackColor = Color.Transparent;
            pnlOrders.BackColor = Color.Transparent;
            pnlProducts.BackColor = Color.Transparent;
            pnlAbout.BackColor = Color.Transparent;
        }

        private void llblCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void llblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void llblEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
        }

        private void llblOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOrders frmOrders = new frmOrders();
            frmOrders.ShowDialog();
        }

        private void llblProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void llblMachines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMachines frmMachines = new frmMachines();
            frmMachines.ShowDialog();
        }

        private void lblFootNote_Click(object sender, EventArgs e)
        {

        }

        private void btnLogInOut_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtUsername.Text)) & (!string.IsNullOrEmpty(txtPassword.Text)))
            {//ONCAMPUS login credentials work only when on campus (connected to ONCAMPUS network group)
                //else use guest credentials
                if ((txtUsername.Text == strGuestUserName && txtPassword.Text == strGuestPassword) || (ValidateActiveDirectoryLogin(Environment.UserDomainName, txtUsername.Text, txtPassword.Text)))
                {
                    if (pnlLogin.Visible == true)
                    {
                        lblCanEastVending.Visible = true;
                        lblUsername.Visible = false;
                        lblPassword.Visible = false;
                        txtUsername.Visible = false;
                        txtPassword.Visible = false;
                        lblUser.Visible = true;
                        lblLoginErrorMessage.Visible = false;
                        lblUser.Text = txtUsername.Text;
                        this.btnLogInOut.Text = "Logout";
                        pnlLogin.Visible = false;
                    }
                    else
                    {
                        lblCanEastVending.Visible = false;
                        lblUsername.Visible = true;
                        lblPassword.Visible = true;
                        txtUsername.Visible = true;
                        txtPassword.Visible = true;
                        lblUser.Visible = false;
                        this.btnLogInOut.Text = "Login";
                        pnlLogin.Visible = true;
                        this.txtUsername.Focus();
                    }
                }
                else
                {
                    lblLoginErrorMessage.Visible = true;
                }
            }
        }

        private bool ValidateActiveDirectoryLogin(string Domain, string Username, string Password)
        {
            bool Success = false;
            System.DirectoryServices.DirectoryEntry Entry = new System.DirectoryServices.DirectoryEntry("LDAP://" + Domain, Username, Password);
            System.DirectoryServices.DirectorySearcher Searcher = new System.DirectoryServices.DirectorySearcher(Entry);
            Searcher.SearchScope = System.DirectoryServices.SearchScope.OneLevel;
            try
            {
                System.DirectoryServices.SearchResult Results = Searcher.FindOne();
                Success = (Results != null);

                //System.DirectoryServices.SearchResultCollection result = Searcher.FindAll();
                //MessageBox.Show(result.Count.ToString());
                //foreach (System.DirectoryServices.SearchResult sr in result)
                //{
                //    Console.WriteLine(Convert.ToString(sr.GetDirectoryEntry()));
                //}

                //foreach (System.DirectoryServices.SearchResult sr in Searcher.FindAll())
                //{
                //    System.DirectoryServices.DirectoryEntry de = sr.GetDirectoryEntry();
                //    Console.WriteLine(de.Name.ToString());
                //}
            }
            catch
            {
                Success = false;
            }
            return Success;
        }

        private void picCustomersIcon_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }
        
        private void picMachinesIcon_Click(object sender, EventArgs e)
        {
            frmMachines frmMachines = new frmMachines();
            frmMachines.ShowDialog();
        }

        private void picEmployeesIcon_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
        }

        private void picOrdersIcon_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders();
            frmOrders.ShowDialog();
        }

        private void picProductsIcon_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void picAboutIcon_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
        }

        private void lblMachines_Click(object sender, EventArgs e)
        {
            frmMachines frmMachines = new frmMachines();
            frmMachines.ShowDialog();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders();
            frmOrders.ShowDialog();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogInOut.PerformClick();
            }
        }

        private void txtPassword_GotFocus(Object sender, EventArgs e)
        {
            txtPassword.SelectionStart = 0;
            txtPassword.SelectionLength = txtPassword.Text.Length;
        }

        private void llblVisitCanEastVendingWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void llblUseCanEastVendingWebServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWebServices frmWebServices = new frmWebServices();
            frmWebServices.ShowDialog();
        }

        


    }
}
