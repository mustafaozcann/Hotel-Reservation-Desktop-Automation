using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace HotelReservation
{
    public partial class TransitionPanel : KryptonForm
    {
        
        public bool state { get; set; }
        public TransitionPanel()
        {
            InitializeComponent();
            loadProgress.Value = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();
            
            int randomValue = rnd.Next(5, 20);
            if ((loadProgress.Value + randomValue) <= 100)
            {
                loadProgress.Value += randomValue;
                loadProgress.Text = loadProgress.Tag.ToString() + loadProgress.Value;
                

            }

            else
            {
                
                timer1.Stop();
                state = true;
                this.Hide();

            }


            










        }
    }
}
