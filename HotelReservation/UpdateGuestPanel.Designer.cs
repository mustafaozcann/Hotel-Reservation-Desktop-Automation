
namespace HotelReservation
{
    partial class UpdateGuestPanel
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
            this.pnlAddGuest = new HotelReservation.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new HotelReservation.CustomButton();
            this.btnUpdateGuest = new HotelReservation.CustomButton();
            this.txtGuestMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtGuestIdentityOrPassport = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbGuestGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbGuestNationality = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtGuestSurname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtGuestName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlAddGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestNationality)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddGuest
            // 
            this.pnlAddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlAddGuest.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pnlAddGuest.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.pnlAddGuest.BorderRadius = 40;
            this.pnlAddGuest.BorderSize = 5;
            this.pnlAddGuest.Controls.Add(this.label1);
            this.pnlAddGuest.Controls.Add(this.btnCancel);
            this.pnlAddGuest.Controls.Add(this.btnUpdateGuest);
            this.pnlAddGuest.Controls.Add(this.txtGuestMobileNo);
            this.pnlAddGuest.Controls.Add(this.txtGuestIdentityOrPassport);
            this.pnlAddGuest.Controls.Add(this.cbGuestGender);
            this.pnlAddGuest.Controls.Add(this.cbGuestNationality);
            this.pnlAddGuest.Controls.Add(this.txtGuestSurname);
            this.pnlAddGuest.Controls.Add(this.txtGuestName);
            this.pnlAddGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddGuest.ForeColor = System.Drawing.Color.White;
            this.pnlAddGuest.Location = new System.Drawing.Point(0, 0);
            this.pnlAddGuest.Name = "pnlAddGuest";
            this.pnlAddGuest.Size = new System.Drawing.Size(500, 564);
            this.pnlAddGuest.TabIndex = 0;
            this.pnlAddGuest.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddGuest_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Misafir Düzenleme Kartı";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DeepPink;
            this.btnCancel.BackGroundColor = System.Drawing.Color.DeepPink;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.OldLace;
            this.btnCancel.Location = new System.Drawing.Point(139, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(226, 38);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextColor = System.Drawing.Color.OldLace;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.BackColor = System.Drawing.Color.MediumBlue;
            this.btnUpdateGuest.BackGroundColor = System.Drawing.Color.MediumBlue;
            this.btnUpdateGuest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdateGuest.BorderRadius = 20;
            this.btnUpdateGuest.BorderSize = 0;
            this.btnUpdateGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnUpdateGuest.FlatAppearance.BorderSize = 0;
            this.btnUpdateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGuest.ForeColor = System.Drawing.Color.OldLace;
            this.btnUpdateGuest.Location = new System.Drawing.Point(139, 379);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(226, 38);
            this.btnUpdateGuest.TabIndex = 56;
            this.btnUpdateGuest.TabStop = false;
            this.btnUpdateGuest.Text = "Bilgileri Güncelle";
            this.btnUpdateGuest.TextColor = System.Drawing.Color.OldLace;
            this.btnUpdateGuest.UseVisualStyleBackColor = false;
            this.btnUpdateGuest.Click += new System.EventHandler(this.updateGuest_Click);
            // 
            // txtGuestMobileNo
            // 
            this.txtGuestMobileNo.AlwaysActive = false;
            this.txtGuestMobileNo.Location = new System.Drawing.Point(40, 295);
            this.txtGuestMobileNo.MaxLength = 11;
            this.txtGuestMobileNo.Name = "txtGuestMobileNo";
            this.txtGuestMobileNo.ShortcutsEnabled = false;
            this.txtGuestMobileNo.Size = new System.Drawing.Size(416, 55);
            this.txtGuestMobileNo.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestMobileNo.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestMobileNo.StateActive.Border.ColorAngle = 48F;
            this.txtGuestMobileNo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestMobileNo.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestMobileNo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestMobileNo.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestMobileNo.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestMobileNo.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestMobileNo.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestMobileNo.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestMobileNo.StateCommon.Border.Rounding = 20;
            this.txtGuestMobileNo.StateCommon.Border.Width = 1;
            this.txtGuestMobileNo.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestMobileNo.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestMobileNo.TabIndex = 48;
            this.txtGuestMobileNo.TabStop = false;
            this.txtGuestMobileNo.Tag = "Telefon Numarası";
            this.txtGuestMobileNo.Text = "Telefon Numarası";
            this.txtGuestMobileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestMobileNo.WordWrap = false;
            this.txtGuestMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextbox_KeyPress);
            // 
            // txtGuestIdentityOrPassport
            // 
            this.txtGuestIdentityOrPassport.AlwaysActive = false;
            this.txtGuestIdentityOrPassport.Location = new System.Drawing.Point(40, 213);
            this.txtGuestIdentityOrPassport.MaxLength = 11;
            this.txtGuestIdentityOrPassport.Name = "txtGuestIdentityOrPassport";
            this.txtGuestIdentityOrPassport.ShortcutsEnabled = false;
            this.txtGuestIdentityOrPassport.Size = new System.Drawing.Size(416, 55);
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
            this.txtGuestIdentityOrPassport.TabIndex = 47;
            this.txtGuestIdentityOrPassport.TabStop = false;
            this.txtGuestIdentityOrPassport.Tag = "TC Kimlik No";
            this.txtGuestIdentityOrPassport.Text = "TC Kimlik No";
            this.txtGuestIdentityOrPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestIdentityOrPassport.WordWrap = false;
            this.txtGuestIdentityOrPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextbox_KeyPress);
            // 
            // cbGuestGender
            // 
            this.cbGuestGender.AlwaysActive = false;
            this.cbGuestGender.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.cbGuestGender.DropDownWidth = 309;
            this.cbGuestGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cbGuestGender.Location = new System.Drawing.Point(250, 145);
            this.cbGuestGender.Name = "cbGuestGender";
            this.cbGuestGender.Size = new System.Drawing.Size(206, 43);
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
            this.cbGuestGender.TabIndex = 46;
            this.cbGuestGender.TabStop = false;
            this.cbGuestGender.Tag = "Cinsiyet";
            this.cbGuestGender.Text = "Cinsiyet";
            this.cbGuestGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGuestNationality_KeyPress);
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
            this.cbGuestNationality.Location = new System.Drawing.Point(38, 145);
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
            this.cbGuestNationality.TabIndex = 45;
            this.cbGuestNationality.TabStop = false;
            this.cbGuestNationality.Tag = "Uyruk";
            this.cbGuestNationality.Text = "Uyruk";
            this.cbGuestNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGuestNationality_KeyPress);
            // 
            // txtGuestSurname
            // 
            this.txtGuestSurname.AlwaysActive = false;
            this.txtGuestSurname.Location = new System.Drawing.Point(250, 66);
            this.txtGuestSurname.MaxLength = 20;
            this.txtGuestSurname.Name = "txtGuestSurname";
            this.txtGuestSurname.Size = new System.Drawing.Size(206, 55);
            this.txtGuestSurname.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestSurname.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestSurname.StateActive.Border.ColorAngle = 48F;
            this.txtGuestSurname.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestSurname.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestSurname.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestSurname.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestSurname.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestSurname.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestSurname.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestSurname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestSurname.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestSurname.StateCommon.Border.Rounding = 20;
            this.txtGuestSurname.StateCommon.Border.Width = 1;
            this.txtGuestSurname.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestSurname.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestSurname.TabIndex = 42;
            this.txtGuestSurname.TabStop = false;
            this.txtGuestSurname.Tag = "Soyadı";
            this.txtGuestSurname.Text = "Soyadı";
            this.txtGuestSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestSurname.WordWrap = false;
            this.txtGuestSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameSurnameTextbox_KeyPress);
            this.txtGuestSurname.Leave += new System.EventHandler(this.txtGuestSurname_Leave);
            // 
            // txtGuestName
            // 
            this.txtGuestName.AlwaysActive = false;
            this.txtGuestName.Location = new System.Drawing.Point(40, 66);
            this.txtGuestName.MaxLength = 20;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(206, 55);
            this.txtGuestName.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtGuestName.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtGuestName.StateActive.Border.ColorAngle = 48F;
            this.txtGuestName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestName.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtGuestName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtGuestName.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtGuestName.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtGuestName.StateCommon.Border.ColorAngle = 45F;
            this.txtGuestName.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGuestName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGuestName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGuestName.StateCommon.Border.Rounding = 20;
            this.txtGuestName.StateCommon.Border.Width = 1;
            this.txtGuestName.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtGuestName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestName.TabIndex = 41;
            this.txtGuestName.TabStop = false;
            this.txtGuestName.Tag = "Adı";
            this.txtGuestName.Text = "Adı";
            this.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameSurnameTextbox_KeyPress);
            this.txtGuestName.Leave += new System.EventHandler(this.txtGuestName_Leave);
            // 
            // UpdateGuestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(500, 564);
            this.Controls.Add(this.pnlAddGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateGuestPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.StateCommon.Border.ColorAngle = 45F;
            this.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateCommon.Border.Rounding = 40;
            this.StateCommon.Border.Width = 5;
            this.Text = "UpdateGuestPanel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateGuestPanel_Load);
            this.pnlAddGuest.ResumeLayout(false);
            this.pnlAddGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGuestNationality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pnlAddGuest;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestSurname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGuestIdentityOrPassport;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbGuestGender;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbGuestNationality;
        private System.Windows.Forms.Label label1;
        private CustomButton btnCancel;
        private CustomButton btnUpdateGuest;
    }
}