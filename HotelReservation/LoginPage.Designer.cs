
namespace HotelReservation
{
    partial class LoginPage
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlProcess = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.navigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.login = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.loginButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.usernameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.passwordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.signin = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxSurName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSign = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tboxUserNameSign = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPassSign = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProcess)).BeginInit();
            this.pnlProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).BeginInit();
            this.navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            this.login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signin)).BeginInit();
            this.signin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(475, 606);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otel Yönetim Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.pictureBox1.Image = global::HotelReservation.Properties.Resources.hotelLogin;
            this.pictureBox1.Location = new System.Drawing.Point(104, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlProcess
            // 
            this.pnlProcess.Controls.Add(this.navigator);
            this.pnlProcess.Controls.Add(this.closeButton);
            this.pnlProcess.Controls.Add(this.pictureBox2);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlProcess.Location = new System.Drawing.Point(475, 0);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(475, 606);
            this.pnlProcess.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.pnlProcess.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlProcess.StateCommon.ColorAngle = 45F;
            this.pnlProcess.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pnlProcess.TabIndex = 1;
            // 
            // navigator
            // 
            this.navigator.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.navigator.Bar.ItemMaximumSize = new System.Drawing.Size(100, 50);
            this.navigator.Bar.ItemMinimumSize = new System.Drawing.Size(100, 20);
            this.navigator.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.Individual;
            this.navigator.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote;
            this.navigator.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.Custom1;
            this.navigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.navigator.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.navigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.navigator.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile;
            this.navigator.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.TabLowProfile;
            this.navigator.Location = new System.Drawing.Point(0, 158);
            this.navigator.Name = "navigator";
            this.navigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.login,
            this.signin});
            this.navigator.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.navigator.SelectedIndex = 0;
            this.navigator.Size = new System.Drawing.Size(475, 445);
            this.navigator.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.navigator.StateCommon.Page.Color2 = System.Drawing.Color.White;
            this.navigator.StateCommon.Page.ColorAngle = 45F;
            this.navigator.StateCommon.Page.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.navigator.StateCommon.Page.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.navigator.StateCommon.Panel.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.navigator.StateCommon.Panel.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.navigator.StateCommon.Panel.ColorAngle = 45F;
            this.navigator.StateCommon.Panel.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.navigator.StateCommon.Tab.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.navigator.StateCommon.Tab.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.navigator.StateCommon.Tab.Back.ColorAngle = 45F;
            this.navigator.StateCommon.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.navigator.StateCommon.Tab.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.navigator.StateCommon.Tab.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navigator.StateCommon.Tab.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.navigator.StateCommon.Tab.Border.ColorAngle = 45F;
            this.navigator.StateCommon.Tab.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.navigator.StateCommon.Tab.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.navigator.StateCommon.Tab.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.navigator.StateCommon.Tab.Border.Width = 0;
            this.navigator.StateCommon.Tab.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.navigator.StateCommon.Tab.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.navigator.TabIndex = 8;
            this.navigator.TabStop = false;
            this.navigator.Text = "kryptonNavigator1";
            // 
            // login
            // 
            this.login.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.login.Controls.Add(this.lblUsername);
            this.login.Controls.Add(this.loginButton);
            this.login.Controls.Add(this.usernameBox);
            this.login.Controls.Add(this.lblPassword);
            this.login.Controls.Add(this.passwordBox);
            this.login.Flags = 65534;
            this.login.LastVisibleSet = true;
            this.login.MinimumSize = new System.Drawing.Size(100, 50);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(473, 413);
            this.login.StateCommon.CheckButton.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StateCommon.CheckButton.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StateCommon.CheckButton.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StateCommon.CheckButton.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StateCommon.CheckButton.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login.StateCommon.Tab.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.login.StateCommon.Tab.Content.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.login.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login.StatePressed.Tab.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StatePressed.Tab.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StatePressed.Tab.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login.StateSelected.CheckButton.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.login.StateSelected.CheckButton.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login.StateSelected.CheckButton.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.login.StateSelected.CheckButton.Border.Rounding = 20;
            this.login.StateSelected.CheckButton.Border.Width = 1;
            this.login.StateSelected.Tab.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login.StateSelected.Tab.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.login.StateSelected.Tab.Back.ColorAngle = 45F;
            this.login.StateSelected.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.login.StateSelected.Tab.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.login.StateSelected.Tab.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.login.StateSelected.Tab.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.login.StateSelected.Tab.Content.ShortText.ColorAngle = 45F;
            this.login.StateSelected.Tab.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login.StateSelected.Tab.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.login.Text = "Giriş Yap";
            this.login.ToolTipTitle = "Page ToolTip";
            this.login.UniqueName = "53E0BC97B01842F6A795A665C4AA991C";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.lblUsername.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.Coral;
            this.lblUsername.Location = new System.Drawing.Point(5, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(155, 251);
            this.loginButton.Name = "loginButton";
            this.loginButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.loginButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.loginButton.OverrideDefault.Back.ColorAngle = 75F;
            this.loginButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.loginButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.loginButton.OverrideDefault.Border.ColorAngle = 45F;
            this.loginButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.OverrideDefault.Border.Rounding = 20;
            this.loginButton.OverrideDefault.Border.Width = 1;
            this.loginButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.loginButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.loginButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.loginButton.Size = new System.Drawing.Size(155, 48);
            this.loginButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.loginButton.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.loginButton.StateCommon.Back.ColorAngle = 75F;
            this.loginButton.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.loginButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.loginButton.StateCommon.Border.ColorAngle = 45F;
            this.loginButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.StateCommon.Border.Rounding = 20;
            this.loginButton.StateCommon.Border.Width = 2;
            this.loginButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.loginButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.loginButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.loginButton.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.loginButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.StatePressed.Back.Color1 = System.Drawing.Color.Indigo;
            this.loginButton.StatePressed.Back.Color2 = System.Drawing.Color.Brown;
            this.loginButton.StatePressed.Back.ColorAngle = 135F;
            this.loginButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.loginButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.loginButton.StatePressed.Border.ColorAngle = 135F;
            this.loginButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginButton.StatePressed.Border.Rounding = 20;
            this.loginButton.StatePressed.Border.Width = 1;
            this.loginButton.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.loginButton.StateTracking.Back.Color2 = System.Drawing.Color.Brown;
            this.loginButton.StateTracking.Back.ColorAngle = 45F;
            this.loginButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.loginButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.loginButton.StateTracking.Border.ColorAngle = 45F;
            this.loginButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.StateTracking.Border.Rounding = 20;
            this.loginButton.StateTracking.Border.Width = 1;
            this.loginButton.TabIndex = 6;
            this.loginButton.TabStop = false;
            this.loginButton.Values.Text = "Giriş Yap";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.AlwaysActive = false;
            this.usernameBox.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.usernameBox.Location = new System.Drawing.Point(5, 52);
            this.usernameBox.MaxLength = 20;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Palette = this.kryptonPalette1;
            this.usernameBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.usernameBox.Size = new System.Drawing.Size(455, 44);
            this.usernameBox.StateActive.Border.Color1 = System.Drawing.Color.OldLace;
            this.usernameBox.StateActive.Border.Color2 = System.Drawing.Color.Red;
            this.usernameBox.StateActive.Border.ColorAngle = 135F;
            this.usernameBox.StateActive.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.usernameBox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameBox.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.usernameBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.usernameBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.usernameBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.usernameBox.StateCommon.Border.ColorAngle = 45F;
            this.usernameBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.usernameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.usernameBox.StateCommon.Border.Rounding = 20;
            this.usernameBox.StateCommon.Border.Width = 1;
            this.usernameBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.usernameBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.TabStop = false;
            this.usernameBox.Tag = "Kullanıcı Adını Giriniz";
            this.usernameBox.Text = "Kullanıcı Adını Giriniz";
            this.usernameBox.Enter += new System.EventHandler(this.usernameBox_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameBox_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.lblPassword.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Coral;
            this.lblPassword.Location = new System.Drawing.Point(5, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Parola";
            // 
            // passwordBox
            // 
            this.passwordBox.AllowButtonSpecToolTips = true;
            this.passwordBox.AlwaysActive = false;
            this.passwordBox.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.passwordBox.Location = new System.Drawing.Point(3, 153);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.Size = new System.Drawing.Size(455, 44);
            this.passwordBox.StateActive.Border.Color1 = System.Drawing.Color.OldLace;
            this.passwordBox.StateActive.Border.Color2 = System.Drawing.Color.Red;
            this.passwordBox.StateActive.Border.ColorAngle = 135F;
            this.passwordBox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.passwordBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.passwordBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.passwordBox.StateCommon.Border.ColorAngle = 45F;
            this.passwordBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.passwordBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordBox.StateCommon.Border.Rounding = 20;
            this.passwordBox.StateCommon.Border.Width = 1;
            this.passwordBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TabStop = false;
            this.passwordBox.Tag = "Parola Giriniz";
            this.passwordBox.Text = "Parola Giriniz";
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // signin
            // 
            this.signin.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.signin.Controls.Add(this.label5);
            this.signin.Controls.Add(this.tboxSurName);
            this.signin.Controls.Add(this.label4);
            this.signin.Controls.Add(this.tboxName);
            this.signin.Controls.Add(this.label2);
            this.signin.Controls.Add(this.btnSign);
            this.signin.Controls.Add(this.tboxUserNameSign);
            this.signin.Controls.Add(this.label3);
            this.signin.Controls.Add(this.tboxPassSign);
            this.signin.Flags = 65534;
            this.signin.LastVisibleSet = true;
            this.signin.MinimumSize = new System.Drawing.Size(50, 50);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(473, 413);
            this.signin.StateCommon.Tab.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.signin.StateCommon.Tab.Content.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.signin.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signin.StateSelected.Tab.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signin.StateSelected.Tab.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.signin.StateSelected.Tab.Back.ColorAngle = 45F;
            this.signin.StateSelected.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.signin.StateSelected.Tab.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signin.StateSelected.Tab.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.signin.StateSelected.Tab.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.signin.StateSelected.Tab.Content.ShortText.ColorAngle = 45F;
            this.signin.StateSelected.Tab.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signin.StateSelected.Tab.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.signin.Text = "Kayıt Ol";
            this.signin.ToolTipTitle = "Page ToolTip";
            this.signin.UniqueName = "6B26B34132604D0F78B8BB1E552DBD2D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Soyisim";
            // 
            // tboxSurName
            // 
            this.tboxSurName.AlwaysActive = false;
            this.tboxSurName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tboxSurName.Location = new System.Drawing.Point(13, 143);
            this.tboxSurName.MaxLength = 20;
            this.tboxSurName.Name = "tboxSurName";
            this.tboxSurName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.tboxSurName.Size = new System.Drawing.Size(455, 44);
            this.tboxSurName.StateActive.Border.Color1 = System.Drawing.Color.OldLace;
            this.tboxSurName.StateActive.Border.Color2 = System.Drawing.Color.Red;
            this.tboxSurName.StateActive.Border.ColorAngle = 135F;
            this.tboxSurName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxSurName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.tboxSurName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.tboxSurName.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.tboxSurName.StateCommon.Border.ColorAngle = 45F;
            this.tboxSurName.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tboxSurName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxSurName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tboxSurName.StateCommon.Border.Rounding = 20;
            this.tboxSurName.StateCommon.Border.Width = 1;
            this.tboxSurName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tboxSurName.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxSurName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tboxSurName.TabIndex = 4;
            this.tboxSurName.TabStop = false;
            this.tboxSurName.Tag = "Soyisim Giriniz";
            this.tboxSurName.Text = "Soyisim Giriniz";
            this.tboxSurName.Enter += new System.EventHandler(this.tboxSurName_Enter);
            this.tboxSurName.Leave += new System.EventHandler(this.tboxSurName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "İsim";
            // 
            // tboxName
            // 
            this.tboxName.AlwaysActive = false;
            this.tboxName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tboxName.Location = new System.Drawing.Point(13, 52);
            this.tboxName.MaxLength = 20;
            this.tboxName.Name = "tboxName";
            this.tboxName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.tboxName.Size = new System.Drawing.Size(455, 44);
            this.tboxName.StateActive.Border.Color1 = System.Drawing.Color.OldLace;
            this.tboxName.StateActive.Border.Color2 = System.Drawing.Color.Red;
            this.tboxName.StateActive.Border.ColorAngle = 135F;
            this.tboxName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.tboxName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.tboxName.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.tboxName.StateCommon.Border.ColorAngle = 45F;
            this.tboxName.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tboxName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tboxName.StateCommon.Border.Rounding = 20;
            this.tboxName.StateCommon.Border.Width = 1;
            this.tboxName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tboxName.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tboxName.TabIndex = 3;
            this.tboxName.TabStop = false;
            this.tboxName.Tag = "İsminizi Giriniz";
            this.tboxName.Text = "İsminizi Giriniz";
            this.tboxName.Enter += new System.EventHandler(this.tboxName_Enter);
            this.tboxName.Leave += new System.EventHandler(this.tboxName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(8, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(155, 357);
            this.btnSign.Name = "btnSign";
            this.btnSign.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnSign.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btnSign.OverrideDefault.Back.ColorAngle = 75F;
            this.btnSign.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSign.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnSign.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnSign.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSign.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSign.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSign.OverrideDefault.Border.Rounding = 20;
            this.btnSign.OverrideDefault.Border.Width = 1;
            this.btnSign.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.btnSign.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.btnSign.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSign.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSign.Size = new System.Drawing.Size(155, 48);
            this.btnSign.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnSign.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btnSign.StateCommon.Back.ColorAngle = 75F;
            this.btnSign.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSign.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnSign.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnSign.StateCommon.Border.ColorAngle = 45F;
            this.btnSign.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSign.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSign.StateCommon.Border.Rounding = 20;
            this.btnSign.StateCommon.Border.Width = 2;
            this.btnSign.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.btnSign.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.btnSign.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.btnSign.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSign.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSign.StatePressed.Back.Color1 = System.Drawing.Color.Indigo;
            this.btnSign.StatePressed.Back.Color2 = System.Drawing.Color.Brown;
            this.btnSign.StatePressed.Back.ColorAngle = 135F;
            this.btnSign.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSign.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSign.StatePressed.Border.ColorAngle = 135F;
            this.btnSign.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSign.StatePressed.Border.Rounding = 20;
            this.btnSign.StatePressed.Border.Width = 1;
            this.btnSign.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.btnSign.StateTracking.Back.Color2 = System.Drawing.Color.Brown;
            this.btnSign.StateTracking.Back.ColorAngle = 45F;
            this.btnSign.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSign.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSign.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSign.StateTracking.Border.ColorAngle = 45F;
            this.btnSign.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSign.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSign.StateTracking.Border.Rounding = 20;
            this.btnSign.StateTracking.Border.Width = 1;
            this.btnSign.TabIndex = 11;
            this.btnSign.TabStop = false;
            this.btnSign.Values.Text = "Kayıt Ol";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // tboxUserNameSign
            // 
            this.tboxUserNameSign.AlwaysActive = false;
            this.tboxUserNameSign.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tboxUserNameSign.Location = new System.Drawing.Point(13, 226);
            this.tboxUserNameSign.MaxLength = 20;
            this.tboxUserNameSign.Name = "tboxUserNameSign";
            this.tboxUserNameSign.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.tboxUserNameSign.Size = new System.Drawing.Size(455, 44);
            this.tboxUserNameSign.StateActive.Border.Color1 = System.Drawing.Color.OldLace;
            this.tboxUserNameSign.StateActive.Border.Color2 = System.Drawing.Color.Red;
            this.tboxUserNameSign.StateActive.Border.ColorAngle = 135F;
            this.tboxUserNameSign.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxUserNameSign.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.tboxUserNameSign.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.tboxUserNameSign.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.tboxUserNameSign.StateCommon.Border.ColorAngle = 45F;
            this.tboxUserNameSign.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tboxUserNameSign.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxUserNameSign.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tboxUserNameSign.StateCommon.Border.Rounding = 20;
            this.tboxUserNameSign.StateCommon.Border.Width = 1;
            this.tboxUserNameSign.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tboxUserNameSign.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxUserNameSign.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tboxUserNameSign.TabIndex = 5;
            this.tboxUserNameSign.TabStop = false;
            this.tboxUserNameSign.Tag = "Kullanıcı Adını Giriniz";
            this.tboxUserNameSign.Text = "Kullanıcı Adını Giriniz";
            this.tboxUserNameSign.Enter += new System.EventHandler(this.tboxUserNameSign_Enter);
            this.tboxUserNameSign.Leave += new System.EventHandler(this.tboxUserNameSign_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(8, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parola";
            // 
            // tboxPassSign
            // 
            this.tboxPassSign.AllowButtonSpecToolTips = true;
            this.tboxPassSign.AlwaysActive = false;
            this.tboxPassSign.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tboxPassSign.Location = new System.Drawing.Point(13, 305);
            this.tboxPassSign.Name = "tboxPassSign";
            this.tboxPassSign.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.tboxPassSign.PasswordChar = '●';
            this.tboxPassSign.Size = new System.Drawing.Size(455, 44);
            this.tboxPassSign.StateActive.Border.Color1 = System.Drawing.Color.OldLace;
            this.tboxPassSign.StateActive.Border.Color2 = System.Drawing.Color.Red;
            this.tboxPassSign.StateActive.Border.ColorAngle = 135F;
            this.tboxPassSign.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxPassSign.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.tboxPassSign.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.tboxPassSign.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.tboxPassSign.StateCommon.Border.ColorAngle = 45F;
            this.tboxPassSign.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tboxPassSign.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tboxPassSign.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tboxPassSign.StateCommon.Border.Rounding = 20;
            this.tboxPassSign.StateCommon.Border.Width = 1;
            this.tboxPassSign.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tboxPassSign.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassSign.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tboxPassSign.TabIndex = 6;
            this.tboxPassSign.TabStop = false;
            this.tboxPassSign.Tag = "Parola Giriniz";
            this.tboxPassSign.Text = "Parola Giriniz";
            this.tboxPassSign.UseSystemPasswordChar = true;
            this.tboxPassSign.Enter += new System.EventHandler(this.tboxPassSign_Enter);
            this.tboxPassSign.Leave += new System.EventHandler(this.tboxPassSign_Leave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeButton.IconColor = System.Drawing.Color.Silver;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 24;
            this.closeButton.Location = new System.Drawing.Point(445, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 22);
            this.closeButton.TabIndex = 7;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.pictureBox2.Image = global::HotelReservation.Properties.Resources.loginAdmin;
            this.pictureBox2.Location = new System.Drawing.Point(193, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 606);
            this.Controls.Add(this.pnlProcess);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProcess)).EndInit();
            this.pnlProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).EndInit();
            this.navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signin)).EndInit();
            this.signin.ResumeLayout(false);
            this.signin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordBox;
        private System.Windows.Forms.Label lblPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator navigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage login;
        private ComponentFactory.Krypton.Navigator.KryptonPage signin;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tboxSurName;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tboxName;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSign;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tboxUserNameSign;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tboxPassSign;
    }
}