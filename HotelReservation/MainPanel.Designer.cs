
namespace HotelReservation
{
    partial class MainPanel
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
            this.desktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.progressHotelFullRatio = new CircularProgressBar.CircularProgressBar();
            this.currencyTimer = new System.Windows.Forms.Timer(this.components);
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.myTableLayoutPanel1 = new HotelReservation.MyTableLayoutPanel();
            this.pnlAdminInfo = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlForeignCurrency = new System.Windows.Forms.Panel();
            this.lblEUR = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblCurrencyLastUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRoomsInfo = new System.Windows.Forms.Panel();
            this.lblRoomCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFreeRoomCount = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlPriceInfo = new System.Windows.Forms.Panel();
            this.lblTotalEarnings = new System.Windows.Forms.Label();
            this.lblEUREarnings = new System.Windows.Forms.Label();
            this.lblUSDEarnings = new System.Windows.Forms.Label();
            this.lblTRYEarnings = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desktop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.myTableLayoutPanel1.SuspendLayout();
            this.pnlAdminInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlForeignCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlRoomsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlPriceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // desktop
            // 
            this.desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.desktop.Controls.Add(this.myTableLayoutPanel1);
            this.desktop.Controls.Add(this.panel2);
            this.desktop.Controls.Add(this.panel1);
            this.desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktop.Location = new System.Drawing.Point(0, 0);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(1185, 701);
            this.desktop.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.cartesianChart1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(431, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 557);
            this.panel2.TabIndex = 5;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(36, 88);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(686, 444);
            this.cartesianChart1.TabIndex = 8;
            this.cartesianChart1.Text = "Tüm yıl istatistiği";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.label16.Location = new System.Drawing.Point(40, 26);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(250, 63);
            this.label16.TabIndex = 7;
            this.label16.Text = "Konaklama İstatistiği";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.progressHotelFullRatio);
            this.panel1.Location = new System.Drawing.Point(6, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 557);
            this.panel1.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.label15.Location = new System.Drawing.Point(64, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(292, 63);
            this.label15.TabIndex = 7;
            this.label15.Text = "OTEL DOLULUK ORANI";
            // 
            // progressHotelFullRatio
            // 
            this.progressHotelFullRatio.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressHotelFullRatio.AnimationSpeed = 500;
            this.progressHotelFullRatio.BackColor = System.Drawing.Color.Transparent;
            this.progressHotelFullRatio.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressHotelFullRatio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.progressHotelFullRatio.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.progressHotelFullRatio.InnerMargin = 2;
            this.progressHotelFullRatio.InnerWidth = -1;
            this.progressHotelFullRatio.Location = new System.Drawing.Point(52, 149);
            this.progressHotelFullRatio.MarqueeAnimationSpeed = 2000;
            this.progressHotelFullRatio.Name = "progressHotelFullRatio";
            this.progressHotelFullRatio.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.progressHotelFullRatio.OuterMargin = -25;
            this.progressHotelFullRatio.OuterWidth = 26;
            this.progressHotelFullRatio.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressHotelFullRatio.ProgressWidth = 12;
            this.progressHotelFullRatio.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressHotelFullRatio.Size = new System.Drawing.Size(303, 287);
            this.progressHotelFullRatio.StartAngle = 270;
            this.progressHotelFullRatio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressHotelFullRatio.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressHotelFullRatio.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressHotelFullRatio.SubscriptText = "";
            this.progressHotelFullRatio.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressHotelFullRatio.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressHotelFullRatio.SuperscriptText = "";
            this.progressHotelFullRatio.TabIndex = 0;
            this.progressHotelFullRatio.Tag = "%";
            this.progressHotelFullRatio.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressHotelFullRatio.Value = 68;
            // 
            // currencyTimer
            // 
            this.currencyTimer.Interval = 50000;
            this.currencyTimer.Tick += new System.EventHandler(this.currencyTimer_Tick);
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // myTableLayoutPanel1
            // 
            this.myTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTableLayoutPanel1.ColumnCount = 4;
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.Controls.Add(this.pnlAdminInfo, 3, 0);
            this.myTableLayoutPanel1.Controls.Add(this.pnlForeignCurrency, 0, 0);
            this.myTableLayoutPanel1.Controls.Add(this.pnlRoomsInfo, 2, 0);
            this.myTableLayoutPanel1.Controls.Add(this.pnlPriceInfo, 1, 0);
            this.myTableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.myTableLayoutPanel1.Name = "myTableLayoutPanel1";
            this.myTableLayoutPanel1.RowCount = 1;
            this.myTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.myTableLayoutPanel1.Size = new System.Drawing.Size(1176, 132);
            this.myTableLayoutPanel1.TabIndex = 6;
            // 
            // pnlAdminInfo
            // 
            this.pnlAdminInfo.AutoSize = true;
            this.pnlAdminInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlAdminInfo.Controls.Add(this.lblAdminName);
            this.pnlAdminInfo.Controls.Add(this.label8);
            this.pnlAdminInfo.Controls.Add(this.pictureBox2);
            this.pnlAdminInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminInfo.Location = new System.Drawing.Point(885, 3);
            this.pnlAdminInfo.Name = "pnlAdminInfo";
            this.pnlAdminInfo.Size = new System.Drawing.Size(288, 126);
            this.pnlAdminInfo.TabIndex = 10;
            this.pnlAdminInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminInfo_Paint);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Gold;
            this.lblAdminName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdminName.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.lblAdminName.Location = new System.Drawing.Point(3, 52);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(146, 21);
            this.lblAdminName.TabIndex = 7;
            this.lblAdminName.Text = "ERKAN YANYILDIZI ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Resepsiyon Görevlisi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::HotelReservation.Properties.Resources.admin2;
            this.pictureBox2.Location = new System.Drawing.Point(181, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pnlForeignCurrency
            // 
            this.pnlForeignCurrency.AutoSize = true;
            this.pnlForeignCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlForeignCurrency.Controls.Add(this.lblEUR);
            this.pnlForeignCurrency.Controls.Add(this.lblUSD);
            this.pnlForeignCurrency.Controls.Add(this.lblCurrencyLastUpdate);
            this.pnlForeignCurrency.Controls.Add(this.label2);
            this.pnlForeignCurrency.Controls.Add(this.pictureBox4);
            this.pnlForeignCurrency.Controls.Add(this.label1);
            this.pnlForeignCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForeignCurrency.Location = new System.Drawing.Point(3, 3);
            this.pnlForeignCurrency.Name = "pnlForeignCurrency";
            this.pnlForeignCurrency.Size = new System.Drawing.Size(288, 126);
            this.pnlForeignCurrency.TabIndex = 7;
            this.pnlForeignCurrency.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForeignCurrency_Paint);
            // 
            // lblEUR
            // 
            this.lblEUR.AutoSize = true;
            this.lblEUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.lblEUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEUR.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEUR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(53)))));
            this.lblEUR.Location = new System.Drawing.Point(7, 66);
            this.lblEUR.Name = "lblEUR";
            this.lblEUR.Size = new System.Drawing.Size(120, 21);
            this.lblEUR.TabIndex = 9;
            this.lblEUR.Tag = "1€ ≌ ";
            this.lblEUR.Text = "1€ ≌ 15,4235₺";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.lblUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUSD.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(53)))));
            this.lblUSD.Location = new System.Drawing.Point(7, 40);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(120, 21);
            this.lblUSD.TabIndex = 8;
            this.lblUSD.Tag = "1$ ≌ ";
            this.lblUSD.Text = "1$ ≌ 13,4235₺";
            // 
            // lblCurrencyLastUpdate
            // 
            this.lblCurrencyLastUpdate.AutoSize = true;
            this.lblCurrencyLastUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.lblCurrencyLastUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrencyLastUpdate.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrencyLastUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lblCurrencyLastUpdate.Location = new System.Drawing.Point(3, 105);
            this.lblCurrencyLastUpdate.Name = "lblCurrencyLastUpdate";
            this.lblCurrencyLastUpdate.Size = new System.Drawing.Size(0, 21);
            this.lblCurrencyLastUpdate.TabIndex = 7;
            this.lblCurrencyLastUpdate.Tag = "Son Güncelleme : Bugün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Döviz Kurları";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::HotelReservation.Properties.Resources.candlestick_chart_80px1;
            this.pictureBox4.Location = new System.Drawing.Point(175, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 126);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // pnlRoomsInfo
            // 
            this.pnlRoomsInfo.AutoSize = true;
            this.pnlRoomsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlRoomsInfo.Controls.Add(this.lblRoomCount);
            this.pnlRoomsInfo.Controls.Add(this.label6);
            this.pnlRoomsInfo.Controls.Add(this.lblFreeRoomCount);
            this.pnlRoomsInfo.Controls.Add(this.pictureBox3);
            this.pnlRoomsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoomsInfo.Location = new System.Drawing.Point(591, 3);
            this.pnlRoomsInfo.Name = "pnlRoomsInfo";
            this.pnlRoomsInfo.Size = new System.Drawing.Size(288, 126);
            this.pnlRoomsInfo.TabIndex = 9;
            this.pnlRoomsInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRoomsInfo_Paint);
            // 
            // lblRoomCount
            // 
            this.lblRoomCount.AutoSize = true;
            this.lblRoomCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.lblRoomCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRoomCount.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.lblRoomCount.Location = new System.Drawing.Point(3, 52);
            this.lblRoomCount.Name = "lblRoomCount";
            this.lblRoomCount.Size = new System.Drawing.Size(0, 21);
            this.lblRoomCount.TabIndex = 6;
            this.lblRoomCount.Tag = "Toplam oda sayısı :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oda Durumları";
            // 
            // lblFreeRoomCount
            // 
            this.lblFreeRoomCount.AutoSize = true;
            this.lblFreeRoomCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.lblFreeRoomCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFreeRoomCount.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFreeRoomCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.lblFreeRoomCount.Location = new System.Drawing.Point(3, 83);
            this.lblFreeRoomCount.Name = "lblFreeRoomCount";
            this.lblFreeRoomCount.Size = new System.Drawing.Size(0, 21);
            this.lblFreeRoomCount.TabIndex = 4;
            this.lblFreeRoomCount.Tag = "Boş oda sayısı: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::HotelReservation.Properties.Resources.brownRoom;
            this.pictureBox3.Location = new System.Drawing.Point(175, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pnlPriceInfo
            // 
            this.pnlPriceInfo.AutoSize = true;
            this.pnlPriceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlPriceInfo.Controls.Add(this.lblTotalEarnings);
            this.pnlPriceInfo.Controls.Add(this.lblEUREarnings);
            this.pnlPriceInfo.Controls.Add(this.lblUSDEarnings);
            this.pnlPriceInfo.Controls.Add(this.lblTRYEarnings);
            this.pnlPriceInfo.Controls.Add(this.label10);
            this.pnlPriceInfo.Controls.Add(this.pictureBox1);
            this.pnlPriceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPriceInfo.Location = new System.Drawing.Point(297, 3);
            this.pnlPriceInfo.Name = "pnlPriceInfo";
            this.pnlPriceInfo.Size = new System.Drawing.Size(288, 126);
            this.pnlPriceInfo.TabIndex = 8;
            this.pnlPriceInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPriceInfo_Paint);
            // 
            // lblTotalEarnings
            // 
            this.lblTotalEarnings.AutoSize = true;
            this.lblTotalEarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.lblTotalEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalEarnings.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalEarnings.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalEarnings.Location = new System.Drawing.Point(3, 101);
            this.lblTotalEarnings.Name = "lblTotalEarnings";
            this.lblTotalEarnings.Size = new System.Drawing.Size(131, 21);
            this.lblTotalEarnings.TabIndex = 10;
            this.lblTotalEarnings.Tag = "Total ≌";
            this.lblTotalEarnings.Text = "Total ≌ 222912₺";
            // 
            // lblEUREarnings
            // 
            this.lblEUREarnings.AutoSize = true;
            this.lblEUREarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.lblEUREarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEUREarnings.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEUREarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEUREarnings.Location = new System.Drawing.Point(3, 74);
            this.lblEUREarnings.Name = "lblEUREarnings";
            this.lblEUREarnings.Size = new System.Drawing.Size(121, 21);
            this.lblEUREarnings.TabIndex = 9;
            this.lblEUREarnings.Tag = "Euro = ";
            this.lblEUREarnings.Text = "Euro = 10000€";
            // 
            // lblUSDEarnings
            // 
            this.lblUSDEarnings.AutoSize = true;
            this.lblUSDEarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.lblUSDEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUSDEarnings.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUSDEarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUSDEarnings.Location = new System.Drawing.Point(3, 53);
            this.lblUSDEarnings.Name = "lblUSDEarnings";
            this.lblUSDEarnings.Size = new System.Drawing.Size(127, 21);
            this.lblUSDEarnings.TabIndex = 8;
            this.lblUSDEarnings.Tag = "Dolar = ";
            this.lblUSDEarnings.Text = "Dolar = 10000$";
            // 
            // lblTRYEarnings
            // 
            this.lblTRYEarnings.AutoSize = true;
            this.lblTRYEarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.lblTRYEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTRYEarnings.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRYEarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTRYEarnings.Location = new System.Drawing.Point(4, 32);
            this.lblTRYEarnings.Name = "lblTRYEarnings";
            this.lblTRYEarnings.Size = new System.Drawing.Size(162, 21);
            this.lblTRYEarnings.TabIndex = 7;
            this.lblTRYEarnings.Tag = "Türk Lirası = ";
            this.lblTRYEarnings.Text = "Türk Lirası = 10000₺";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Toplam Kazanç";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::HotelReservation.Properties.Resources.yellowMoneyBag;
            this.pictureBox1.Location = new System.Drawing.Point(175, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 701);
            this.Controls.Add(this.desktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.desktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.myTableLayoutPanel1.ResumeLayout(false);
            this.myTableLayoutPanel1.PerformLayout();
            this.pnlAdminInfo.ResumeLayout(false);
            this.pnlAdminInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlForeignCurrency.ResumeLayout(false);
            this.pnlForeignCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlRoomsInfo.ResumeLayout(false);
            this.pnlRoomsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlPriceInfo.ResumeLayout(false);
            this.pnlPriceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel desktop;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar progressHotelFullRatio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MyTableLayoutPanel myTableLayoutPanel1;
        private System.Windows.Forms.Panel pnlAdminInfo;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlForeignCurrency;
        private System.Windows.Forms.Label lblCurrencyLastUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRoomsInfo;
        private System.Windows.Forms.Label lblRoomCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFreeRoomCount;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlPriceInfo;
        private System.Windows.Forms.Label lblTotalEarnings;
        private System.Windows.Forms.Label lblEUREarnings;
        private System.Windows.Forms.Label lblUSDEarnings;
        private System.Windows.Forms.Label lblTRYEarnings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer currencyTimer;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label lblEUR;
        private System.Windows.Forms.Label lblUSD;
    }
}