namespace Project5_thfm2
{
    partial class frmMain
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblRegId = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.registerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomDay1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomDay2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.township1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amphoe1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCode1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townshipSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amphoeSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblRegId
            // 
            this.lblRegId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegId.AutoSize = true;
            this.lblRegId.Location = new System.Drawing.Point(10, 607);
            this.lblRegId.Name = "lblRegId";
            this.lblRegId.Size = new System.Drawing.Size(52, 13);
            this.lblRegId.TabIndex = 3;
            this.lblRegId.Text = "...............";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(322, 40);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(79, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(965, 596);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "ลบผู้สมัคร";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(874, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "แก้ไขข้อมูล";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(784, 597);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "เพิ่มผู้สมัคร";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ผู้ใช้ระบบ : ";
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoGenerateColumns = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerIdDataGridViewTextBoxColumn,
            this.titlenameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.classroomDay1NameDataGridViewTextBoxColumn,
            this.classroomDay2NameDataGridViewTextBoxColumn,
            this.dateRegisterDataGridViewTextBoxColumn,
            this.companyTypeNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.contactFirstnameDataGridViewTextBoxColumn,
            this.contactLastnameDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.texDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.township1DataGridViewTextBoxColumn,
            this.amphoe1DataGridViewTextBoxColumn,
            this.province1DataGridViewTextBoxColumn,
            this.zipCode1DataGridViewTextBoxColumn,
            this.addressSendDataGridViewTextBoxColumn,
            this.townshipSendDataGridViewTextBoxColumn,
            this.amphoeSendDataGridViewTextBoxColumn,
            this.provinceSendDataGridViewTextBoxColumn,
            this.zipCodeSendDataGridViewTextBoxColumn,
            this.billTypeNameDataGridViewTextBoxColumn,
            this.lFirstnameDataGridViewTextBoxColumn,
            this.lLastnameDataGridViewTextBoxColumn,
            this.lEmailDataGridViewTextBoxColumn,
            this.statusPayNameDataGridViewTextBoxColumn,
            this.billIdDataGridViewTextBoxColumn});
            this.gridView.DataSource = this.reportBindingSource;
            this.gridView.Location = new System.Drawing.Point(15, 82);
            this.gridView.Name = "gridView";
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(1025, 492);
            this.gridView.TabIndex = 10;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            this.gridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridView_RowPostPaint);
            this.gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyUp);
            // 
            // registerIdDataGridViewTextBoxColumn
            // 
            this.registerIdDataGridViewTextBoxColumn.DataPropertyName = "Register_Id";
            this.registerIdDataGridViewTextBoxColumn.HeaderText = "เลขที่ใบสมัคร";
            this.registerIdDataGridViewTextBoxColumn.Name = "registerIdDataGridViewTextBoxColumn";
            // 
            // titlenameDataGridViewTextBoxColumn
            // 
            this.titlenameDataGridViewTextBoxColumn.DataPropertyName = "Titlename";
            this.titlenameDataGridViewTextBoxColumn.HeaderText = "คำนำหน้าชื่อ";
            this.titlenameDataGridViewTextBoxColumn.Name = "titlenameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "ชื่อ";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "นามสกุล";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "ตำแหน่ง";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // classroomDay1NameDataGridViewTextBoxColumn
            // 
            this.classroomDay1NameDataGridViewTextBoxColumn.DataPropertyName = "ClassroomDay1_Name";
            this.classroomDay1NameDataGridViewTextBoxColumn.HeaderText = "สำรองที่นั่งวันแรก";
            this.classroomDay1NameDataGridViewTextBoxColumn.Name = "classroomDay1NameDataGridViewTextBoxColumn";
            // 
            // classroomDay2NameDataGridViewTextBoxColumn
            // 
            this.classroomDay2NameDataGridViewTextBoxColumn.DataPropertyName = "ClassroomDay2_Name";
            this.classroomDay2NameDataGridViewTextBoxColumn.HeaderText = "สำรองที่นั่งวันที่สอง";
            this.classroomDay2NameDataGridViewTextBoxColumn.Name = "classroomDay2NameDataGridViewTextBoxColumn";
            // 
            // dateRegisterDataGridViewTextBoxColumn
            // 
            this.dateRegisterDataGridViewTextBoxColumn.DataPropertyName = "DateRegister";
            this.dateRegisterDataGridViewTextBoxColumn.HeaderText = "วันที่สมัคร";
            this.dateRegisterDataGridViewTextBoxColumn.Name = "dateRegisterDataGridViewTextBoxColumn";
            // 
            // companyTypeNameDataGridViewTextBoxColumn
            // 
            this.companyTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyType_Name";
            this.companyTypeNameDataGridViewTextBoxColumn.HeaderText = "ประเภทหน่วยงาน";
            this.companyTypeNameDataGridViewTextBoxColumn.Name = "companyTypeNameDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "ชื่อหน่วยงาน";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // contactFirstnameDataGridViewTextBoxColumn
            // 
            this.contactFirstnameDataGridViewTextBoxColumn.DataPropertyName = "Contact_Firstname";
            this.contactFirstnameDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ประสานงาน";
            this.contactFirstnameDataGridViewTextBoxColumn.Name = "contactFirstnameDataGridViewTextBoxColumn";
            // 
            // contactLastnameDataGridViewTextBoxColumn
            // 
            this.contactLastnameDataGridViewTextBoxColumn.DataPropertyName = "Contact_Lastname";
            this.contactLastnameDataGridViewTextBoxColumn.HeaderText = "นามสกุล";
            this.contactLastnameDataGridViewTextBoxColumn.Name = "contactLastnameDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์ประสานงาน";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "Contact_Email";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "อีเมล์ประสานงาน";
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            // 
            // texDataGridViewTextBoxColumn
            // 
            this.texDataGridViewTextBoxColumn.DataPropertyName = "Tex";
            this.texDataGridViewTextBoxColumn.HeaderText = "เลขประจำตัวผู้เสียภาษี";
            this.texDataGridViewTextBoxColumn.Name = "texDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "อัตราภาษี";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "จำนวนเงินต้องชำระ";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address_1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "ที่อยู่ออกใบกำกับภาษี";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // township1DataGridViewTextBoxColumn
            // 
            this.township1DataGridViewTextBoxColumn.DataPropertyName = "Township_1";
            this.township1DataGridViewTextBoxColumn.HeaderText = "ตำบล / แขวง";
            this.township1DataGridViewTextBoxColumn.Name = "township1DataGridViewTextBoxColumn";
            // 
            // amphoe1DataGridViewTextBoxColumn
            // 
            this.amphoe1DataGridViewTextBoxColumn.DataPropertyName = "Amphoe_1";
            this.amphoe1DataGridViewTextBoxColumn.HeaderText = "อำเภอ / เขต";
            this.amphoe1DataGridViewTextBoxColumn.Name = "amphoe1DataGridViewTextBoxColumn";
            // 
            // province1DataGridViewTextBoxColumn
            // 
            this.province1DataGridViewTextBoxColumn.DataPropertyName = "Province_1";
            this.province1DataGridViewTextBoxColumn.HeaderText = "จังหวัด";
            this.province1DataGridViewTextBoxColumn.Name = "province1DataGridViewTextBoxColumn";
            // 
            // zipCode1DataGridViewTextBoxColumn
            // 
            this.zipCode1DataGridViewTextBoxColumn.DataPropertyName = "ZipCode_1";
            this.zipCode1DataGridViewTextBoxColumn.HeaderText = "รหัสไปรษณีย์";
            this.zipCode1DataGridViewTextBoxColumn.Name = "zipCode1DataGridViewTextBoxColumn";
            // 
            // addressSendDataGridViewTextBoxColumn
            // 
            this.addressSendDataGridViewTextBoxColumn.DataPropertyName = "AddressSend";
            this.addressSendDataGridViewTextBoxColumn.HeaderText = "ที่อยู่จัดส่งเอกสาร";
            this.addressSendDataGridViewTextBoxColumn.Name = "addressSendDataGridViewTextBoxColumn";
            // 
            // townshipSendDataGridViewTextBoxColumn
            // 
            this.townshipSendDataGridViewTextBoxColumn.DataPropertyName = "TownshipSend";
            this.townshipSendDataGridViewTextBoxColumn.HeaderText = "ตำบล / แขวง";
            this.townshipSendDataGridViewTextBoxColumn.Name = "townshipSendDataGridViewTextBoxColumn";
            // 
            // amphoeSendDataGridViewTextBoxColumn
            // 
            this.amphoeSendDataGridViewTextBoxColumn.DataPropertyName = "AmphoeSend";
            this.amphoeSendDataGridViewTextBoxColumn.HeaderText = "อำเภอ / เขต";
            this.amphoeSendDataGridViewTextBoxColumn.Name = "amphoeSendDataGridViewTextBoxColumn";
            // 
            // provinceSendDataGridViewTextBoxColumn
            // 
            this.provinceSendDataGridViewTextBoxColumn.DataPropertyName = "ProvinceSend";
            this.provinceSendDataGridViewTextBoxColumn.HeaderText = "จังหวัด";
            this.provinceSendDataGridViewTextBoxColumn.Name = "provinceSendDataGridViewTextBoxColumn";
            // 
            // zipCodeSendDataGridViewTextBoxColumn
            // 
            this.zipCodeSendDataGridViewTextBoxColumn.DataPropertyName = "ZipCodeSend";
            this.zipCodeSendDataGridViewTextBoxColumn.HeaderText = "รหัสไปรษณีย์";
            this.zipCodeSendDataGridViewTextBoxColumn.Name = "zipCodeSendDataGridViewTextBoxColumn";
            // 
            // billTypeNameDataGridViewTextBoxColumn
            // 
            this.billTypeNameDataGridViewTextBoxColumn.DataPropertyName = "BillType_Name";
            this.billTypeNameDataGridViewTextBoxColumn.HeaderText = "รูปแบบการออกใบกำกับภาษี";
            this.billTypeNameDataGridViewTextBoxColumn.Name = "billTypeNameDataGridViewTextBoxColumn";
            // 
            // lFirstnameDataGridViewTextBoxColumn
            // 
            this.lFirstnameDataGridViewTextBoxColumn.DataPropertyName = "l_Firstname";
            this.lFirstnameDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ดำเนินการสมัคร";
            this.lFirstnameDataGridViewTextBoxColumn.Name = "lFirstnameDataGridViewTextBoxColumn";
            // 
            // lLastnameDataGridViewTextBoxColumn
            // 
            this.lLastnameDataGridViewTextBoxColumn.DataPropertyName = "l_Lastname";
            this.lLastnameDataGridViewTextBoxColumn.HeaderText = "นามสกุล";
            this.lLastnameDataGridViewTextBoxColumn.Name = "lLastnameDataGridViewTextBoxColumn";
            // 
            // lEmailDataGridViewTextBoxColumn
            // 
            this.lEmailDataGridViewTextBoxColumn.DataPropertyName = "l_Email";
            this.lEmailDataGridViewTextBoxColumn.HeaderText = "อีเมล์ที่ใช้ในการสมัคร";
            this.lEmailDataGridViewTextBoxColumn.Name = "lEmailDataGridViewTextBoxColumn";
            // 
            // statusPayNameDataGridViewTextBoxColumn
            // 
            this.statusPayNameDataGridViewTextBoxColumn.DataPropertyName = "StatusPay_Name";
            this.statusPayNameDataGridViewTextBoxColumn.HeaderText = "สถานะ";
            this.statusPayNameDataGridViewTextBoxColumn.Name = "statusPayNameDataGridViewTextBoxColumn";
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "Bill_Id";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "Bill_Id";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(Project5_thfm2.Report);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 629);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblRegId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmMain";
            this.Text = "THFM Database Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRegId;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomDay1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomDay2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn texDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn township1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amphoe1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn province1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCode1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townshipSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amphoeSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportBindingSource;
    }
}

