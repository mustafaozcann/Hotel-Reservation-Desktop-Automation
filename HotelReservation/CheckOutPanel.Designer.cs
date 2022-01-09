
namespace HotelReservation
{
    partial class CheckOutPanel
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
            this.btnAcceptCheckout = new HotelReservation.CustomButton();
            this.checkOutDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPortNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelReservation.HotelDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindGuest = new HotelReservation.CustomButton();
            this.findGuestSurNameOut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.findGuestNameOut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTbTableAdapter = new HotelReservation.HotelDBDataSetTableAdapters.CustomerTbTableAdapter();
            this.pnlRooms.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutDataGridView)).BeginInit();
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
            this.pnlRooms.Location = new System.Drawing.Point(-9, -33);
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
            this.panel2.Controls.Add(this.btnAcceptCheckout);
            this.panel2.Controls.Add(this.checkOutDataGridView);
            this.panel2.Location = new System.Drawing.Point(14, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 444);
            this.panel2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(409, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bugün Ayrılacak Misafirler";
            // 
            // btnAcceptCheckout
            // 
            this.btnAcceptCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceptCheckout.BackColor = System.Drawing.Color.Gold;
            this.btnAcceptCheckout.BackGroundColor = System.Drawing.Color.Gold;
            this.btnAcceptCheckout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcceptCheckout.BorderRadius = 20;
            this.btnAcceptCheckout.BorderSize = 0;
            this.btnAcceptCheckout.FlatAppearance.BorderSize = 0;
            this.btnAcceptCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.btnAcceptCheckout.Location = new System.Drawing.Point(424, 365);
            this.btnAcceptCheckout.Name = "btnAcceptCheckout";
            this.btnAcceptCheckout.Size = new System.Drawing.Size(228, 38);
            this.btnAcceptCheckout.TabIndex = 14;
            this.btnAcceptCheckout.TabStop = false;
            this.btnAcceptCheckout.Text = "Check-Out Yap";
            this.btnAcceptCheckout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.btnAcceptCheckout.UseVisualStyleBackColor = false;
            this.btnAcceptCheckout.Click += new System.EventHandler(this.btnAcceptCheckout_Click);
            // 
            // checkOutDataGridView
            // 
            this.checkOutDataGridView.AllowUserToAddRows = false;
            this.checkOutDataGridView.AllowUserToDeleteRows = false;
            this.checkOutDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkOutDataGridView.AutoGenerateColumns = false;
            this.checkOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkOutDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.checkOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guest,
            this.surname,
            this.identityNo,
            this.passPortNo,
            this.mobilenumber,
            this.roomNo,
            this.nationality,
            this.checkOutDate});
            this.checkOutDataGridView.DataSource = this.customerTbBindingSource;
            this.checkOutDataGridView.HideOuterBorders = true;
            this.checkOutDataGridView.Location = new System.Drawing.Point(0, 35);
            this.checkOutDataGridView.Name = "checkOutDataGridView";
            this.checkOutDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.checkOutDataGridView.ReadOnly = true;
            this.checkOutDataGridView.RowHeadersVisible = false;
            this.checkOutDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkOutDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.checkOutDataGridView.RowTemplate.Height = 40;
            this.checkOutDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkOutDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkOutDataGridView.Size = new System.Drawing.Size(1109, 252);
            this.checkOutDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.checkOutDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.Gray;
            this.checkOutDataGridView.StateCommon.Background.ColorAngle = 45F;
            this.checkOutDataGridView.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.checkOutDataGridView.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkOutDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.checkOutDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.checkOutDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.checkOutDataGridView.StateCommon.DataCell.Back.ColorAngle = 45F;
            this.checkOutDataGridView.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkOutDataGridView.StateCommon.DataCell.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkOutDataGridView.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.checkOutDataGridView.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Silver;
            this.checkOutDataGridView.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkOutDataGridView.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkOutDataGridView.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkOutDataGridView.StateCommon.DataCell.Border.Rounding = 20;
            this.checkOutDataGridView.StateCommon.DataCell.Border.Width = 1;
            this.checkOutDataGridView.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.checkOutDataGridView.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.checkOutDataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkOutDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Back.ColorAngle = 90F;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Blue;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Gray;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.Rounding = 20;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Border.Width = 1;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Turquoise;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.checkOutDataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkOutDataGridView.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(1);
            this.checkOutDataGridView.TabIndex = 13;
            this.checkOutDataGridView.TabStop = false;
            // 
            // guest
            // 
            this.guest.DataPropertyName = "Name";
            this.guest.HeaderText = "Adı";
            this.guest.MinimumWidth = 6;
            this.guest.Name = "guest";
            this.guest.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "Surname";
            this.surname.HeaderText = "Soyadı";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // identityNo
            // 
            this.identityNo.DataPropertyName = "IdentityNo";
            this.identityNo.HeaderText = "TC No";
            this.identityNo.MinimumWidth = 6;
            this.identityNo.Name = "identityNo";
            this.identityNo.ReadOnly = true;
            // 
            // passPortNo
            // 
            this.passPortNo.DataPropertyName = "PassportNo";
            this.passPortNo.HeaderText = "PassportNo";
            this.passPortNo.MinimumWidth = 6;
            this.passPortNo.Name = "passPortNo";
            this.passPortNo.ReadOnly = true;
            // 
            // mobilenumber
            // 
            this.mobilenumber.DataPropertyName = "MobileNumber";
            this.mobilenumber.HeaderText = "Telefon Numarası";
            this.mobilenumber.MinimumWidth = 6;
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            // 
            // roomNo
            // 
            this.roomNo.DataPropertyName = "RoomNo";
            this.roomNo.HeaderText = "Oda No";
            this.roomNo.MinimumWidth = 6;
            this.roomNo.Name = "roomNo";
            this.roomNo.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.DataPropertyName = "Nationality";
            this.nationality.HeaderText = "Uyruk";
            this.nationality.MinimumWidth = 6;
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // checkOutDate
            // 
            this.checkOutDate.DataPropertyName = "CheckoutDate";
            this.checkOutDate.HeaderText = "CheckOutTarihi";
            this.checkOutDate.MinimumWidth = 6;
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnFindGuest);
            this.panel1.Controls.Add(this.findGuestSurNameOut);
            this.panel1.Controls.Add(this.findGuestNameOut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 79);
            this.panel1.TabIndex = 8;
            // 
            // btnFindGuest
            // 
            this.btnFindGuest.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFindGuest.BackGroundColor = System.Drawing.Color.MediumBlue;
            this.btnFindGuest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFindGuest.BorderRadius = 20;
            this.btnFindGuest.BorderSize = 0;
            this.btnFindGuest.FlatAppearance.BorderSize = 0;
            this.btnFindGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindGuest.ForeColor = System.Drawing.Color.OldLace;
            this.btnFindGuest.Location = new System.Drawing.Point(756, 26);
            this.btnFindGuest.Name = "btnFindGuest";
            this.btnFindGuest.Size = new System.Drawing.Size(228, 38);
            this.btnFindGuest.TabIndex = 4;
            this.btnFindGuest.TabStop = false;
            this.btnFindGuest.Text = "Misafir Ara";
            this.btnFindGuest.TextColor = System.Drawing.Color.OldLace;
            this.btnFindGuest.UseVisualStyleBackColor = false;
            this.btnFindGuest.Click += new System.EventHandler(this.btnFindGuest_Click);
            // 
            // findGuestSurNameOut
            // 
            this.findGuestSurNameOut.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.findGuestSurNameOut.Location = new System.Drawing.Point(413, 28);
            this.findGuestSurNameOut.MaxLength = 20;
            this.findGuestSurNameOut.Name = "findGuestSurNameOut";
            this.findGuestSurNameOut.Size = new System.Drawing.Size(228, 45);
            this.findGuestSurNameOut.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.findGuestSurNameOut.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.findGuestSurNameOut.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.findGuestSurNameOut.StateCommon.Border.ColorAngle = 45F;
            this.findGuestSurNameOut.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.findGuestSurNameOut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.findGuestSurNameOut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.findGuestSurNameOut.StateCommon.Border.Rounding = 12;
            this.findGuestSurNameOut.StateCommon.Content.Color1 = System.Drawing.Color.OldLace;
            this.findGuestSurNameOut.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findGuestSurNameOut.TabIndex = 3;
            this.findGuestSurNameOut.WordWrap = false;
            this.findGuestSurNameOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findGuestNameOut_KeyPress);
            // 
            // findGuestNameOut
            // 
            this.findGuestNameOut.Location = new System.Drawing.Point(79, 28);
            this.findGuestNameOut.MaxLength = 20;
            this.findGuestNameOut.Name = "findGuestNameOut";
            this.findGuestNameOut.Size = new System.Drawing.Size(228, 45);
            this.findGuestNameOut.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.findGuestNameOut.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.findGuestNameOut.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.findGuestNameOut.StateCommon.Border.ColorAngle = 45F;
            this.findGuestNameOut.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.findGuestNameOut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.findGuestNameOut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.findGuestNameOut.StateCommon.Border.Rounding = 12;
            this.findGuestNameOut.StateCommon.Content.Color1 = System.Drawing.Color.OldLace;
            this.findGuestNameOut.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findGuestNameOut.TabIndex = 2;
            this.findGuestNameOut.WordWrap = false;
            this.findGuestNameOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findGuestNameOut_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(317, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyisim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MİSAFİR ARA";
            // 
            // customerTbTableAdapter
            // 
            this.customerTbTableAdapter.ClearBeforeFill = true;
            // 
            // CheckOutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 554);
            this.Controls.Add(this.pnlRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOutPanel";
            this.Text = "CheckOutPanel";
            this.Load += new System.EventHandler(this.CheckOutPanel_Load);
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnFindGuest;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox findGuestSurNameOut;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox findGuestNameOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView checkOutDataGridView;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource customerTbBindingSource;
        private HotelDBDataSetTableAdapters.CustomerTbTableAdapter customerTbTableAdapter;
        private CustomButton btnAcceptCheckout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPortNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
    }
}