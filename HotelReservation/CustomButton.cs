using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace HotelReservation
{
    class CustomButton : Button
    {
        //fields

        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        //Properties

        [Category("Mustafa")]
        public Color BorderColor
        {

            get
            {
                return borderColor;
            }


            set
            {
                borderColor = value;
                this.Invalidate();
            }

        }
        [Category("Mustafa")]
        public int BorderRadius
        {
            get
            {

                return borderRadius;
            }


            set
            {
                if (value <= this.Height)
                    borderRadius = value;
                else borderRadius = this.Height;
                this.Invalidate();
            }


        }


        [Category("Mustafa")]
        public int BorderSize
        {

            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();

            }



        }


        //optional

        [Category("Mustafa")]
        public Color BackGroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("Mustafa")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }

        }



        //Constructor
        public CustomButton()
        {
            InitializeComponent();

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;

            
            
                 

        }

        //Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            
            return path;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);


            if (BorderRadius > 2)//Rounded Button
            {

                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius-1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))

                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    //Draw surface border Hd result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button Border
                    if (BorderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);


                }

            }
            else //Normal Button
            {
                //Button surface
                this.Region = new Region(rectSurface);

                //Button border
                if(BorderSize >= 1)
                {
                    using(Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);

                    }
                }

            }

        }

        private void ButtonResize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomButton
            // 
            this.BackColorChanged += new System.EventHandler(this.CustomButton_BackColorChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomButton_Paint);
            this.Resize += new System.EventHandler(this.ButtonResize);
            this.ResumeLayout(false);

        }

        private void CustomButton_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void CustomButton_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
