
using System;

namespace HotelReservation
{
    partial class ReservationPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allReservationDataSet = new HotelReservation.allReservationDataSet();
            this.customerTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTbTableAdapter = new HotelReservation.allReservationDataSetTableAdapters.CustomerTbTableAdapter();
            this.pnlGuestInfo = new HotelReservation.CustomPanel();
            this.allReservationDataGridview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nameReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityNoReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNoReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAllReservation = new HotelReservation.CustomButton();
            this.btnNewReservation = new HotelReservation.CustomButton();
            this.pnlAddGuest = new HotelReservation.CustomPanel();
            this.btnGuestCancel = new HotelReservation.CustomButton();
            this.btnAddGuest = new HotelReservation.CustomButton();
            this.txtGuestMobileNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtGuestIdentityOrPassport = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbGuestGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbGuestNationality = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtGuestSurnameReserve = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtGuestNameReserve = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.guest = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.surname = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.gender = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.identityNo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.nationality = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.roomNo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.btnGuestRemove = new FontAwesome.Sharp.IconButton();
            this.addGuest = new FontAwesome.Sharp.IconButton();
            this.btnGuestEdit = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlAddCustomer = new HotelReservation.CustomPanel();
            this.roomPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbCurrency = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAddReserve = new HotelReservation.CustomButton();
            this.cbRoomNo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnDateCheckOut = new FontAwesome.Sharp.IconButton();
            this.btnDateCheckIn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckOutReserve = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckinReserve = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtIdentityOrPassport = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbNationality = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtCustomerSurnameReserve = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerNameReserve = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTbBindingSource)).BeginInit();
            this.pnlGuestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationDataGridview)).BeginInit();
            this.pnlAddGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.pnlAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNationality)).BeginInit();
            this.SuspendLayout();
            // 
            // allReservationDataSet
            // 
            this.allReservationDataSet.DataSetName = "allReservationDataSet";
            this.allReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTbBindingSource
            // 
            this.customerTbBindingSource.DataMember = "CustomerTb";
            this.customerTbBindingSource.DataSource = this.allReservationDataSet;
            // 
            // customerTbTableAdapter
            // 
            this.customerTbTableAdapter.ClearBeforeFill = true;
            // 
            // pnlGuestInfo
            // 
            this.pnlGuestInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGuestInfo.AutoSize = true;
            this.pnlGuestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlGuestInfo.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlGuestInfo.BorderColor = System.Drawing.Color.Crimson;
            this.pnlGuestInfo.BorderRadius = 40;
            this.pnlGuestInfo.BorderSize = 7;
            this.pnlGuestInfo.Controls.Add(this.allReservationDataGridview);
            this.pnlGuestInfo.Controls.Add(this.btnShowAllReservation);
            this.pnlGuestInfo.Controls.Add(this.btnNewReservation);
            this.pnlGuestInfo.Controls.Add(this.pnlAddGuest);
            this.pnlGuestInfo.Controls.Add(this.kryptonDataGridView1);
            this.pnlGuestInfo.Controls.Add(this.btnGuestRemove);
            this.pnlGuestInfo.Controls.Add(this.addGuest);
            this.pnlGuestInfo.Controls.Add(this.btnGuestEdit);
            this.pnlGuestInfo.Controls.Add(this.label9);
            this.pnlGuestInfo.ForeColor = System.Drawing.Color.White;
            this.pnlGuestInfo.Location = new System.Drawing.Point(437, 6);
            this.pnlGuestInfo.Name = "pnlGuestInfo";
            this.pnlGuestInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlGuestInfo.Size = new System.Drawing.Size(24254, 45580);
            this.pnlGuestInfo.TabIndex = 2;
            this.pnlGuestInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGuestInfo_Paint);
            // 
            // allReservationDataGridview
            // 
            this.allReservationDataGridview.AllowUserToAddRows = false;
            this.allReservationDataGridview.AllowUserToDeleteRows = false;
            this.allReservationDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allReservationDataGridview.AutoGenerateColumns = false;
            this.allReservationDataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allReservationDataGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.allReservationDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allReservationDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameReserve,
            this.surnameReserve,
            this.IdentityNoReserve,
            this.passportNoReserve,
            this.mobileNumberReserve,
            this.roomNoReserve,
            this.nationalityReserve,
            this.genderReserve,
            this.currencyReserve,
            this.checkinDateReserve,
            this.checkoutDateReserve});
            this.allReservationDataGridview.DataSource = this.customerTbBindingSource;
            this.allReservationDataGridview.HideOuterBorders = true;
            this.allReservationDataGridview.Location = new System.Drawing.Point(13, 86);
            this.allReservationDataGridview.MinimumSize = new System.Drawing.Size(1300, 616);
            this.allReservationDataGridview.MultiSelect = false;
            this.allReservationDataGridview.Name = "allReservationDataGridview";
            this.allReservationDataGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.allReservationDataGridview.ReadOnly = true;
            this.allReservationDataGridview.RowHeadersVisible = false;
            this.allReservationDataGridview.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allReservationDataGridview.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allReservationDataGridview.RowTemplate.Height = 40;
            this.allReservationDataGridview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.allReservationDataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allReservationDataGridview.Size = new System.Drawing.Size(24100, 44984);
            this.allReservationDataGridview.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.allReservationDataGridview.StateCommon.Background.Color2 = System.Drawing.Color.Silver;
            this.allReservationDataGridview.StateCommon.Background.ColorAngle = 45F;
            this.allReservationDataGridview.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.allReservationDataGridview.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.allReservationDataGridview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.allReservationDataGridview.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.allReservationDataGridview.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.allReservationDataGridview.StateCommon.DataCell.Back.ColorAngle = 45F;
            this.allReservationDataGridview.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.allReservationDataGridview.StateCommon.DataCell.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.allReservationDataGridview.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.allReservationDataGridview.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Silver;
            this.allReservationDataGridview.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.allReservationDataGridview.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.allReservationDataGridview.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.allReservationDataGridview.StateCommon.DataCell.Border.Rounding = 20;
            this.allReservationDataGridview.StateCommon.DataCell.Border.Width = 1;
            this.allReservationDataGridview.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.allReservationDataGridview.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.allReservationDataGridview.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.allReservationDataGridview.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Back.ColorAngle = 90F;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Blue;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Gray;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.Rounding = 20;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Border.Width = 1;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Turquoise;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.allReservationDataGridview.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.allReservationDataGridview.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(1);
            this.allReservationDataGridview.TabIndex = 39;
            this.allReservationDataGridview.TabStop = false;
            this.allReservationDataGridview.VirtualMode = true;
            this.allReservationDataGridview.Visible = false;
            // 
            // nameReserve
            // 
            this.nameReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameReserve.DataPropertyName = "Name";
            this.nameReserve.HeaderText = "İsim";
            this.nameReserve.MinimumWidth = 6;
            this.nameReserve.Name = "nameReserve";
            this.nameReserve.ReadOnly = true;
            this.nameReserve.Width = 79;
            // 
            // surnameReserve
            // 
            this.surnameReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surnameReserve.DataPropertyName = "Surname";
            this.surnameReserve.HeaderText = "Soyisim";
            this.surnameReserve.MinimumWidth = 6;
            this.surnameReserve.Name = "surnameReserve";
            this.surnameReserve.ReadOnly = true;
            this.surnameReserve.Width = 110;
            // 
            // IdentityNoReserve
            // 
            this.IdentityNoReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdentityNoReserve.DataPropertyName = "IdentityNo";
            this.IdentityNoReserve.HeaderText = "TC No";
            this.IdentityNoReserve.MinimumWidth = 6;
            this.IdentityNoReserve.Name = "IdentityNoReserve";
            this.IdentityNoReserve.ReadOnly = true;
            this.IdentityNoReserve.Width = 87;
            // 
            // passportNoReserve
            // 
            this.passportNoReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passportNoReserve.DataPropertyName = "PassportNo";
            this.passportNoReserve.HeaderText = "Pasaport No";
            this.passportNoReserve.MinimumWidth = 6;
            this.passportNoReserve.Name = "passportNoReserve";
            this.passportNoReserve.ReadOnly = true;
            this.passportNoReserve.Width = 135;
            // 
            // mobileNumberReserve
            // 
            this.mobileNumberReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mobileNumberReserve.DataPropertyName = "MobileNumber";
            this.mobileNumberReserve.HeaderText = "Telefon Numarası";
            this.mobileNumberReserve.MinimumWidth = 6;
            this.mobileNumberReserve.Name = "mobileNumberReserve";
            this.mobileNumberReserve.ReadOnly = true;
            this.mobileNumberReserve.Width = 177;
            // 
            // roomNoReserve
            // 
            this.roomNoReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomNoReserve.DataPropertyName = "RoomNo";
            this.roomNoReserve.HeaderText = "Oda No";
            this.roomNoReserve.MinimumWidth = 6;
            this.roomNoReserve.Name = "roomNoReserve";
            this.roomNoReserve.ReadOnly = true;
            this.roomNoReserve.Width = 99;
            // 
            // nationalityReserve
            // 
            this.nationalityReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nationalityReserve.DataPropertyName = "Nationality";
            this.nationalityReserve.HeaderText = "Uyruk";
            this.nationalityReserve.MinimumWidth = 6;
            this.nationalityReserve.Name = "nationalityReserve";
            this.nationalityReserve.ReadOnly = true;
            this.nationalityReserve.Width = 91;
            // 
            // genderReserve
            // 
            this.genderReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderReserve.DataPropertyName = "Gender";
            this.genderReserve.HeaderText = "Cinsiyet";
            this.genderReserve.MinimumWidth = 6;
            this.genderReserve.Name = "genderReserve";
            this.genderReserve.ReadOnly = true;
            this.genderReserve.Width = 112;
            // 
            // currencyReserve
            // 
            this.currencyReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currencyReserve.DataPropertyName = "Currency";
            this.currencyReserve.HeaderText = "Döviz";
            this.currencyReserve.MinimumWidth = 6;
            this.currencyReserve.Name = "currencyReserve";
            this.currencyReserve.ReadOnly = true;
            this.currencyReserve.Width = 89;
            // 
            // checkinDateReserve
            // 
            this.checkinDateReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkinDateReserve.DataPropertyName = "CheckinDate";
            this.checkinDateReserve.HeaderText = "Check-in Tarihi";
            this.checkinDateReserve.MinimumWidth = 6;
            this.checkinDateReserve.Name = "checkinDateReserve";
            this.checkinDateReserve.ReadOnly = true;
            this.checkinDateReserve.Width = 157;
            // 
            // checkoutDateReserve
            // 
            this.checkoutDateReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkoutDateReserve.DataPropertyName = "CheckoutDate";
            this.checkoutDateReserve.HeaderText = "Check-out Tarihi";
            this.checkoutDateReserve.MinimumWidth = 6;
            this.checkoutDateReserve.Name = "checkoutDateReserve";
            this.checkoutDateReserve.ReadOnly = true;
            // 
            // btnShowAllReservation
            // 
            this.btnShowAllReservation.BackColor = System.Drawing.Color.Indigo;
            this.btnShowAllReservation.BackGroundColor = System.Drawing.Color.Indigo;
            this.btnShowAllReservation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShowAllReservation.BorderRadius = 20;
            this.btnShowAllReservation.BorderSize = 0;
            this.btnShowAllReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnShowAllReservation.FlatAppearance.BorderSize = 0;
            this.btnShowAllReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllReservation.ForeColor = System.Drawing.Color.OldLace;
            this.btnShowAllReservation.Location = new System.Drawing.Point(609, 15);
            this.btnShowAllReservation.Name = "btnShowAllReservation";
            this.btnShowAllReservation.Size = new System.Drawing.Size(209, 66);
            this.btnShowAllReservation.TabIndex = 38;
            this.btnShowAllReservation.TabStop = false;
            this.btnShowAllReservation.Text = "Tüm Rezervasyonlar Tablosunu Göster";
            this.btnShowAllReservation.TextColor = System.Drawing.Color.OldLace;
            this.btnShowAllReservation.UseVisualStyleBackColor = false;
            this.btnShowAllReservation.Click += new System.EventHandler(this.btnShowAllReservation_Click);
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.BackColor = System.Drawing.Color.MediumBlue;
            this.btnNewReservation.BackGroundColor = System.Drawing.Color.MediumBlue;
            this.btnNewReservation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewReservation.BorderRadius = 20;
            this.btnNewReservation.BorderSize = 0;
            this.btnNewReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnNewReservation.FlatAppearance.BorderSize = 0;
            this.btnNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReservation.ForeColor = System.Drawing.Color.OldLace;
            this.btnNewReservation.Location = new System.Drawing.Point(210, 16);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(209, 65);
            this.btnNewReservation.TabIndex = 37;
            this.btnNewReservation.TabStop = false;
            this.btnNewReservation.Text = "Yeni Rezervasyon";
            this.btnNewReservation.TextColor = System.Drawing.Color.OldLace;
            this.btnNewReservation.UseVisualStyleBackColor = false;
            this.btnNewReservation.Visible = false;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
            // 
            // pnlAddGuest
            // 
            this.pnlAddGuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAddGuest.AutoSize = true;
            this.pnlAddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlAddGuest.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlAddGuest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(107)))));
            this.pnlAddGuest.BorderRadius = 40;
            this.pnlAddGuest.BorderSize = 7;
            this.pnlAddGuest.Controls.Add(this.btnGuestCancel);
            this.pnlAddGuest.Controls.Add(this.btnAddGuest);
            this.pnlAddGuest.Controls.Add(this.txtGuestMobileNumber);
            this.pnlAddGuest.Controls.Add(this.txtGuestIdentityOrPassport);
            this.pnlAddGuest.Controls.Add(this.cbGuestGender);
            this.pnlAddGuest.Controls.Add(this.cbGuestNationality);
            this.pnlAddGuest.Controls.Add(this.txtGuestSurnameReserve);
            this.pnlAddGuest.Controls.Add(this.txtGuestNameReserve);
            this.pnlAddGuest.Controls.Add(this.label6);
            this.pnlAddGuest.ForeColor = System.Drawing.Color.White;
            this.pnlAddGuest.Location = new System.Drawing.Point(16, 324);
            this.pnlAddGuest.Name = "pnlAddGuest";
            this.pnlAddGuest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlAddGuest.Size = new System.Drawing.Size(482, 44902);
            this.pnlAddGuest.TabIndex = 17;
            this.pnlAddGuest.Visible = false;
            // 
            // btnGuestCancel
            // 
            this.btnGuestCancel.BackColor = System.Drawing.Color.DeepPink;
            this.btnGuestCancel.BackGroundColor = System.Drawing.Color.DeepPink;
            this.btnGuestCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuestCancel.BorderRadius = 20;
            this.btnGuestCancel.BorderSize = 0;
            this.btnGuestCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnGuestCancel.FlatAppearance.BorderSize = 0;
            this.btnGuestCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestCancel.ForeColor = System.Drawing.Color.OldLace;
            this.btnGuestCancel.Location = new System.Drawing.Point(246, 347);
            this.btnGuestCancel.Name = "btnGuestCancel";
            this.btnGuestCancel.Size = new System.Drawing.Size(209, 38);
            this.btnGuestCancel.TabIndex = 30;
            this.btnGuestCancel.TabStop = false;
            this.btnGuestCancel.Text = "İptal";
            this.btnGuestCancel.TextColor = System.Drawing.Color.OldLace;
            this.btnGuestCancel.UseVisualStyleBackColor = false;
            this.btnGuestCancel.Click += new System.EventHandler(this.btnGuestCancel_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAddGuest.BackGroundColor = System.Drawing.Color.MediumBlue;
            this.btnAddGuest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddGuest.BorderRadius = 20;
            this.btnAddGuest.BorderSize = 0;
            this.btnAddGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnAddGuest.FlatAppearance.BorderSize = 0;
            this.btnAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuest.ForeColor = System.Drawing.Color.OldLace;
            this.btnAddGuest.Location = new System.Drawing.Point(14, 347);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(226, 38);
            this.btnAddGuest.TabIndex = 29;
            this.btnAddGuest.TabStop = false;
            this.btnAddGuest.Text = "Misafir Ekle";
            this.btnAddGuest.TextColor = System.Drawing.Color.OldLace;
            this.btnAddGuest.UseVisualStyleBackColor = false;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // txtGuestMobileNumber
            // 
            this.txtGuestMobileNumber.AlwaysActive = false;
            this.txtGuestMobileNumber.Location = new System.Drawing.Point(15, 275);
            this.txtGuestMobileNumber.MaxLength = 11;
            this.txtGuestMobileNumber.Name = "txtGuestMobileNumber";
            this.txtGuestMobileNumber.ShortcutsEnabled = false;
            this.txtGuestMobileNumber.Size = new System.Drawing.Size(446, 55);
            this.txtGuestMobileNumber.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestMobileNumber.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestMobileNumber.StateActive.Border.ColorAngle = 48F;
            this.txtGuestMobileNumber.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestMobileNumber.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestMobileNumber.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestMobileNumber.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestMobileNumber.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestMobileNumber.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestMobileNumber.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestMobileNumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestMobileNumber.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestMobileNumber.StateCommon.Border.Rounding = 20;
            this.txtGuestMobileNumber.StateCommon.Border.Width = 1;
            this.txtGuestMobileNumber.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestMobileNumber.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestMobileNumber.TabIndex = 28;
            this.txtGuestMobileNumber.TabStop = false;
            this.txtGuestMobileNumber.Tag = "Telefon Numarası";
            this.txtGuestMobileNumber.Text = "Telefon Numarası";
            this.txtGuestMobileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestMobileNumber.WordWrap = false;
            this.txtGuestMobileNumber.Enter += new System.EventHandler(this.txtGuestMobileNumber_Enter);
            this.txtGuestMobileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextbox_KeyPress);
            this.txtGuestMobileNumber.Leave += new System.EventHandler(this.txtGuestMobileNumber_Leave);
            // 
            // txtGuestIdentityOrPassport
            // 
            this.txtGuestIdentityOrPassport.AlwaysActive = false;
            this.txtGuestIdentityOrPassport.Location = new System.Drawing.Point(15, 199);
            this.txtGuestIdentityOrPassport.MaxLength = 11;
            this.txtGuestIdentityOrPassport.Name = "txtGuestIdentityOrPassport";
            this.txtGuestIdentityOrPassport.ShortcutsEnabled = false;
            this.txtGuestIdentityOrPassport.Size = new System.Drawing.Size(446, 55);
            this.txtGuestIdentityOrPassport.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestIdentityOrPassport.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestIdentityOrPassport.StateActive.Border.ColorAngle = 48F;
            this.txtGuestIdentityOrPassport.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestIdentityOrPassport.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestIdentityOrPassport.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestIdentityOrPassport.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestIdentityOrPassport.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestIdentityOrPassport.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestIdentityOrPassport.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestIdentityOrPassport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestIdentityOrPassport.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestIdentityOrPassport.StateCommon.Border.Rounding = 20;
            this.txtGuestIdentityOrPassport.StateCommon.Border.Width = 1;
            this.txtGuestIdentityOrPassport.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestIdentityOrPassport.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestIdentityOrPassport.TabIndex = 27;
            this.txtGuestIdentityOrPassport.TabStop = false;
            this.txtGuestIdentityOrPassport.Tag = "TC Kimlik No";
            this.txtGuestIdentityOrPassport.Text = "TC Kimlik No";
            this.txtGuestIdentityOrPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestIdentityOrPassport.WordWrap = false;
            this.txtGuestIdentityOrPassport.Enter += new System.EventHandler(this.txtGuestIdentityOrPassport_Enter);
            this.txtGuestIdentityOrPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextbox_KeyPress);
            this.txtGuestIdentityOrPassport.Leave += new System.EventHandler(this.txtGuestIdentityOrPassport_Leave);
            // 
            // cbGuestGender
            // 
            this.cbGuestGender.AlwaysActive = false;
            this.cbGuestGender.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbGuestGender.DropDownWidth = 309;
            this.cbGuestGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cbGuestGender.Location = new System.Drawing.Point(246, 130);
            this.cbGuestGender.Name = "cbGuestGender";
            this.cbGuestGender.Size = new System.Drawing.Size(214, 43);
            this.cbGuestGender.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.cbGuestGender.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.OldLace;
            this.cbGuestGender.StateActive.ComboBox.Border.ColorAngle = 48F;
            this.cbGuestGender.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGuestGender.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.OldLace;
            this.cbGuestGender.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGuestGender.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbGuestGender.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbGuestGender.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cbGuestGender.StateCommon.ComboBox.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbGuestGender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGuestGender.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbGuestGender.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbGuestGender.StateCommon.ComboBox.Border.Width = 1;
            this.cbGuestGender.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbGuestGender.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGuestGender.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGuestGender.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGuestGender.StateCommon.DropBack.ColorAngle = 45F;
            this.cbGuestGender.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbGuestGender.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbGuestGender.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.cbGuestGender.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.cbGuestGender.StateCommon.Item.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.cbGuestGender.StateCommon.Item.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbGuestGender.StateCommon.Item.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbGuestGender.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbGuestGender.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbGuestGender.TabIndex = 25;
            this.cbGuestGender.TabStop = false;
            this.cbGuestGender.Tag = "Cinsiyet";
            this.cbGuestGender.Text = "Cinsiyet";
            this.cbGuestGender.DropDownClosed += new System.EventHandler(this.cbGuestGender_DropDownClosed);
            this.cbGuestGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNationality_KeyPress);
            // 
            // cbGuestNationality
            // 
            this.cbGuestNationality.AlwaysActive = false;
            this.cbGuestNationality.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbGuestNationality.DropDownWidth = 309;
            this.cbGuestNationality.Items.AddRange(new object[] {
            "Turkey",
            "United States Of America",
            "United Kingdom",
            "Germany",
            "İtaly",
            "French"});
            this.cbGuestNationality.Location = new System.Drawing.Point(14, 130);
            this.cbGuestNationality.Name = "cbGuestNationality";
            this.cbGuestNationality.Size = new System.Drawing.Size(206, 43);
            this.cbGuestNationality.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.cbGuestNationality.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.OldLace;
            this.cbGuestNationality.StateActive.ComboBox.Border.ColorAngle = 48F;
            this.cbGuestNationality.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGuestNationality.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.OldLace;
            this.cbGuestNationality.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGuestNationality.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbGuestNationality.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbGuestNationality.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cbGuestNationality.StateCommon.ComboBox.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbGuestNationality.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGuestNationality.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbGuestNationality.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbGuestNationality.StateCommon.ComboBox.Border.Width = 1;
            this.cbGuestNationality.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbGuestNationality.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGuestNationality.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGuestNationality.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGuestNationality.StateCommon.DropBack.ColorAngle = 45F;
            this.cbGuestNationality.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbGuestNationality.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbGuestNationality.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.cbGuestNationality.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.cbGuestNationality.StateCommon.Item.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.cbGuestNationality.StateCommon.Item.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbGuestNationality.StateCommon.Item.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbGuestNationality.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbGuestNationality.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbGuestNationality.TabIndex = 24;
            this.cbGuestNationality.TabStop = false;
            this.cbGuestNationality.Tag = "Uyruk";
            this.cbGuestNationality.Text = "Uyruk";
            this.cbGuestNationality.DropDownClosed += new System.EventHandler(this.cbGuestNationality_DropDownClosed);
            this.cbGuestNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNationality_KeyPress);
            this.cbGuestNationality.SelectedIndexChanged += new System.EventHandler(this.cbGuestNationality_SelectedIndexChanged);

            // 
            // txtGuestSurnameReserve
            // 
            this.txtGuestSurnameReserve.AlwaysActive = false;
            this.txtGuestSurnameReserve.Location = new System.Drawing.Point(246, 46);
            this.txtGuestSurnameReserve.MaxLength = 20;
            this.txtGuestSurnameReserve.Name = "txtGuestSurnameReserve";
            this.txtGuestSurnameReserve.Size = new System.Drawing.Size(214, 55);
            this.txtGuestSurnameReserve.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestSurnameReserve.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestSurnameReserve.StateActive.Border.ColorAngle = 48F;
            this.txtGuestSurnameReserve.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestSurnameReserve.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestSurnameReserve.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestSurnameReserve.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestSurnameReserve.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestSurnameReserve.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestSurnameReserve.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestSurnameReserve.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestSurnameReserve.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestSurnameReserve.StateCommon.Border.Rounding = 20;
            this.txtGuestSurnameReserve.StateCommon.Border.Width = 1;
            this.txtGuestSurnameReserve.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestSurnameReserve.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestSurnameReserve.TabIndex = 16;
            this.txtGuestSurnameReserve.TabStop = false;
            this.txtGuestSurnameReserve.Tag = "Soyadı";
            this.txtGuestSurnameReserve.Text = "Soyadı";
            this.txtGuestSurnameReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestSurnameReserve.WordWrap = false;
            
            this.txtGuestSurnameReserve.Enter += new System.EventHandler(this.txtGuestSurnameReserve_Enter);
            this.txtGuestSurnameReserve.Leave += new System.EventHandler(this.txtGuestSurnameReserve_Leave);
            // 
            // txtGuestNameReserve
            // 
            this.txtGuestNameReserve.AlwaysActive = false;
            this.txtGuestNameReserve.Location = new System.Drawing.Point(14, 46);
            this.txtGuestNameReserve.MaxLength = 20;
            this.txtGuestNameReserve.Name = "txtGuestNameReserve";
            this.txtGuestNameReserve.Size = new System.Drawing.Size(217, 55);
            this.txtGuestNameReserve.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestNameReserve.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestNameReserve.StateActive.Border.ColorAngle = 48F;
            this.txtGuestNameReserve.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestNameReserve.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestNameReserve.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestNameReserve.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestNameReserve.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestNameReserve.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestNameReserve.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestNameReserve.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestNameReserve.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestNameReserve.StateCommon.Border.Rounding = 20;
            this.txtGuestNameReserve.StateCommon.Border.Width = 1;
            this.txtGuestNameReserve.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestNameReserve.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestNameReserve.TabIndex = 14;
            this.txtGuestNameReserve.TabStop = false;
            this.txtGuestNameReserve.Tag = "Adı";
            this.txtGuestNameReserve.Text = "Adı";
            this.txtGuestNameReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestNameReserve.WordWrap = false;
            
            this.txtGuestNameReserve.Enter += new System.EventHandler(this.txtGuestNameReserve_Enter);
            this.txtGuestNameReserve.Leave += new System.EventHandler(this.txtGuestNameReserve_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(31, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Misafir Ekleme Kartı";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guest,
            this.surname,
            this.gender,
            this.identityNo,
            this.nationality,
            this.currency,
            this.mobilenumber,
            this.roomNo});
            this.kryptonDataGridView1.HideOuterBorders = true;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(13, 86);
            this.kryptonDataGridView1.MinimumSize = new System.Drawing.Size(900, 254);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kryptonDataGridView1.RowTemplate.Height = 40;
            this.kryptonDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(23930, 377);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.Silver;
            this.kryptonDataGridView1.StateCommon.Background.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonDataGridView1.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Silver;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Rounding = 20;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Width = 1;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.ColorAngle = 90F;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Rounding = 20;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Width = 1;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Turquoise;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonDataGridView1.TabIndex = 16;
            this.kryptonDataGridView1.TabStop = false;
            // 
            // guest
            // 
            this.guest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.guest.DataPropertyName = "GuestName";
            this.guest.DividerWidth = 1;
            this.guest.HeaderText = "Adı";
            this.guest.MinimumWidth = 30;
            this.guest.Name = "guest";
            this.guest.ReadOnly = true;
            this.guest.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.guest.Width = 71;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surname.DataPropertyName = "GuestSurname";
            this.surname.DividerWidth = 1;
            this.surname.HeaderText = "Soyadı";
            this.surname.MinimumWidth = 30;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.surname.Width = 102;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "GuestGender";
            this.gender.HeaderText = "Cinsiyet";
            this.gender.MinimumWidth = 20;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 112;
            // 
            // identityNo
            // 
            this.identityNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identityNo.DataPropertyName = "GuestIdentityNo";
            this.identityNo.HeaderText = "TC/Pasaport No";
            this.identityNo.MinimumWidth = 50;
            this.identityNo.Name = "identityNo";
            this.identityNo.ReadOnly = true;
            this.identityNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.identityNo.Width = 11679;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nationality.DataPropertyName = "GuestNationality";
            this.nationality.HeaderText = "Uyruk";
            this.nationality.MinimumWidth = 30;
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            this.nationality.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nationality.Width = 91;
            // 
            // currency
            // 
            this.currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currency.HeaderText = "Döviz";
            this.currency.MinimumWidth = 6;
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            this.currency.Width = 89;
            // 
            // mobilenumber
            // 
            this.mobilenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobilenumber.DataPropertyName = "GuestMobileNumber";
            this.mobilenumber.HeaderText = "Telefon Numarası";
            this.mobilenumber.MinimumWidth = 50;
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            this.mobilenumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mobilenumber.Width = 11678;
            // 
            // roomNo
            // 
            this.roomNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OldLace;
            this.roomNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomNo.HeaderText = "Oda No";
            this.roomNo.MinimumWidth = 10;
            this.roomNo.Name = "roomNo";
            this.roomNo.ReadOnly = true;
            this.roomNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomNo.Width = 107;
            // 
            // btnGuestRemove
            // 
            this.btnGuestRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnGuestRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnGuestRemove.FlatAppearance.BorderSize = 0;
            this.btnGuestRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnGuestRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnGuestRemove.IconColor = System.Drawing.Color.DarkRed;
            this.btnGuestRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuestRemove.IconSize = 24;
            this.btnGuestRemove.Location = new System.Drawing.Point(110, 49);
            this.btnGuestRemove.Name = "btnGuestRemove";
            this.btnGuestRemove.Size = new System.Drawing.Size(42, 31);
            this.btnGuestRemove.TabIndex = 15;
            this.btnGuestRemove.TabStop = false;
            this.btnGuestRemove.UseVisualStyleBackColor = false;
            this.btnGuestRemove.Click += new System.EventHandler(this.btnGuestRemove_Click);
            // 
            // addGuest
            // 
            this.addGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.addGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.addGuest.FlatAppearance.BorderSize = 0;
            this.addGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addGuest.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addGuest.IconColor = System.Drawing.Color.Silver;
            this.addGuest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addGuest.IconSize = 24;
            this.addGuest.Location = new System.Drawing.Point(16, 49);
            this.addGuest.Name = "addGuest";
            this.addGuest.Size = new System.Drawing.Size(40, 31);
            this.addGuest.TabIndex = 14;
            this.addGuest.TabStop = false;
            this.addGuest.UseVisualStyleBackColor = false;
            this.addGuest.Click += new System.EventHandler(this.addGuest_Click);
            // 
            // btnGuestEdit
            // 
            this.btnGuestEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnGuestEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnGuestEdit.FlatAppearance.BorderSize = 0;
            this.btnGuestEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnGuestEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuestEdit.IconColor = System.Drawing.Color.Silver;
            this.btnGuestEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuestEdit.IconSize = 24;
            this.btnGuestEdit.Location = new System.Drawing.Point(62, 49);
            this.btnGuestEdit.Name = "btnGuestEdit";
            this.btnGuestEdit.Size = new System.Drawing.Size(42, 31);
            this.btnGuestEdit.TabIndex = 13;
            this.btnGuestEdit.TabStop = false;
            this.btnGuestEdit.UseVisualStyleBackColor = false;
            this.btnGuestEdit.Click += new System.EventHandler(this.btnGuestEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label9.Location = new System.Drawing.Point(34, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Misafir Bilgileri";
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddCustomer.AutoSize = true;
            this.pnlAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlAddCustomer.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlAddCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(107)))));
            this.pnlAddCustomer.BorderRadius = 40;
            this.pnlAddCustomer.BorderSize = 7;
            this.pnlAddCustomer.Controls.Add(this.roomPrice);
            this.pnlAddCustomer.Controls.Add(this.cbCurrency);
            this.pnlAddCustomer.Controls.Add(this.btnAddReserve);
            this.pnlAddCustomer.Controls.Add(this.cbRoomNo);
            this.pnlAddCustomer.Controls.Add(this.btnDateCheckOut);
            this.pnlAddCustomer.Controls.Add(this.btnDateCheckIn);
            this.pnlAddCustomer.Controls.Add(this.label2);
            this.pnlAddCustomer.Controls.Add(this.txtCheckOutReserve);
            this.pnlAddCustomer.Controls.Add(this.label3);
            this.pnlAddCustomer.Controls.Add(this.txtCheckinReserve);
            this.pnlAddCustomer.Controls.Add(this.txtCustomerMobileNo);
            this.pnlAddCustomer.Controls.Add(this.txtIdentityOrPassport);
            this.pnlAddCustomer.Controls.Add(this.cbGender);
            this.pnlAddCustomer.Controls.Add(this.cbNationality);
            this.pnlAddCustomer.Controls.Add(this.txtCustomerSurnameReserve);
            this.pnlAddCustomer.Controls.Add(this.txtCustomerNameReserve);
            this.pnlAddCustomer.Controls.Add(this.label1);
            this.pnlAddCustomer.ForeColor = System.Drawing.Color.White;
            this.pnlAddCustomer.Location = new System.Drawing.Point(2, 3);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlAddCustomer.Size = new System.Drawing.Size(1082, 740);
            this.pnlAddCustomer.TabIndex = 1;
            // 
            // roomPrice
            // 
            this.roomPrice.AlwaysActive = false;
            this.roomPrice.Enabled = false;
            this.roomPrice.Location = new System.Drawing.Point(16, 582);
            this.roomPrice.MaxLength = 20;
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.ReadOnly = true;
            this.roomPrice.Size = new System.Drawing.Size(411, 55);
            this.roomPrice.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.roomPrice.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.roomPrice.StateActive.Border.ColorAngle = 48F;
            this.roomPrice.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomPrice.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.roomPrice.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.roomPrice.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.roomPrice.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.roomPrice.StateCommon.Border.ColorAngle = 45F;
            this.roomPrice.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.roomPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.roomPrice.StateCommon.Border.Rounding = 20;
            this.roomPrice.StateCommon.Border.Width = 1;
            this.roomPrice.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.roomPrice.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomPrice.TabIndex = 38;
            this.roomPrice.TabStop = false;
            this.roomPrice.Tag = "Oda Günlük Ücreti";
            this.roomPrice.Text = "Oda Günlük Ücreti: 100 TRY";
            this.roomPrice.WordWrap = false;
            // 
            // cbCurrency
            // 
            this.cbCurrency.AlwaysActive = false;
            this.cbCurrency.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbCurrency.DropDownWidth = 309;
            this.cbCurrency.Items.AddRange(new object[] {
            "₺TRY",
            "$USD",
            "€EURO"});
            this.cbCurrency.Location = new System.Drawing.Point(16, 520);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(411, 43);
            this.cbCurrency.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.cbCurrency.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.OldLace;
            this.cbCurrency.StateActive.ComboBox.Border.ColorAngle = 48F;
            this.cbCurrency.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCurrency.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.OldLace;
            this.cbCurrency.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbCurrency.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbCurrency.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbCurrency.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cbCurrency.StateCommon.ComboBox.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbCurrency.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCurrency.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbCurrency.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbCurrency.StateCommon.ComboBox.Border.Width = 1;
            this.cbCurrency.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbCurrency.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCurrency.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbCurrency.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbCurrency.StateCommon.DropBack.ColorAngle = 45F;
            this.cbCurrency.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbCurrency.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbCurrency.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.cbCurrency.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.cbCurrency.StateCommon.Item.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.cbCurrency.StateCommon.Item.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbCurrency.StateCommon.Item.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbCurrency.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbCurrency.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbCurrency.TabIndex = 37;
            this.cbCurrency.TabStop = false;
            this.cbCurrency.Tag = "Döviz";
            this.cbCurrency.Text = "Döviz";
            this.cbCurrency.DropDownClosed += new System.EventHandler(this.cbCurrency_DropDownClosed);
            this.cbCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNationality_KeyPress);
            // 
            // btnAddReserve
            // 
            this.btnAddReserve.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAddReserve.BackGroundColor = System.Drawing.Color.MediumBlue;
            this.btnAddReserve.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddReserve.BorderRadius = 20;
            this.btnAddReserve.BorderSize = 0;
            this.btnAddReserve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnAddReserve.FlatAppearance.BorderSize = 0;
            this.btnAddReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReserve.ForeColor = System.Drawing.Color.OldLace;
            this.btnAddReserve.Location = new System.Drawing.Point(118, 661);
            this.btnAddReserve.Name = "btnAddReserve";
            this.btnAddReserve.Size = new System.Drawing.Size(209, 38);
            this.btnAddReserve.TabIndex = 36;
            this.btnAddReserve.TabStop = false;
            this.btnAddReserve.Text = "Rezervasyon Yap";
            this.btnAddReserve.TextColor = System.Drawing.Color.OldLace;
            this.btnAddReserve.UseVisualStyleBackColor = false;
            this.btnAddReserve.Click += new System.EventHandler(this.btnAddReserve_Click);
            // 
            // cbRoomNo
            // 
            this.cbRoomNo.AlwaysActive = false;
            this.cbRoomNo.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbRoomNo.DropDownWidth = 309;
            this.cbRoomNo.Location = new System.Drawing.Point(16, 458);
            this.cbRoomNo.Name = "cbRoomNo";
            this.cbRoomNo.Size = new System.Drawing.Size(411, 43);
            this.cbRoomNo.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.cbRoomNo.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.OldLace;
            this.cbRoomNo.StateActive.ComboBox.Border.ColorAngle = 48F;
            this.cbRoomNo.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbRoomNo.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.OldLace;
            this.cbRoomNo.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbRoomNo.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbRoomNo.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbRoomNo.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cbRoomNo.StateCommon.ComboBox.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbRoomNo.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbRoomNo.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbRoomNo.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbRoomNo.StateCommon.ComboBox.Border.Width = 1;
            this.cbRoomNo.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbRoomNo.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRoomNo.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbRoomNo.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbRoomNo.StateCommon.DropBack.ColorAngle = 45F;
            this.cbRoomNo.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbRoomNo.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbRoomNo.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.cbRoomNo.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.cbRoomNo.StateCommon.Item.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.cbRoomNo.StateCommon.Item.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbRoomNo.StateCommon.Item.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbRoomNo.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbRoomNo.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbRoomNo.TabIndex = 35;
            this.cbRoomNo.TabStop = false;
            this.cbRoomNo.Tag = "Oda No";
            this.cbRoomNo.Text = "Oda No";
            this.cbRoomNo.DropDownClosed += new System.EventHandler(this.cbRoomNo_DropDownClosed);
            this.cbRoomNo.SelectedIndexChanged += new System.EventHandler(this.cbRoomNo_SelectedIndexChanged);
            this.cbRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNationality_KeyPress);
            // 
            // btnDateCheckOut
            // 
            this.btnDateCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnDateCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnDateCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDateCheckOut.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnDateCheckOut.IconColor = System.Drawing.Color.Silver;
            this.btnDateCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDateCheckOut.IconSize = 24;
            this.btnDateCheckOut.Location = new System.Drawing.Point(389, 383);
            this.btnDateCheckOut.Name = "btnDateCheckOut";
            this.btnDateCheckOut.Size = new System.Drawing.Size(40, 51);
            this.btnDateCheckOut.TabIndex = 34;
            this.btnDateCheckOut.TabStop = false;
            this.btnDateCheckOut.UseVisualStyleBackColor = false;
            this.btnDateCheckOut.Visible = false;
            this.btnDateCheckOut.Click += new System.EventHandler(this.btnDateCheckOut_Click);
            // 
            // btnDateCheckIn
            // 
            this.btnDateCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnDateCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnDateCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDateCheckIn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnDateCheckIn.IconColor = System.Drawing.Color.Silver;
            this.btnDateCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDateCheckIn.IconSize = 24;
            this.btnDateCheckIn.Location = new System.Drawing.Point(172, 387);
            this.btnDateCheckIn.Name = "btnDateCheckIn";
            this.btnDateCheckIn.Size = new System.Drawing.Size(40, 51);
            this.btnDateCheckIn.TabIndex = 33;
            this.btnDateCheckIn.TabStop = false;
            this.btnDateCheckIn.UseVisualStyleBackColor = false;
            this.btnDateCheckIn.Click += new System.EventHandler(this.btnDateCheckIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(229, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Check-out Tarihi";
            // 
            // txtCheckOutReserve
            // 
            this.txtCheckOutReserve.AlwaysActive = false;
            this.txtCheckOutReserve.Enabled = false;
            this.txtCheckOutReserve.Location = new System.Drawing.Point(228, 383);
            this.txtCheckOutReserve.MaxLength = 20;
            this.txtCheckOutReserve.Name = "txtCheckOutReserve";
            this.txtCheckOutReserve.ReadOnly = true;
            this.txtCheckOutReserve.Size = new System.Drawing.Size(153, 55);
            this.txtCheckOutReserve.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtCheckOutReserve.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtCheckOutReserve.StateActive.Border.ColorAngle = 48F;
            this.txtCheckOutReserve.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCheckOutReserve.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtCheckOutReserve.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCheckOutReserve.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCheckOutReserve.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtCheckOutReserve.StateCommon.Border.ColorAngle = 45F;
            this.txtCheckOutReserve.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCheckOutReserve.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCheckOutReserve.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCheckOutReserve.StateCommon.Border.Rounding = 20;
            this.txtCheckOutReserve.StateCommon.Border.Width = 1;
            this.txtCheckOutReserve.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCheckOutReserve.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckOutReserve.TabIndex = 31;
            this.txtCheckOutReserve.TabStop = false;
            this.txtCheckOutReserve.Tag = "";
            this.txtCheckOutReserve.Text = "21/12/2021";
            this.txtCheckOutReserve.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(13, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Check-in Tarihi";
            // 
            // txtCheckinReserve
            // 
            this.txtCheckinReserve.AlwaysActive = false;
            this.txtCheckinReserve.Enabled = false;
            this.txtCheckinReserve.Location = new System.Drawing.Point(13, 383);
            this.txtCheckinReserve.MaxLength = 20;
            this.txtCheckinReserve.Name = "txtCheckinReserve";
            this.txtCheckinReserve.ReadOnly = true;
            this.txtCheckinReserve.Size = new System.Drawing.Size(153, 55);
            this.txtCheckinReserve.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtCheckinReserve.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtCheckinReserve.StateActive.Border.ColorAngle = 48F;
            this.txtCheckinReserve.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCheckinReserve.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtCheckinReserve.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCheckinReserve.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCheckinReserve.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtCheckinReserve.StateCommon.Border.ColorAngle = 45F;
            this.txtCheckinReserve.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCheckinReserve.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCheckinReserve.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCheckinReserve.StateCommon.Border.Rounding = 20;
            this.txtCheckinReserve.StateCommon.Border.Width = 1;
            this.txtCheckinReserve.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCheckinReserve.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckinReserve.TabIndex = 29;
            this.txtCheckinReserve.TabStop = false;
            this.txtCheckinReserve.Tag = "";
            this.txtCheckinReserve.Text = "21/12/2021";
            this.txtCheckinReserve.WordWrap = false;
            this.txtCheckinReserve.TextChanged += new System.EventHandler(this.txtCheckinReserve_TextChanged);
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.AlwaysActive = false;
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(15, 290);
            this.txtCustomerMobileNo.MaxLength = 11;
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.ShortcutsEnabled = false;
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(416, 55);
            this.txtCustomerMobileNo.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtCustomerMobileNo.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtCustomerMobileNo.StateActive.Border.ColorAngle = 48F;
            this.txtCustomerMobileNo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerMobileNo.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtCustomerMobileNo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCustomerMobileNo.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCustomerMobileNo.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtCustomerMobileNo.StateCommon.Border.ColorAngle = 45F;
            this.txtCustomerMobileNo.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCustomerMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerMobileNo.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCustomerMobileNo.StateCommon.Border.Rounding = 20;
            this.txtCustomerMobileNo.StateCommon.Border.Width = 1;
            this.txtCustomerMobileNo.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCustomerMobileNo.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerMobileNo.TabIndex = 28;
            this.txtCustomerMobileNo.TabStop = false;
            this.txtCustomerMobileNo.Tag = "Telefon Numarası";
            this.txtCustomerMobileNo.Text = "Telefon Numarası";
            this.txtCustomerMobileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerMobileNo.WordWrap = false;
            this.txtCustomerMobileNo.Enter += new System.EventHandler(this.txtCustomerMobileNo_Enter);
            this.txtCustomerMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextbox_KeyPress);
            this.txtCustomerMobileNo.Leave += new System.EventHandler(this.txtCustomerMobileNo_Leave);
            // 
            // txtIdentityOrPassport
            // 
            this.txtIdentityOrPassport.AlwaysActive = false;
            this.txtIdentityOrPassport.Location = new System.Drawing.Point(15, 208);
            this.txtIdentityOrPassport.MaxLength = 11;
            this.txtIdentityOrPassport.Name = "txtIdentityOrPassport";
            this.txtIdentityOrPassport.ShortcutsEnabled = false;
            this.txtIdentityOrPassport.Size = new System.Drawing.Size(416, 55);
            this.txtIdentityOrPassport.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtIdentityOrPassport.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtIdentityOrPassport.StateActive.Border.ColorAngle = 48F;
            this.txtIdentityOrPassport.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIdentityOrPassport.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtIdentityOrPassport.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtIdentityOrPassport.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtIdentityOrPassport.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtIdentityOrPassport.StateCommon.Border.ColorAngle = 45F;
            this.txtIdentityOrPassport.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtIdentityOrPassport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIdentityOrPassport.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtIdentityOrPassport.StateCommon.Border.Rounding = 20;
            this.txtIdentityOrPassport.StateCommon.Border.Width = 1;
            this.txtIdentityOrPassport.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtIdentityOrPassport.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIdentityOrPassport.TabIndex = 27;
            this.txtIdentityOrPassport.TabStop = false;
            this.txtIdentityOrPassport.Tag = "TC Kimlik No";
            this.txtIdentityOrPassport.Text = "TC Kimlik No";
            this.txtIdentityOrPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentityOrPassport.WordWrap = false;
            this.txtIdentityOrPassport.Enter += new System.EventHandler(this.txtIdentityOrPassport_Enter);
            this.txtIdentityOrPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextbox_KeyPress);
            this.txtIdentityOrPassport.Leave += new System.EventHandler(this.txtIdentityOrPassport_Leave);
            // 
            // cbGender
            // 
            this.cbGender.AlwaysActive = false;
            this.cbGender.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbGender.DropDownWidth = 309;
            this.cbGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cbGender.Location = new System.Drawing.Point(225, 140);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(206, 43);
            this.cbGender.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.cbGender.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.OldLace;
            this.cbGender.StateActive.ComboBox.Border.ColorAngle = 48F;
            this.cbGender.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGender.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.OldLace;
            this.cbGender.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGender.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbGender.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbGender.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cbGender.StateCommon.ComboBox.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbGender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbGender.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbGender.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbGender.StateCommon.ComboBox.Border.Width = 1;
            this.cbGender.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbGender.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGender.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGender.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbGender.StateCommon.DropBack.ColorAngle = 45F;
            this.cbGender.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbGender.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbGender.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.cbGender.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.cbGender.StateCommon.Item.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.cbGender.StateCommon.Item.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbGender.StateCommon.Item.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbGender.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbGender.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbGender.TabIndex = 25;
            this.cbGender.TabStop = false;
            this.cbGender.Tag = "Cinsiyet";
            this.cbGender.Text = "Cinsiyet";
            this.cbGender.DropDownClosed += new System.EventHandler(this.cbGender_DropDownClosed);
            this.cbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNationality_KeyPress);
            // 
            // cbNationality
            // 
            this.cbNationality.AlwaysActive = false;
            this.cbNationality.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbNationality.DropDownWidth = 309;
            this.cbNationality.Items.AddRange(new object[] {
            "Turkey",
            "United States Of America",
            "United Kingdom",
            "Germany",
            "İtaly",
            "French"});
            this.cbNationality.Location = new System.Drawing.Point(13, 140);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(206, 43);
            this.cbNationality.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.cbNationality.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.OldLace;
            this.cbNationality.StateActive.ComboBox.Border.ColorAngle = 48F;
            this.cbNationality.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbNationality.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.OldLace;
            this.cbNationality.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbNationality.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbNationality.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbNationality.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cbNationality.StateCommon.ComboBox.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbNationality.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbNationality.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbNationality.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbNationality.StateCommon.ComboBox.Border.Width = 1;
            this.cbNationality.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbNationality.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbNationality.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbNationality.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbNationality.StateCommon.DropBack.ColorAngle = 45F;
            this.cbNationality.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.cbNationality.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbNationality.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.cbNationality.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.cbNationality.StateCommon.Item.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.cbNationality.StateCommon.Item.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbNationality.StateCommon.Item.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbNationality.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbNationality.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbNationality.TabIndex = 24;
            this.cbNationality.TabStop = false;
            this.cbNationality.Tag = "Uyruk";
            this.cbNationality.Text = "Uyruk";
            this.cbNationality.DropDownClosed += new System.EventHandler(this.cbNationality_DropDownClosed);
            this.cbNationality.SelectedIndexChanged += new System.EventHandler(this.cbNationality_SelectedIndexChanged);
            this.cbNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNationality_KeyPress);
            // 
            // txtCustomerSurnameReserve
            // 
            this.txtCustomerSurnameReserve.AlwaysActive = false;
            this.txtCustomerSurnameReserve.Location = new System.Drawing.Point(223, 57);
            this.txtCustomerSurnameReserve.MaxLength = 20;
            this.txtCustomerSurnameReserve.Name = "txtCustomerSurnameReserve";
            this.txtCustomerSurnameReserve.Size = new System.Drawing.Size(206, 55);
            this.txtCustomerSurnameReserve.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtCustomerSurnameReserve.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtCustomerSurnameReserve.StateActive.Border.ColorAngle = 48F;
            this.txtCustomerSurnameReserve.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerSurnameReserve.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtCustomerSurnameReserve.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCustomerSurnameReserve.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCustomerSurnameReserve.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtCustomerSurnameReserve.StateCommon.Border.ColorAngle = 45F;
            this.txtCustomerSurnameReserve.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCustomerSurnameReserve.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerSurnameReserve.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCustomerSurnameReserve.StateCommon.Border.Rounding = 20;
            this.txtCustomerSurnameReserve.StateCommon.Border.Width = 1;
            this.txtCustomerSurnameReserve.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCustomerSurnameReserve.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerSurnameReserve.TabIndex = 16;
            this.txtCustomerSurnameReserve.TabStop = false;
            this.txtCustomerSurnameReserve.Tag = "Soyadı";
            this.txtCustomerSurnameReserve.Text = "Soyadı";
            this.txtCustomerSurnameReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerSurnameReserve.WordWrap = false;
            
            this.txtCustomerSurnameReserve.Enter += new System.EventHandler(this.txtCustomerSurnameReserve_Enter);
            this.txtCustomerSurnameReserve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameSurnameTextbox_KeyPress);
            this.txtCustomerSurnameReserve.Leave += new System.EventHandler(this.txtCustomerSurnameReserve_Leave);
            // 
            // txtCustomerNameReserve
            // 
            this.txtCustomerNameReserve.AlwaysActive = false;
            this.txtCustomerNameReserve.Location = new System.Drawing.Point(13, 57);
            this.txtCustomerNameReserve.MaxLength = 20;
            this.txtCustomerNameReserve.Name = "txtCustomerNameReserve";
            this.txtCustomerNameReserve.Size = new System.Drawing.Size(206, 55);
            this.txtCustomerNameReserve.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtCustomerNameReserve.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtCustomerNameReserve.StateActive.Border.ColorAngle = 48F;
            this.txtCustomerNameReserve.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerNameReserve.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtCustomerNameReserve.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCustomerNameReserve.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCustomerNameReserve.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtCustomerNameReserve.StateCommon.Border.ColorAngle = 45F;
            this.txtCustomerNameReserve.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCustomerNameReserve.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerNameReserve.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCustomerNameReserve.StateCommon.Border.Rounding = 20;
            this.txtCustomerNameReserve.StateCommon.Border.Width = 1;
            this.txtCustomerNameReserve.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtCustomerNameReserve.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerNameReserve.TabIndex = 14;
            this.txtCustomerNameReserve.TabStop = false;
            this.txtCustomerNameReserve.Tag = "Adı";
            this.txtCustomerNameReserve.Text = "Adı";
            this.txtCustomerNameReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            this.txtCustomerNameReserve.Enter += new System.EventHandler(this.txtCustomerNameReserve_Enter);
            this.txtCustomerNameReserve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameSurnameTextbox_KeyPress);
            this.txtCustomerNameReserve.Leave += new System.EventHandler(this.txtCustomerNameReserve_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervasyon Kartı";
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1482, 714);
            this.Controls.Add(this.pnlGuestInfo);
            this.Controls.Add(this.pnlAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReservationPnl";
            this.Load += new System.EventHandler(this.ReservationPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTbBindingSource)).EndInit();
            this.pnlGuestInfo.ResumeLayout(false);
            this.pnlGuestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationDataGridview)).EndInit();
            this.pnlAddGuest.ResumeLayout(false);
            this.pnlAddGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNationality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private CustomPanel pnlAddCustomer;
        private CustomPanel pnlGuestInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerNameReserve;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerSurnameReserve;
      
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNationality;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbGender;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIdentityOrPassport;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCheckinReserve;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCheckOutReserve;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDateCheckOut;
        private FontAwesome.Sharp.IconButton btnDateCheckIn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbRoomNo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCurrency;
        private CustomButton btnAddReserve;
        private FontAwesome.Sharp.IconButton btnGuestRemove;
        private FontAwesome.Sharp.IconButton addGuest;
        private FontAwesome.Sharp.IconButton btnGuestEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private CustomPanel pnlAddGuest;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestMobileNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestIdentityOrPassport;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbGuestGender;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbGuestNationality;
       
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestSurnameReserve;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestNameReserve;
        private System.Windows.Forms.Label label6;
        private CustomButton btnAddGuest;
        private CustomButton btnGuestCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomPrice;
        private CustomButton btnNewReservation;
        private CustomButton btnShowAllReservation;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView allReservationDataGridview;
        private allReservationDataSet allReservationDataSet;
        private System.Windows.Forms.BindingSource customerTbBindingSource;
        private allReservationDataSetTableAdapters.CustomerTbTableAdapter customerTbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNoReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNoReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateReserve;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn guest;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn surname;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gender;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn identityNo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn mobilenumber;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn roomNo;
    }
}