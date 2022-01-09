
namespace HotelReservation
{
    partial class TransitionPanel
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
            this.label15 = new System.Windows.Forms.Label();
            this.loadProgress = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.label15.Location = new System.Drawing.Point(72, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 63);
            this.label15.TabIndex = 11;
            this.label15.Text = "Bilgiler Yükleniyor...";
            // 
            // loadProgress
            // 
            this.loadProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loadProgress.AnimationSpeed = 500;
            this.loadProgress.BackColor = System.Drawing.Color.Transparent;
            this.loadProgress.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.loadProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.loadProgress.InnerMargin = 2;
            this.loadProgress.InnerWidth = -1;
            this.loadProgress.Location = new System.Drawing.Point(36, 78);
            this.loadProgress.MarqueeAnimationSpeed = 2000;
            this.loadProgress.Name = "loadProgress";
            this.loadProgress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.loadProgress.OuterMargin = -25;
            this.loadProgress.OuterWidth = 26;
            this.loadProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.loadProgress.ProgressWidth = 12;
            this.loadProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadProgress.Size = new System.Drawing.Size(288, 237);
            this.loadProgress.StartAngle = 270;
            this.loadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadProgress.SubscriptText = "";
            this.loadProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadProgress.SuperscriptText = "";
            this.loadProgress.TabIndex = 10;
            this.loadProgress.Tag = "%";
            this.loadProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadProgress.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TransitionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(364, 355);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.loadProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransitionPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 360;
            this.Text = "TransitionPanel";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private CircularProgressBar.CircularProgressBar loadProgress;
        private System.Windows.Forms.Timer timer1;
    }
}