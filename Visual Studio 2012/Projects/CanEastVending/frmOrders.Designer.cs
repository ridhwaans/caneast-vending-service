namespace CanEastVending
{
    partial class frmOrders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new CanEastVending.DatabaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrders = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new CanEastVending.DatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.pnlMakeOrder = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.cboContractID = new System.Windows.Forms.ComboBox();
            this.rentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.chkMakeOrder = new System.Windows.Forms.CheckBox();
            this.rentalsTableAdapter = new CanEastVending.DatabaseDataSetTableAdapters.RentalsTableAdapter();
            this.chkEditOrder = new System.Windows.Forms.CheckBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblAddorEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMakeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = true;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.contractIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.ordersBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(12, 58);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(803, 183);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.HeaderText = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            this.contractIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            this.requiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shippedDateDataGridViewTextBoxColumn
            // 
            this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
            this.shippedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddorEdit);
            this.panel1.Controls.Add(this.lblOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 37);
            this.panel1.TabIndex = 15;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblOrders.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(12, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(92, 33);
            this.lblOrders.TabIndex = 2;
            this.lblOrders.Text = "Orders";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // pnlMakeOrder
            // 
            this.pnlMakeOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMakeOrder.Controls.Add(this.txtOrderID);
            this.pnlMakeOrder.Controls.Add(this.nudQuantity);
            this.pnlMakeOrder.Controls.Add(this.btnCancel);
            this.pnlMakeOrder.Controls.Add(this.btnOK);
            this.pnlMakeOrder.Controls.Add(this.label8);
            this.pnlMakeOrder.Controls.Add(this.label7);
            this.pnlMakeOrder.Controls.Add(this.label6);
            this.pnlMakeOrder.Controls.Add(this.label5);
            this.pnlMakeOrder.Controls.Add(this.label4);
            this.pnlMakeOrder.Controls.Add(this.label3);
            this.pnlMakeOrder.Controls.Add(this.label2);
            this.pnlMakeOrder.Controls.Add(this.label1);
            this.pnlMakeOrder.Controls.Add(this.cboProduct);
            this.pnlMakeOrder.Controls.Add(this.cboContractID);
            this.pnlMakeOrder.Controls.Add(this.cboEmployee);
            this.pnlMakeOrder.Controls.Add(this.dtpShippedDate);
            this.pnlMakeOrder.Controls.Add(this.dtpRequiredDate);
            this.pnlMakeOrder.Controls.Add(this.dtpOrderDate);
            this.pnlMakeOrder.Location = new System.Drawing.Point(13, 278);
            this.pnlMakeOrder.Name = "pnlMakeOrder";
            this.pnlMakeOrder.Size = new System.Drawing.Size(801, 138);
            this.pnlMakeOrder.TabIndex = 16;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(14, 22);
            this.txtOrderID.MaxLength = 5;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 20);
            this.txtOrderID.TabIndex = 23;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(649, 23);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(41, 20);
            this.nudQuantity.TabIndex = 22;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(721, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Chartreuse;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(640, 104);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ShippedDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "RequiredDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "OrderDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ContractID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "OrderID";
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(302, 23);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(341, 21);
            this.cboProduct.TabIndex = 11;
            // 
            // cboContractID
            // 
            this.cboContractID.DataSource = this.rentalsBindingSource;
            this.cboContractID.DisplayMember = "ContractID";
            this.cboContractID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContractID.FormattingEnabled = true;
            this.cboContractID.Location = new System.Drawing.Point(14, 63);
            this.cboContractID.Name = "cboContractID";
            this.cboContractID.Size = new System.Drawing.Size(121, 21);
            this.cboContractID.TabIndex = 10;
            this.cboContractID.ValueMember = "ContractID";
            // 
            // rentalsBindingSource
            // 
            this.rentalsBindingSource.DataMember = "Rentals";
            this.rentalsBindingSource.DataSource = this.databaseDataSet;
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(302, 64);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(166, 21);
            this.cboEmployee.TabIndex = 8;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.CustomFormat = "";
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(168, 64);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(103, 20);
            this.dtpShippedDate.TabIndex = 7;
            this.dtpShippedDate.ValueChanged += new System.EventHandler(this.dtpShippedDate_ValueChanged);
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.CustomFormat = "";
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(168, 104);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(103, 20);
            this.dtpRequiredDate.TabIndex = 6;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(168, 23);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(103, 20);
            this.dtpOrderDate.TabIndex = 5;
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // chkMakeOrder
            // 
            this.chkMakeOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMakeOrder.Location = new System.Drawing.Point(12, 247);
            this.chkMakeOrder.Name = "chkMakeOrder";
            this.chkMakeOrder.Size = new System.Drawing.Size(82, 23);
            this.chkMakeOrder.TabIndex = 19;
            this.chkMakeOrder.Text = "Make Order";
            this.chkMakeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMakeOrder.UseVisualStyleBackColor = true;
            this.chkMakeOrder.CheckedChanged += new System.EventHandler(this.chkMakeOrder_CheckedChanged);
            // 
            // rentalsTableAdapter
            // 
            this.rentalsTableAdapter.ClearBeforeFill = true;
            // 
            // chkEditOrder
            // 
            this.chkEditOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEditOrder.Location = new System.Drawing.Point(100, 247);
            this.chkEditOrder.Name = "chkEditOrder";
            this.chkEditOrder.Size = new System.Drawing.Size(82, 23);
            this.chkEditOrder.TabIndex = 21;
            this.chkEditOrder.Text = "Edit Order";
            this.chkEditOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEditOrder.UseVisualStyleBackColor = true;
            this.chkEditOrder.CheckedChanged += new System.EventHandler(this.chkEditOrder_CheckedChanged);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.White;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Location = new System.Drawing.Point(188, 247);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteOrder.TabIndex = 22;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblAddorEdit
            // 
            this.lblAddorEdit.AutoSize = true;
            this.lblAddorEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddorEdit.Location = new System.Drawing.Point(108, 15);
            this.lblAddorEdit.Name = "lblAddorEdit";
            this.lblAddorEdit.Size = new System.Drawing.Size(113, 13);
            this.lblAddorEdit.TabIndex = 23;
            this.lblAddorEdit.Text = "Make a New Order";
            this.lblAddorEdit.Visible = false;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 424);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.chkEditOrder);
            this.Controls.Add(this.chkMakeOrder);
            this.Controls.Add(this.pnlMakeOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(842, 38);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMakeOrder.ResumeLayout(false);
            this.pnlMakeOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOrders;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlMakeOrder;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.ComboBox cboContractID;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.CheckBox chkMakeOrder;
        private System.Windows.Forms.BindingSource rentalsBindingSource;
        private DatabaseDataSetTableAdapters.RentalsTableAdapter rentalsTableAdapter;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.CheckBox chkEditOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblAddorEdit;
    }
}