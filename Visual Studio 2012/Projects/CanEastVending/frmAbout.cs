using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanEastVending
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://localhost:37926/Home.html";
            this.llblVisitWebsite.Links.Add(link);
        }

        private void llblVisitWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
