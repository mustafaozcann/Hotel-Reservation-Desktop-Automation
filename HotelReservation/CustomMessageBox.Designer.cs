
namespace HotelReservation
{
    partial class CustomMessageBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnContinue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::HotelReservation.Properties.Resources.success;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = false;
            this.lblmessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblmessage.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lblmessage.Location = new System.Drawing.Point(0, 104);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lblmessage.Size = new System.Drawing.Size(468, 67);
            this.lblmessage.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.LightLight;
            this.lblmessage.StateCommon.LongText.Color1 = System.Drawing.Color.OldLace;
            this.lblmessage.StateCommon.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblmessage.StateCommon.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.lblmessage.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.lblmessage.StateCommon.ShortText.ColorAngle = 0F;
            this.lblmessage.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.lblmessage.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmessage.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblmessage.StateCommon.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblmessage.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblmessage.TabIndex = 2;
            this.lblmessage.Values.Text = "";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(158, 216);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnContinue.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btnContinue.OverrideDefault.Back.ColorAngle = 75F;
            this.btnContinue.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnContinue.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnContinue.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnContinue.OverrideDefault.Border.ColorAngle = 45F;
            this.btnContinue.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinue.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnContinue.OverrideDefault.Border.Rounding = 20;
            this.btnContinue.OverrideDefault.Border.Width = 1;
            this.btnContinue.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.btnContinue.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.btnContinue.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnContinue.Size = new System.Drawing.Size(155, 48);
            this.btnContinue.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnContinue.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btnContinue.StateCommon.Back.ColorAngle = 75F;
            this.btnContinue.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnContinue.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnContinue.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnContinue.StateCommon.Border.ColorAngle = 45F;
            this.btnContinue.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinue.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnContinue.StateCommon.Border.Rounding = 20;
            this.btnContinue.StateCommon.Border.Width = 2;
            this.btnContinue.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.btnContinue.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.btnContinue.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.btnContinue.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnContinue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinue.StatePressed.Back.Color1 = System.Drawing.Color.Indigo;
            this.btnContinue.StatePressed.Back.Color2 = System.Drawing.Color.Brown;
            this.btnContinue.StatePressed.Back.ColorAngle = 135F;
            this.btnContinue.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnContinue.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnContinue.StatePressed.Border.ColorAngle = 135F;
            this.btnContinue.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinue.StatePressed.Border.Rounding = 20;
            this.btnContinue.StatePressed.Border.Width = 1;
            this.btnContinue.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.btnContinue.StateTracking.Back.Color2 = System.Drawing.Color.Brown;
            this.btnContinue.StateTracking.Back.ColorAngle = 45F;
            this.btnContinue.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnContinue.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnContinue.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnContinue.StateTracking.Border.ColorAngle = 45F;
            this.btnContinue.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinue.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnContinue.StateTracking.Border.Rounding = 20;
            this.btnContinue.StateTracking.Border.Width = 1;
            this.btnContinue.TabIndex = 7;
            this.btnContinue.TabStop = false;
            this.btnContinue.Values.Text = "Devam et";
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(158, 156);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnAccept.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.btnAccept.OverrideDefault.Back.ColorAngle = 75F;
            this.btnAccept.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAccept.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnAccept.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnAccept.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAccept.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAccept.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAccept.OverrideDefault.Border.Rounding = 20;
            this.btnAccept.OverrideDefault.Border.Width = 1;
            this.btnAccept.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.btnAccept.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.btnAccept.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAccept.Size = new System.Drawing.Size(155, 48);
            this.btnAccept.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnAccept.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btnAccept.StateCommon.Back.ColorAngle = 75F;
            this.btnAccept.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAccept.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnAccept.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnAccept.StateCommon.Border.ColorAngle = 45F;
            this.btnAccept.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAccept.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAccept.StateCommon.Border.Rounding = 20;
            this.btnAccept.StateCommon.Border.Width = 2;
            this.btnAccept.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.BlanchedAlmond;
            this.btnAccept.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.btnAccept.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.btnAccept.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnAccept.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.StatePressed.Back.Color1 = System.Drawing.Color.Indigo;
            this.btnAccept.StatePressed.Back.Color2 = System.Drawing.Color.Brown;
            this.btnAccept.StatePressed.Back.ColorAngle = 135F;
            this.btnAccept.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAccept.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAccept.StatePressed.Border.ColorAngle = 135F;
            this.btnAccept.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAccept.StatePressed.Border.Rounding = 20;
            this.btnAccept.StatePressed.Border.Width = 1;
            this.btnAccept.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.btnAccept.StateTracking.Back.Color2 = System.Drawing.Color.Brown;
            this.btnAccept.StateTracking.Back.ColorAngle = 45F;
            this.btnAccept.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAccept.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAccept.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAccept.StateTracking.Border.ColorAngle = 45F;
            this.btnAccept.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAccept.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAccept.StateTracking.Border.Rounding = 20;
            this.btnAccept.StateTracking.Border.Width = 1;
            this.btnAccept.TabIndex = 8;
            this.btnAccept.TabStop = false;
            this.btnAccept.Values.Text = "Onaylıyorum";
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(468, 287);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateCommon.Border.Rounding = 360;
            this.StateCommon.Border.Width = 2;
            this.Text = "CustomMessageBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomMessageBox_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblmessage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnContinue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAccept;
        private System.Windows.Forms.Timer timer1;
    }
}