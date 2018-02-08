namespace CanEastVending
{
    partial class frmProducts
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label productTypeLabel;
            System.Windows.Forms.Label manufacturerNameLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label volumeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.drProducts = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerNameTextBox = new System.Windows.Forms.TextBox();
            this.productTypeTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterManufacturerName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFilterProductType = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.chklstUnitPrice = new System.Windows.Forms.CheckedListBox();
            this.lblFilterUnitPrice = new System.Windows.Forms.Label();
            this.chklstManufacturerName = new System.Windows.Forms.CheckedListBox();
            this.chklstProductType = new System.Windows.Forms.CheckedListBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new CanEastVending.DatabaseDataSet();
            this.productTableAdapter = new CanEastVending.DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new CanEastVending.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.lblNoResults = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            productTypeLabel = new System.Windows.Forms.Label();
            manufacturerNameLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            volumeLabel = new System.Windows.Forms.Label();
            this.drProducts.ItemTemplate.SuspendLayout();
            this.drProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(124, 6);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(365, 6);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(129, 32);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 4;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Location = new System.Drawing.Point(369, 32);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new System.Drawing.Size(74, 13);
            productTypeLabel.TabIndex = 6;
            productTypeLabel.Text = "Product Type:";
            // 
            // manufacturerNameLabel
            // 
            manufacturerNameLabel.AutoSize = true;
            manufacturerNameLabel.Location = new System.Drawing.Point(339, 58);
            manufacturerNameLabel.Name = "manufacturerNameLabel";
            manufacturerNameLabel.Size = new System.Drawing.Size(104, 13);
            manufacturerNameLabel.TabIndex = 8;
            manufacturerNameLabel.Text = "Manufacturer Name:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(114, 58);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 10;
            weightLabel.Text = "Weight:";
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Location = new System.Drawing.Point(217, 58);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new System.Drawing.Size(45, 13);
            volumeLabel.TabIndex = 12;
            volumeLabel.Text = "Volume:";
            // 
            // drProducts
            // 
            // 
            // drProducts.ItemTemplate
            // 
            this.drProducts.ItemTemplate.Controls.Add(this.picturePictureBox);
            this.drProducts.ItemTemplate.Controls.Add(volumeLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.volumeTextBox);
            this.drProducts.ItemTemplate.Controls.Add(weightLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.weightTextBox);
            this.drProducts.ItemTemplate.Controls.Add(manufacturerNameLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.manufacturerNameTextBox);
            this.drProducts.ItemTemplate.Controls.Add(productTypeLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.productTypeTextBox);
            this.drProducts.ItemTemplate.Controls.Add(unitPriceLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.unitPriceTextBox);
            this.drProducts.ItemTemplate.Controls.Add(productNameLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.productNameTextBox);
            this.drProducts.ItemTemplate.Controls.Add(productIDLabel);
            this.drProducts.ItemTemplate.Controls.Add(this.productIDTextBox);
            this.drProducts.ItemTemplate.Size = new System.Drawing.Size(610, 108);
            this.drProducts.Location = new System.Drawing.Point(12, 39);
            this.drProducts.Name = "drProducts";
            this.drProducts.Size = new System.Drawing.Size(618, 349);
            this.drProducts.TabIndex = 0;
            this.drProducts.Text = "dataRepeater1";
            this.drProducts.CurrentItemIndexChanged += new System.EventHandler(this.drProducts_CurrentItemIndexChanged);
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Volume", true));
            this.volumeTextBox.Location = new System.Drawing.Point(268, 55);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.ReadOnly = true;
            this.volumeTextBox.Size = new System.Drawing.Size(47, 20);
            this.volumeTextBox.TabIndex = 13;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(164, 55);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ReadOnly = true;
            this.weightTextBox.Size = new System.Drawing.Size(47, 20);
            this.weightTextBox.TabIndex = 11;
            // 
            // manufacturerNameTextBox
            // 
            this.manufacturerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ManufacturerName", true));
            this.manufacturerNameTextBox.Location = new System.Drawing.Point(449, 55);
            this.manufacturerNameTextBox.Name = "manufacturerNameTextBox";
            this.manufacturerNameTextBox.ReadOnly = true;
            this.manufacturerNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.manufacturerNameTextBox.TabIndex = 9;
            this.manufacturerNameTextBox.TextChanged += new System.EventHandler(this.manufacturerNameTextBox_TextChanged);
            // 
            // productTypeTextBox
            // 
            this.productTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductType", true));
            this.productTypeTextBox.Location = new System.Drawing.Point(449, 29);
            this.productTypeTextBox.Name = "productTypeTextBox";
            this.productTypeTextBox.ReadOnly = true;
            this.productTypeTextBox.Size = new System.Drawing.Size(138, 20);
            this.productTypeTextBox.TabIndex = 7;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(191, 29);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.ReadOnly = true;
            this.unitPriceTextBox.Size = new System.Drawing.Size(124, 20);
            this.unitPriceTextBox.TabIndex = 5;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(449, 3);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(191, 3);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.productIDTextBox.TabIndex = 1;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(733, 25);
            this.productBindingNavigator.TabIndex = 1;
            this.productBindingNavigator.Text = "bindingNavigator1";
            this.productBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.Controls.Add(this.chkFilter);
            this.panel1.Controls.Add(this.lblProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 33);
            this.panel1.TabIndex = 9;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(454, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(90, 13);
            this.lblFilter.TabIndex = 23;
            this.lblFilter.Text = "Filter selection";
            // 
            // chkFilter
            // 
            this.chkFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFilter.Location = new System.Drawing.Point(551, 4);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(82, 23);
            this.chkFilter.TabIndex = 20;
            this.chkFilter.Text = "Filter";
            this.chkFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(12, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(113, 33);
            this.lblProducts.TabIndex = 9;
            this.lblProducts.Text = "Products";
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(15, 392);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(82, 13);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "0 result(s) found";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFilter.Controls.Add(this.lblFilterManufacturerName);
            this.pnlFilter.Controls.Add(this.btnCancel);
            this.pnlFilter.Controls.Add(this.lblFilterProductType);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.chklstUnitPrice);
            this.pnlFilter.Controls.Add(this.lblFilterUnitPrice);
            this.pnlFilter.Controls.Add(this.chklstManufacturerName);
            this.pnlFilter.Controls.Add(this.chklstProductType);
            this.pnlFilter.Location = new System.Drawing.Point(636, 33);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(181, 381);
            this.pnlFilter.TabIndex = 11;
            // 
            // lblFilterManufacturerName
            // 
            this.lblFilterManufacturerName.AutoSize = true;
            this.lblFilterManufacturerName.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterManufacturerName.Location = new System.Drawing.Point(9, 3);
            this.lblFilterManufacturerName.Name = "lblFilterManufacturerName";
            this.lblFilterManufacturerName.Size = new System.Drawing.Size(122, 13);
            this.lblFilterManufacturerName.TabIndex = 27;
            this.lblFilterManufacturerName.Text = "Manufacturer Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(93, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFilterProductType
            // 
            this.lblFilterProductType.AutoSize = true;
            this.lblFilterProductType.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterProductType.Location = new System.Drawing.Point(9, 117);
            this.lblFilterProductType.Name = "lblFilterProductType";
            this.lblFilterProductType.Size = new System.Drawing.Size(87, 13);
            this.lblFilterProductType.TabIndex = 26;
            this.lblFilterProductType.Text = "Product Type:";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(12, 346);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 23;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chklstUnitPrice
            // 
            this.chklstUnitPrice.CheckOnClick = true;
            this.chklstUnitPrice.FormattingEnabled = true;
            this.chklstUnitPrice.Location = new System.Drawing.Point(12, 246);
            this.chklstUnitPrice.Name = "chklstUnitPrice";
            this.chklstUnitPrice.Size = new System.Drawing.Size(156, 94);
            this.chklstUnitPrice.TabIndex = 2;
            this.chklstUnitPrice.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstUnitPrice_ItemCheck);
            // 
            // lblFilterUnitPrice
            // 
            this.lblFilterUnitPrice.AutoSize = true;
            this.lblFilterUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterUnitPrice.Location = new System.Drawing.Point(9, 230);
            this.lblFilterUnitPrice.Name = "lblFilterUnitPrice";
            this.lblFilterUnitPrice.Size = new System.Drawing.Size(86, 13);
            this.lblFilterUnitPrice.TabIndex = 25;
            this.lblFilterUnitPrice.Text = "Unit Price ($):";
            // 
            // chklstManufacturerName
            // 
            this.chklstManufacturerName.CheckOnClick = true;
            this.chklstManufacturerName.FormattingEnabled = true;
            this.chklstManufacturerName.Location = new System.Drawing.Point(12, 20);
            this.chklstManufacturerName.Name = "chklstManufacturerName";
            this.chklstManufacturerName.Size = new System.Drawing.Size(156, 94);
            this.chklstManufacturerName.TabIndex = 1;
            this.chklstManufacturerName.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstManufacturerName_ItemCheck);
            this.chklstManufacturerName.SelectedIndexChanged += new System.EventHandler(this.chklstManufacturerName_SelectedIndexChanged);
            // 
            // chklstProductType
            // 
            this.chklstProductType.CheckOnClick = true;
            this.chklstProductType.FormattingEnabled = true;
            this.chklstProductType.Location = new System.Drawing.Point(12, 133);
            this.chklstProductType.Name = "chklstProductType";
            this.chklstProductType.Size = new System.Drawing.Size(156, 94);
            this.chklstProductType.TabIndex = 0;
            this.chklstProductType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstProductType_ItemCheck);
            this.chklstProductType.SelectedIndexChanged += new System.EventHandler(this.chklstProductType_SelectedIndexChanged);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(3, 3);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(105, 97);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 15;
            this.picturePictureBox.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.MachineInventoryTableAdapter = null;
            this.tableAdapterManager.MachineTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RentalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CanEastVending.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNoResults.Location = new System.Drawing.Point(28, 64);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(493, 33);
            this.lblNoResults.TabIndex = 13;
            this.lblNoResults.Text = "No products found for the given selections";
            this.lblNoResults.Visible = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 414);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.drProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 452);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.drProducts.ItemTemplate.ResumeLayout(false);
            this.drProducts.ItemTemplate.PerformLayout();
            this.drProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.DataRepeater drProducts;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox manufacturerNameTextBox;
        private System.Windows.Forms.TextBox productTypeTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.CheckedListBox chklstUnitPrice;
        private System.Windows.Forms.CheckedListBox chklstManufacturerName;
        private System.Windows.Forms.CheckedListBox chklstProductType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterManufacturerName;
        private System.Windows.Forms.Label lblFilterProductType;
        private System.Windows.Forms.Label lblFilterUnitPrice;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.Label lblNoResults;
    }
}