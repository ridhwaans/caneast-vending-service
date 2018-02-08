namespace CanEastVending
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picDataMinersLogo = new System.Windows.Forms.PictureBox();
            this.picCanEastVendingLogo = new System.Windows.Forms.PictureBox();
            this.llblVisitWebsite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picDataMinersLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanEastVendingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(152, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Can-East Vending Inc. is an Ontario-based distributor of vending machines that pr" +
    "ovides vending machine customer \r\nrentals and services.\r\n\r\n\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desktop user application program (version 1.0) developed in C# as part of the ENG" +
    "R 3700U Data Management Systems database application system project";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(152, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 129);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CanEastVending";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "The Data Miners group";
            // 
            // picDataMinersLogo
            // 
            this.picDataMinersLogo.Image = global::CanEastVending.Properties.Resources.dataminers_logo;
            this.picDataMinersLogo.Location = new System.Drawing.Point(23, 136);
            this.picDataMinersLogo.Name = "picDataMinersLogo";
            this.picDataMinersLogo.Size = new System.Drawing.Size(112, 113);
            this.picDataMinersLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDataMinersLogo.TabIndex = 1;
            this.picDataMinersLogo.TabStop = false;
            // 
            // picCanEastVendingLogo
            // 
            this.picCanEastVendingLogo.Image = global::CanEastVending.Properties.Resources.caneastvending_logo;
            this.picCanEastVendingLogo.Location = new System.Drawing.Point(12, 12);
            this.picCanEastVendingLogo.Name = "picCanEastVendingLogo";
            this.picCanEastVendingLogo.Size = new System.Drawing.Size(134, 84);
            this.picCanEastVendingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanEastVendingLogo.TabIndex = 0;
            this.picCanEastVendingLogo.TabStop = false;
            // 
            // llblVisitWebsite
            // 
            this.llblVisitWebsite.AutoSize = true;
            this.llblVisitWebsite.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblVisitWebsite.Location = new System.Drawing.Point(134, 334);
            this.llblVisitWebsite.Name = "llblVisitWebsite";
            this.llblVisitWebsite.Size = new System.Drawing.Size(80, 15);
            this.llblVisitWebsite.TabIndex = 36;
            this.llblVisitWebsite.TabStop = true;
            this.llblVisitWebsite.Text = "Visit Website";
            this.llblVisitWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblVisitWebsite_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 358);
            this.Controls.Add(this.llblVisitWebsite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDataMinersLogo);
            this.Controls.Add(this.picCanEastVendingLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDataMinersLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanEastVendingLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanEastVendingLogo;
        private System.Windows.Forms.PictureBox picDataMinersLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llblVisitWebsite;
    }
}