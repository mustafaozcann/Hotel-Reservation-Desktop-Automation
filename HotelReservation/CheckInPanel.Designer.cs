
namespace HotelReservation
{
    partial class CheckInPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.checkInDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPortNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdentityNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNoCheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptCustomerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelReservation.HotelDBDataSet();
            this.btnAcceptCheckin = new HotelReservation.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSurname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnFindReserve = new HotelReservation.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTbTableAdapter = new HotelReservation.HotelDBDataSetTableAdapters.CustomerTbTableAdapter();
            this.pnlRooms.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRooms
            // 
            this.pnlRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlRooms.Controls.Add(this.panel2);
            this.pnlRooms.Controls.Add(this.panel1);
            this.pnlRooms.Controls.Add(this.label1);
            this.pnlRooms.Location = new System.Drawing.Point(-1, -29);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1146, 601);
            this.pnlRooms.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.checkInDataGridView);
            this.panel2.Controls.Add(this.btnAcceptCheckin);
            this.panel2.Location = new System.Drawing.Point(5, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 444);
            this.panel2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(382, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bugün Beklenen Misafirler";
            // 
            // checkInDataGridView
            // 
            this.checkInDataGridView.AllowUserToAddRows = false;
            this.checkInDataGridView.AllowUserToDeleteRows = false;
            this.checkInDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInDataGridView.AutoGenerateColumns = false;
            this.checkInDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkInDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.checkInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkInDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guest,
            this.surname,
            this.identityNo,
            this.passPortNo,
            this.nationality,
            this.mobilenumber,
            this.roomNo,
            this.checkOutDate,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ıdentityNoDataGridViewTextBoxColumn,
            this.passportNoCheckin,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.checkoutDateDataGridViewTextBoxColumn,
            this.acceptCustomerDataGridViewCheckBoxColumn});
            this.checkInDataGridView.DataSource = this.customerTbBindingSource;
            this.checkInDataGridView.HideOuterBorders = true;
            this.checkInDataGridView.Location = new System.Drawing.Point(3, 38);
            this.checkInDataGridView.Name = "checkInDataGridView";
            this.checkInDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.checkInDataGridView.ReadOnly = true;
            this.checkInDataGridView.RowHeadersVisible = false;
            this.checkInDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkInDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.checkInDataGridView.RowTemplate.Height = 40;
            this.checkInDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkInDataGridView.Size = new System.Drawing.Size(1109, 252);
            this.checkInDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.checkInDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.Gray;
            this.checkInDataGridView.StateCommon.Background.ColorAngle = 45F;
            this.checkInDataGridView.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.checkInDataGridView.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkInDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.checkInDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.checkInDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.checkInDataGridView.StateCommon.DataCell.Back.ColorAngle = 45F;
            this.checkInDataGridView.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkInDataGridView.StateCommon.DataCell.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkInDataGridView.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.checkInDataGridView.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Silver;
            this.checkInDataGridView.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkInDataGridView.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkInDataGridView.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkInDataGridView.StateCommon.DataCell.Border.Rounding = 20;
            this.checkInDataGridView.StateCommon.DataCell.Border.Width = 1;
            this.checkInDataGridView.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.checkInDataGridView.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.checkInDataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkInDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.checkInDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.checkInDataGridView.StateCommon.HeaderColumn.Back.ColorAngle = 90F;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Blue;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Gray;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.Rounding = 20;
            this.checkInDataGridView.StateCommon.HeaderColumn.Border.Width = 1;
            this.checkInDataGridView.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.checkInDataGridView.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Turquoise;
            this.checkInDataGridView.StateCommon.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkInDataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkInDataGridView.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(1);
            this.checkInDataGridView.TabIndex = 12;
            this.checkInDataGridView.TabStop = false;
            // 
            // guest
            // 
            this.guest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guest.DataPropertyName = "Name";
            this.guest.HeaderText = "Adı";
            this.guest.MaxInputLength = 20;
            this.guest.MinimumWidth = 50;
            this.guest.Name = "guest";
            this.guest.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname.DataPropertyName = "Surname";
            this.surname.HeaderText = "Soyadı";
            this.surname.MaxInputLength = 20;
            this.surname.MinimumWidth = 50;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // identityNo
            // 
            this.identityNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identityNo.DataPropertyName = "IdentityNo";
            this.identityNo.HeaderText = "TC No";
            this.identityNo.MaxInputLength = 11;
            this.identityNo.MinimumWidth = 100;
            this.identityNo.Name = "identityNo";
            this.identityNo.ReadOnly = true;
            // 
            // passPortNo
            // 
            this.passPortNo.DataPropertyName = "PassportNo";
            this.passPortNo.HeaderText = "PassportNo";
            this.passPortNo.MaxInputLength = 7;
            this.passPortNo.MinimumWidth = 100;
            this.passPortNo.Name = "passPortNo";
            this.passPortNo.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationality.DataPropertyName = "Nationality";
            this.nationality.HeaderText = "Uyruk";
            this.nationality.MinimumWidth = 100;
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // mobilenumber
            // 
            this.mobilenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobilenumber.DataPropertyName = "MobileNumber";
            this.mobilenumber.HeaderText = "Telefon Numarası";
            this.mobilenumber.MinimumWidth = 100;
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            // 
            // roomNo
            // 
            this.roomNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNo.DataPropertyName = "RoomNo";
            this.roomNo.HeaderText = "Oda No";
            this.roomNo.MinimumWidth = 50;
            this.roomNo.Name = "roomNo";
            this.roomNo.ReadOnly = true;
            // 
            // checkOutDate
            // 
            this.checkOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkOutDate.DataPropertyName = "CheckoutDate";
            this.checkOutDate.HeaderText = "CheckOutTarihi";
            this.checkOutDate.MinimumWidth = 100;
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıdentityNoDataGridViewTextBoxColumn
            // 
            this.ıdentityNoDataGridViewTextBoxColumn.DataPropertyName = "IdentityNo";
            this.ıdentityNoDataGridViewTextBoxColumn.HeaderText = "IdentityNo";
            this.ıdentityNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdentityNoDataGridViewTextBoxColumn.Name = "ıdentityNoDataGridViewTextBoxColumn";
            this.ıdentityNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdentityNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportNoCheckin
            // 
            this.passportNoCheckin.DataPropertyName = "PassportNo";
            this.passportNoCheckin.HeaderText = "PassportNo";
            this.passportNoCheckin.MinimumWidth = 6;
            this.passportNoCheckin.Name = "passportNoCheckin";
            this.passportNoCheckin.ReadOnly = true;
            this.passportNoCheckin.Visible = false;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalityDataGridViewTextBoxColumn.Visible = false;
            // 
            // checkoutDateDataGridViewTextBoxColumn
            // 
            this.checkoutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckoutDate";
            this.checkoutDateDataGridViewTextBoxColumn.HeaderText = "CheckoutDate";
            this.checkoutDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkoutDateDataGridViewTextBoxColumn.Name = "checkoutDateDataGridViewTextBoxColumn";
            this.checkoutDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkoutDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // acceptCustomerDataGridViewCheckBoxColumn
            // 
            this.acceptCustomerDataGridViewCheckBoxColumn.DataPropertyName = "AcceptCustomer";
            this.acceptCustomerDataGridViewCheckBoxColumn.HeaderText = "AcceptCustomer";
            this.acceptCustomerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.acceptCustomerDataGridViewCheckBoxColumn.Name = "acceptCustomerDataGridViewCheckBoxColumn";
            this.acceptCustomerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.acceptCustomerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // customerTbBindingSource
            // 
            this.customerTbBindingSource.DataMember = "CustomerTb";
            this.customerTbBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAcceptCheckin
            // 
            this.btnAcceptCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceptCheckin.BackColor = System.Drawing.Color.Gold;
            this.btnAcceptCheckin.BackGroundColor = System.Drawing.Color.Gold;
            this.btnAcceptCheckin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcceptCheckin.BorderRadius = 20;
            this.btnAcceptCheckin.BorderSize = 0;
            this.btnAcceptCheckin.FlatAppearance.BorderSize = 0;
            this.btnAcceptCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.btnAcceptCheckin.Location = new System.Drawing.Point(418, 329);
            this.btnAcceptCheckin.Name = "btnAcceptCheckin";
            this.btnAcceptCheckin.Size = new System.Drawing.Size(228, 38);
            this.btnAcceptCheckin.TabIndex = 11;
            this.btnAcceptCheckin.TabStop = false;
            this.btnAcceptCheckin.Text = "Check-in Yap";
            this.btnAcceptCheckin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.btnAcceptCheckin.UseVisualStyleBackColor = false;
            this.btnAcceptCheckin.Click += new System.EventHandler(this.btnAcceptCheckin_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.btnFindReserve);
            this.panel1.Location = new System.Drawing.Point(6, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 79);
            this.panel1.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.AlwaysActive = false;
            this.txtName.Location = new System.Drawing.Point(16, 11);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 55);
            this.txtName.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtName.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtName.StateActive.Border.ColorAngle = 48F;
            this.txtName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtName.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtName.StateCommon.Border.ColorAngle = 45F;
            this.txtName.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtName.StateCommon.Border.Rounding = 20;
            this.txtName.StateCommon.Border.Width = 1;
            this.txtName.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.TabIndex = 17;
            this.txtName.TabStop = false;
            this.txtName.Tag = "Adı";
            this.txtName.Text = "Adı";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.WordWrap = false;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.AlwaysActive = false;
            this.txtSurname.Location = new System.Drawing.Point(417, 11);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(324, 55);
            this.txtSurname.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtSurname.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtSurname.StateActive.Border.ColorAngle = 48F;
            this.txtSurname.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSurname.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtSurname.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtSurname.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtSurname.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtSurname.StateCommon.Border.ColorAngle = 45F;
            this.txtSurname.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtSurname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSurname.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSurname.StateCommon.Border.Rounding = 20;
            this.txtSurname.StateCommon.Border.Width = 1;
            this.txtSurname.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtSurname.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.TabIndex = 16;
            this.txtSurname.TabStop = false;
            this.txtSurname.Tag = "Soyadı";
            this.txtSurname.Text = "Soyadı";
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSurname.WordWrap = false;
            this.txtSurname.Enter += new System.EventHandler(this.txtSurname_Enter);
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // btnFindReserve
            // 
            this.btnFindReserve.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFindReserve.BackGroundColor = System.Drawing.Color.MediumBlue;
            this.btnFindReserve.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFindReserve.BorderRadius = 20;
            this.btnFindReserve.BorderSize = 0;
            this.btnFindReserve.FlatAppearance.BorderSize = 0;
            this.btnFindReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindReserve.ForeColor = System.Drawing.Color.OldLace;
            this.btnFindReserve.Location = new System.Drawing.Point(835, 11);
            this.btnFindReserve.Name = "btnFindReserve";
            this.btnFindReserve.Size = new System.Drawing.Size(228, 55);
            this.btnFindReserve.TabIndex = 4;
            this.btnFindReserve.TabStop = false;
            this.btnFindReserve.Text = "Rezervasyon Ara";
            this.btnFindReserve.TextColor = System.Drawing.Color.OldLace;
            this.btnFindReserve.UseVisualStyleBackColor = false;
            this.btnFindReserve.Click += new System.EventHandler(this.btnFindReserve_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "REZERVASYON ARA";
            // 
            // customerTbTableAdapter
            // 
            this.customerTbTableAdapter.ClearBeforeFill = true;
            // 
            // CheckInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 554);
            this.Controls.Add(this.pnlRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckInPanel";
            this.Text = "CheckInPanel";
            this.Load += new System.EventHandler(this.CheckInPanel_Load);
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel panel2;
        private CustomButton btnAcceptCheckin;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnFindReserve;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView checkInDataGridView;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSurname;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource customerTbBindingSource;
        private HotelDBDataSetTableAdapters.CustomerTbTableAdapter customerTbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPortNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdentityNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNoCheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptCustomerDataGridViewCheckBoxColumn;
    }
}