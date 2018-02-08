namespace CanEastVending
{
    partial class frmMachines
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMachines));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblMachines = new System.Windows.Forms.Label();
            this.lvMachines = new System.Windows.Forms.ListView();
            this.imgMachinePictures = new System.Windows.Forms.ImageList(this.components);
            this.lblMachineID = new System.Windows.Forms.Label();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblDateLastRestocked = new System.Windows.Forms.Label();
            this.lblNextRestockDate = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMachineInfo = new System.Windows.Forms.Panel();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlRentalInfo = new System.Windows.Forms.Panel();
            this.lblCurrentInventory = new System.Windows.Forms.Label();
            this.tcMachineDetail = new System.Windows.Forms.TabControl();
            this.tbpInventoryInfo = new System.Windows.Forms.TabPage();
            this.tbpRentalInfo = new System.Windows.Forms.TabPage();
            this.tbpMachineInfo = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMakeRental = new System.Windows.Forms.Button();
            this.btnEndRental = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.msktxtContractID = new System.Windows.Forms.MaskedTextBox();
            this.msktxtLocationID = new System.Windows.Forms.MaskedTextBox();
            this.dtpContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtPhysicalPlacement = new System.Windows.Forms.TextBox();
            this.btnMakeRental1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEndRental1 = new System.Windows.Forms.Button();
            this.txtContractStartDate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMachineInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlRentalInfo.SuspendLayout();
            this.tcMachineDetail.SuspendLayout();
            this.tbpInventoryInfo.SuspendLayout();
            this.tbpRentalInfo.SuspendLayout();
            this.tbpMachineInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAction);
            this.panel1.Controls.Add(this.lblMachines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 37);
            this.panel1.TabIndex = 16;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(141, 15);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(90, 13);
            this.lblAction.TabIndex = 23;
            this.lblAction.Text = "Make a Rental";
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.BackColor = System.Drawing.Color.Transparent;
            this.lblMachines.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachines.Location = new System.Drawing.Point(12, 0);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(123, 33);
            this.lblMachines.TabIndex = 2;
            this.lblMachines.Text = "Machines";
            // 
            // lvMachines
            // 
            this.lvMachines.LargeImageList = this.imgMachinePictures;
            this.lvMachines.Location = new System.Drawing.Point(12, 51);
            this.lvMachines.MultiSelect = false;
            this.lvMachines.Name = "lvMachines";
            this.lvMachines.Size = new System.Drawing.Size(274, 350);
            this.lvMachines.TabIndex = 21;
            this.lvMachines.UseCompatibleStateImageBehavior = false;
            this.lvMachines.View = System.Windows.Forms.View.Tile;
            this.lvMachines.SelectedIndexChanged += new System.EventHandler(this.lvMachines_SelectedIndexChanged);
            // 
            // imgMachinePictures
            // 
            this.imgMachinePictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMachinePictures.ImageStream")));
            this.imgMachinePictures.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMachinePictures.Images.SetKeyName(0, "iVend 2.0.jpg");
            this.imgMachinePictures.Images.SetKeyName(1, "iVend.jpg");
            this.imgMachinePictures.Images.SetKeyName(2, "ProVendor.jpg");
            this.imgMachinePictures.Images.SetKeyName(3, "UltraVendmaster.jpg");
            this.imgMachinePictures.Images.SetKeyName(4, "VendMaster 2000.jpg");
            this.imgMachinePictures.Images.SetKeyName(5, "VendMaster 3000.jpg");
            this.imgMachinePictures.Images.SetKeyName(6, "VendMaster 4000.jpg");
            // 
            // lblMachineID
            // 
            this.lblMachineID.AutoSize = true;
            this.lblMachineID.Location = new System.Drawing.Point(119, 4);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(65, 13);
            this.lblMachineID.TabIndex = 32;
            this.lblMachineID.Text = "[MachineID]";
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.AutoSize = true;
            this.lblManufactureDate.Location = new System.Drawing.Point(119, 125);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(96, 13);
            this.lblManufactureDate.TabIndex = 33;
            this.lblManufactureDate.Text = "[ManufactureDate]";
            // 
            // lblDateLastRestocked
            // 
            this.lblDateLastRestocked.AutoSize = true;
            this.lblDateLastRestocked.Location = new System.Drawing.Point(119, 150);
            this.lblDateLastRestocked.Name = "lblDateLastRestocked";
            this.lblDateLastRestocked.Size = new System.Drawing.Size(108, 13);
            this.lblDateLastRestocked.TabIndex = 34;
            this.lblDateLastRestocked.Text = "[DateLastRestocked]";
            // 
            // lblNextRestockDate
            // 
            this.lblNextRestockDate.AutoSize = true;
            this.lblNextRestockDate.Location = new System.Drawing.Point(119, 177);
            this.lblNextRestockDate.Name = "lblNextRestockDate";
            this.lblNextRestockDate.Size = new System.Drawing.Size(98, 13);
            this.lblNextRestockDate.TabIndex = 35;
            this.lblNextRestockDate.Text = "[NextRestockDate]";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(119, 100);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(54, 13);
            this.lblCapacity.TabIndex = 36;
            this.lblCapacity.Text = "[Capacity]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "MachineID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "ManufactureDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "DateLastRestocked:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "NextRestockDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Capacity:";
            // 
            // pnlMachineInfo
            // 
            this.pnlMachineInfo.BackColor = System.Drawing.Color.White;
            this.pnlMachineInfo.Controls.Add(this.label8);
            this.pnlMachineInfo.Controls.Add(this.label7);
            this.pnlMachineInfo.Controls.Add(this.label6);
            this.pnlMachineInfo.Controls.Add(this.lblModelNumber);
            this.pnlMachineInfo.Controls.Add(this.lblModelName);
            this.pnlMachineInfo.Controls.Add(this.lblStatus);
            this.pnlMachineInfo.Controls.Add(this.lblMachineID);
            this.pnlMachineInfo.Controls.Add(this.label5);
            this.pnlMachineInfo.Controls.Add(this.lblManufactureDate);
            this.pnlMachineInfo.Controls.Add(this.label4);
            this.pnlMachineInfo.Controls.Add(this.lblDateLastRestocked);
            this.pnlMachineInfo.Controls.Add(this.label3);
            this.pnlMachineInfo.Controls.Add(this.lblNextRestockDate);
            this.pnlMachineInfo.Controls.Add(this.label2);
            this.pnlMachineInfo.Controls.Add(this.lblCapacity);
            this.pnlMachineInfo.Controls.Add(this.label1);
            this.pnlMachineInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlMachineInfo.Name = "pnlMachineInfo";
            this.pnlMachineInfo.Size = new System.Drawing.Size(236, 200);
            this.pnlMachineInfo.TabIndex = 42;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(6, 22);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(397, 174);
            this.dgvInventory.TabIndex = 43;
            // 
            // pnlRentalInfo
            // 
            this.pnlRentalInfo.Controls.Add(this.label17);
            this.pnlRentalInfo.Controls.Add(this.cboCustomer);
            this.pnlRentalInfo.Controls.Add(this.pictureBox3);
            this.pnlRentalInfo.Controls.Add(this.txtContractStartDate);
            this.pnlRentalInfo.Controls.Add(this.btnEndRental1);
            this.pnlRentalInfo.Controls.Add(this.btnCancel);
            this.pnlRentalInfo.Controls.Add(this.btnMakeRental1);
            this.pnlRentalInfo.Controls.Add(this.txtPhysicalPlacement);
            this.pnlRentalInfo.Controls.Add(this.txtPostalCode);
            this.pnlRentalInfo.Controls.Add(this.txtProvince);
            this.pnlRentalInfo.Controls.Add(this.txtAddress);
            this.pnlRentalInfo.Controls.Add(this.txtCity);
            this.pnlRentalInfo.Controls.Add(this.dtpContractStartDate);
            this.pnlRentalInfo.Controls.Add(this.msktxtLocationID);
            this.pnlRentalInfo.Controls.Add(this.msktxtContractID);
            this.pnlRentalInfo.Controls.Add(this.label16);
            this.pnlRentalInfo.Controls.Add(this.label15);
            this.pnlRentalInfo.Controls.Add(this.label14);
            this.pnlRentalInfo.Controls.Add(this.label13);
            this.pnlRentalInfo.Controls.Add(this.label12);
            this.pnlRentalInfo.Controls.Add(this.label11);
            this.pnlRentalInfo.Controls.Add(this.label10);
            this.pnlRentalInfo.Controls.Add(this.label9);
            this.pnlRentalInfo.Location = new System.Drawing.Point(6, 6);
            this.pnlRentalInfo.Name = "pnlRentalInfo";
            this.pnlRentalInfo.Size = new System.Drawing.Size(404, 318);
            this.pnlRentalInfo.TabIndex = 45;
            // 
            // lblCurrentInventory
            // 
            this.lblCurrentInventory.AutoSize = true;
            this.lblCurrentInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentInventory.Location = new System.Drawing.Point(6, 3);
            this.lblCurrentInventory.Name = "lblCurrentInventory";
            this.lblCurrentInventory.Size = new System.Drawing.Size(124, 16);
            this.lblCurrentInventory.TabIndex = 44;
            this.lblCurrentInventory.Text = "Current Inventory";
            // 
            // tcMachineDetail
            // 
            this.tcMachineDetail.Controls.Add(this.tbpMachineInfo);
            this.tcMachineDetail.Controls.Add(this.tbpInventoryInfo);
            this.tcMachineDetail.Controls.Add(this.tbpRentalInfo);
            this.tcMachineDetail.Location = new System.Drawing.Point(294, 51);
            this.tcMachineDetail.Name = "tcMachineDetail";
            this.tcMachineDetail.SelectedIndex = 0;
            this.tcMachineDetail.Size = new System.Drawing.Size(418, 350);
            this.tcMachineDetail.TabIndex = 46;
            // 
            // tbpInventoryInfo
            // 
            this.tbpInventoryInfo.Controls.Add(this.pictureBox2);
            this.tbpInventoryInfo.Controls.Add(this.lblCurrentInventory);
            this.tbpInventoryInfo.Controls.Add(this.dgvInventory);
            this.tbpInventoryInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpInventoryInfo.Name = "tbpInventoryInfo";
            this.tbpInventoryInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInventoryInfo.Size = new System.Drawing.Size(410, 324);
            this.tbpInventoryInfo.TabIndex = 0;
            this.tbpInventoryInfo.Text = "Inventory Info";
            this.tbpInventoryInfo.UseVisualStyleBackColor = true;
            // 
            // tbpRentalInfo
            // 
            this.tbpRentalInfo.Controls.Add(this.pnlRentalInfo);
            this.tbpRentalInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpRentalInfo.Name = "tbpRentalInfo";
            this.tbpRentalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRentalInfo.Size = new System.Drawing.Size(410, 324);
            this.tbpRentalInfo.TabIndex = 1;
            this.tbpRentalInfo.Text = "Rental Info";
            this.tbpRentalInfo.UseVisualStyleBackColor = true;
            // 
            // tbpMachineInfo
            // 
            this.tbpMachineInfo.Controls.Add(this.pictureBox1);
            this.tbpMachineInfo.Controls.Add(this.btnMakeRental);
            this.tbpMachineInfo.Controls.Add(this.btnEndRental);
            this.tbpMachineInfo.Controls.Add(this.pnlMachineInfo);
            this.tbpMachineInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpMachineInfo.Name = "tbpMachineInfo";
            this.tbpMachineInfo.Size = new System.Drawing.Size(410, 324);
            this.tbpMachineInfo.TabIndex = 2;
            this.tbpMachineInfo.Text = "Machine Info";
            this.tbpMachineInfo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(119, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "[Status]";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(119, 50);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(70, 13);
            this.lblModelName.TabIndex = 43;
            this.lblModelName.Text = "[ModelName]";
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(119, 75);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(79, 13);
            this.lblModelNumber.TabIndex = 44;
            this.lblModelNumber.Text = "[ModelNumber]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "ModelName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "ModelNumber:";
            // 
            // btnMakeRental
            // 
            this.btnMakeRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeRental.Location = new System.Drawing.Point(41, 209);
            this.btnMakeRental.Name = "btnMakeRental";
            this.btnMakeRental.Size = new System.Drawing.Size(135, 25);
            this.btnMakeRental.TabIndex = 43;
            this.btnMakeRental.Text = "Make Customer Rental";
            this.btnMakeRental.UseVisualStyleBackColor = true;
            this.btnMakeRental.Visible = false;
            this.btnMakeRental.Click += new System.EventHandler(this.btnMakeRental_Click);
            // 
            // btnEndRental
            // 
            this.btnEndRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndRental.Location = new System.Drawing.Point(41, 209);
            this.btnEndRental.Name = "btnEndRental";
            this.btnEndRental.Size = new System.Drawing.Size(135, 25);
            this.btnEndRental.TabIndex = 44;
            this.btnEndRental.Text = "End Machine Rental";
            this.btnEndRental.UseVisualStyleBackColor = true;
            this.btnEndRental.Visible = false;
            this.btnEndRental.Click += new System.EventHandler(this.btnEndRental_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ContractID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Contract Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "LocationID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "City:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Province:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Postal Code:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(152, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Physical Placement:";
            // 
            // msktxtContractID
            // 
            this.msktxtContractID.Location = new System.Drawing.Point(21, 25);
            this.msktxtContractID.Name = "msktxtContractID";
            this.msktxtContractID.Size = new System.Drawing.Size(100, 20);
            this.msktxtContractID.TabIndex = 9;
            this.msktxtContractID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtContractID_MaskInputRejected);
            // 
            // msktxtLocationID
            // 
            this.msktxtLocationID.Location = new System.Drawing.Point(21, 106);
            this.msktxtLocationID.Name = "msktxtLocationID";
            this.msktxtLocationID.Size = new System.Drawing.Size(100, 20);
            this.msktxtLocationID.TabIndex = 10;
            // 
            // dtpContractStartDate
            // 
            this.dtpContractStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContractStartDate.Location = new System.Drawing.Point(23, 67);
            this.dtpContractStartDate.Name = "dtpContractStartDate";
            this.dtpContractStartDate.Size = new System.Drawing.Size(99, 20);
            this.dtpContractStartDate.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(23, 148);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(153, 106);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(23, 187);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 14;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(153, 187);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 15;
            // 
            // txtPhysicalPlacement
            // 
            this.txtPhysicalPlacement.Location = new System.Drawing.Point(153, 148);
            this.txtPhysicalPlacement.Name = "txtPhysicalPlacement";
            this.txtPhysicalPlacement.Size = new System.Drawing.Size(177, 20);
            this.txtPhysicalPlacement.TabIndex = 16;
            // 
            // btnMakeRental1
            // 
            this.btnMakeRental1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeRental1.Location = new System.Drawing.Point(21, 223);
            this.btnMakeRental1.Name = "btnMakeRental1";
            this.btnMakeRental1.Size = new System.Drawing.Size(135, 25);
            this.btnMakeRental1.TabIndex = 44;
            this.btnMakeRental1.Text = "Make Customer Rental";
            this.btnMakeRental1.UseVisualStyleBackColor = true;
            this.btnMakeRental1.Visible = false;
            this.btnMakeRental1.Click += new System.EventHandler(this.btnMakeRental1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(21, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 25);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEndRental1
            // 
            this.btnEndRental1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndRental1.Location = new System.Drawing.Point(21, 223);
            this.btnEndRental1.Name = "btnEndRental1";
            this.btnEndRental1.Size = new System.Drawing.Size(135, 25);
            this.btnEndRental1.TabIndex = 46;
            this.btnEndRental1.Text = "End Machine Rental";
            this.btnEndRental1.UseVisualStyleBackColor = true;
            this.btnEndRental1.Visible = false;
            this.btnEndRental1.Click += new System.EventHandler(this.btnEndRental1_Click);
            // 
            // txtContractStartDate
            // 
            this.txtContractStartDate.Location = new System.Drawing.Point(23, 67);
            this.txtContractStartDate.Name = "txtContractStartDate";
            this.txtContractStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtContractStartDate.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CanEastVending.Properties.Resources.caneastvending_logo;
            this.pictureBox1.Location = new System.Drawing.Point(241, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CanEastVending.Properties.Resources.caneastvending_logo;
            this.pictureBox2.Location = new System.Drawing.Point(241, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::CanEastVending.Properties.Resources.caneastvending_logo;
            this.pictureBox3.Location = new System.Drawing.Point(235, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(155, 67);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(175, 21);
            this.cboCustomer.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(153, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Customer:";
            // 
            // frmMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 409);
            this.Controls.Add(this.tcMachineDetail);
            this.Controls.Add(this.lvMachines);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMachines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMachines_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMachineInfo.ResumeLayout(false);
            this.pnlMachineInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlRentalInfo.ResumeLayout(false);
            this.pnlRentalInfo.PerformLayout();
            this.tcMachineDetail.ResumeLayout(false);
            this.tbpInventoryInfo.ResumeLayout(false);
            this.tbpInventoryInfo.PerformLayout();
            this.tbpRentalInfo.ResumeLayout(false);
            this.tbpMachineInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.ListView lvMachines;
        private System.Windows.Forms.ImageList imgMachinePictures;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblDateLastRestocked;
        private System.Windows.Forms.Label lblNextRestockDate;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlMachineInfo;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Panel pnlRentalInfo;
        private System.Windows.Forms.Label lblCurrentInventory;
        private System.Windows.Forms.TabControl tcMachineDetail;
        private System.Windows.Forms.TabPage tbpInventoryInfo;
        private System.Windows.Forms.TabPage tbpRentalInfo;
        private System.Windows.Forms.TabPage tbpMachineInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnMakeRental;
        private System.Windows.Forms.Button btnEndRental;
        private System.Windows.Forms.MaskedTextBox msktxtContractID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpContractStartDate;
        private System.Windows.Forms.MaskedTextBox msktxtLocationID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMakeRental1;
        private System.Windows.Forms.TextBox txtPhysicalPlacement;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnEndRental1;
        private System.Windows.Forms.TextBox txtContractStartDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label17;
    }
}