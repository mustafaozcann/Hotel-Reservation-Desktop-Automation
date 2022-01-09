using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;                



namespace HotelReservation
{
    public partial class PanelCustomCalendar : KryptonForm
    {



        public DateTime dateNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        public DateTime selectDate;
        public DateTime checkIndDate;
        public DateTime checkOutDate;



        public string headerText
        {
            get
            {
                return this.lblHeader.Text;
            }

            set
            {

                this.lblHeader.Text = value;

            }
        }

        private CustomMessageBox cmbox;

        public PanelCustomCalendar()
        {
            InitializeComponent();

            calendar.TodayDate = dateNow;
            
           
        }


        private void calendar_MouseClick(object sender, MouseEventArgs e)
        {

            if (headerText.Equals("CHECK-IN TARİHİ"))
                checkIndDate = DateTime.MinValue;

            else
                checkOutDate = DateTime.MinValue;
            
            
            if (calendar.CanSelect)
            {
                selectDate = new DateTime(calendar.SelectionStart.Year, calendar.SelectionStart.Month, calendar.SelectionStart.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                if (selectDate.Month == dateNow.Month && selectDate.Day < dateNow.Day)
                {
                    cmbox = new CustomMessageBox("Lütfen " + dateNow.ToString("dd/MM/yyyy") + " ve ileri tarihli bir günü seçiniz. ", false);
                    return;
                }

                else
                {

                    if (checkIndDate == DateTime.MinValue)
                    {
                        checkIndDate = selectDate;

                        this.Hide();
                        return;
                    }

                    if (checkOutDate == DateTime.MinValue)
                    {

                        if (selectDate.Day <= checkIndDate.Day)
                        {
                            cmbox = new CustomMessageBox("Checkout tarihi checkin tarihinden önce veya eşit olamaz.\n" + checkIndDate.AddDays(1).ToString("dd/MM/yyyy HH:MM:ss") + " günü ve sonraki günleri seçebilirsiniz.", false);
                            return;

                        }

                        checkOutDate = selectDate;
                        this.Hide();
                        return;
                    }

                }
            }
          
        }
    }
}
