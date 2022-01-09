using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HotelReservation
{
    public partial class MainPanel : Form
    {


        Database db;

        int hotelRoomRatio;
        Random rnd;
        string adminInfo;
        public MainPanel(string adminInfo)
        {
            InitializeComponent();
            db = new Database();

            this.adminInfo = adminInfo;
            lblAdminName.Text = adminInfo.ToUpper();

            

           
            setCurrencyLabels();
            setEarningsLabels();
            setRoomInfoLabels();

            rnd = new Random();
            hotelRoomRatio = db.getHotelFullRatio();

            progressHotelFullRatio.Value = 0;

            progressTimer.Start();

            chartControl();


            



        }


        private void setRoomInfoLabels()
        {
            int totalRoomCount = db.getTotalCountOfRoom();
            

            lblRoomCount.Text = lblRoomCount.Tag.ToString() + totalRoomCount.ToString();
            lblFreeRoomCount.Text = lblFreeRoomCount.Tag.ToString() + (totalRoomCount - db.getFullRoomCount()).ToString();
        }

        private void setEarningsLabels()
        {
            // EarningsUSD, EarningsTRY, EarningsEUR  ₺ 

            List<string[]> earningsList = db.getEarnings();

            double totalUSDEarnings = 0;
            double totalTRYEarnings = 0;
            double totalEUREarnings = 0;

            double totalEarnings = 0;




            foreach(string[] earning in earningsList)
            {
                //USD, EUR
                int i = 0;
                if (!earning[i].Equals(""))
                    totalUSDEarnings += Convert.ToDouble(earning[i]);
                
                if(!earning[i + 1].Equals(""))
                    totalTRYEarnings += Convert.ToDouble(earning[i + 1]);

                if (!earning[i + 2].Equals(""))
                    totalEUREarnings += Convert.ToDouble(earning[i + 2]);


            }

            string[] currency = db.getCurrency();


            totalEarnings = totalUSDEarnings * Convert.ToDouble(currency[0]) + totalEUREarnings * Convert.ToDouble(currency[1]) + totalTRYEarnings;


            lblEUREarnings.Text = lblEUREarnings.Tag.ToString() + totalEUREarnings.ToString() + "€";
            lblUSDEarnings.Text = lblUSDEarnings.Tag.ToString() + totalUSDEarnings.ToString() + "$";
            lblTRYEarnings.Text = lblTRYEarnings.Tag.ToString() + totalTRYEarnings.ToString() + "₺";

            lblTotalEarnings.Text = lblTotalEarnings.Tag.ToString()+ " " + totalEarnings.ToString() + "₺";

        }
        private void setCurrencyLabels()
        {

            string[] currencys = db.getCurrency();

            lblUSD.Text = lblUSD.Tag.ToString() + currencys[0] + "₺";
            lblEUR.Text = lblEUR.Tag.ToString() + currencys[1] + "₺";

            string dayInfo = "";

            DateTime lastUpdateDate = DateTime.Parse(currencys[2]);

            if (lastUpdateDate.Day == DateTime.Now.Day)
                dayInfo = "Bugün";
            else if (lastUpdateDate.Day == DateTime.Now.AddDays(-1).Day)
                dayInfo = "Dün";
            else
                dayInfo = lastUpdateDate.ToString("dd/MM/yyyy");

            lblCurrencyLastUpdate.Text = "Son Güncelleme : "+ dayInfo + " "  + lastUpdateDate.ToString("HH:mm:ss");


        }

        private void getCurrency()
        {
            
            try
            {
                XmlDocument xmlData = new XmlDocument();
                xmlData.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                double usd = Convert.ToDouble(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                double eur = Convert.ToDouble(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));

                db.updateCurrency(DateTime.Now, usd, eur);

                
                lblUSD.Text = lblUSD.Tag.ToString() + String.Format("{0:0.0000}", usd) + "₺";
                lblEUR.Text = lblEUR.Tag.ToString() + String.Format("{0:0.0000}", eur) + "₺";

                lblCurrencyLastUpdate.Text = "Son Güncelleme : Bugün "+ DateTime.Now.ToString("HH:mm:ss");

                

                


                
            }
            catch (Exception e)
            {
                currencyTimer.Stop();
                
            }

        }



        //chartKontrol
        private void chartControl()
        {

            int[,] values = db.getLeavingGuest();
            string[] months = { "OCAK", "SUBAT", "MART", "NISAN", "MAYIS", "HAZİRAN", "TEMMUZ", "AGUSTOS", "EYLUL", "EKIM", "KASIM", "ARALIK" };


            LineSeries lineSeries = new LineSeries()
            {
                DataLabels = true, Values = new ChartValues<int>(),
                LabelPoint = point => point.Y.ToString(),
                

            };

            Axis axisX = new Axis()
            {
                Separator = new Separator { Step = 1, IsEnabled = false },
                Labels = new List<string>()
            };

            Axis axisY = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                Separator = new Separator(),
                MinValue = 0
            };

            
            Task.Run(() =>
            {            
                for(int i = 0; i < 12; i++)
                {
                    Thread.Sleep(300);

                    lineSeries.Values.Add(values[i,0]);
                    axisX.Labels.Add(months[i]);
                }
            });

            

            cartesianChart1.Series.Add(lineSeries);
            cartesianChart1.AxisX.Add(axisX);
            cartesianChart1.AxisY.Add(axisY);
            //********************************************************************************************////**************////

            

        }

        private void pnlForeignCurrency_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(
                Color.FromArgb(11, 14, 17)
                );
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.FromArgb(11, 14, 17), 0.00f)), this.pnlForeignCurrency.HorizontalScroll.Value, this.pnlForeignCurrency.VerticalScroll.Value, this.pnlForeignCurrency.Width, this.pnlForeignCurrency.Height, 10);
            g.FillRoundedRectangle(brush, this.pnlForeignCurrency.HorizontalScroll.Value, this.pnlForeignCurrency.VerticalScroll.Value, this.pnlForeignCurrency.Width, this.pnlForeignCurrency.Height, 10);
        }
        private void pnlPriceInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(
                Color.FromArgb(20, 34, 33)
                );
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.FromArgb(20, 34, 33), 0.00f)), this.pnlPriceInfo.HorizontalScroll.Value, this.pnlPriceInfo.VerticalScroll.Value, this.pnlPriceInfo.Width, this.pnlPriceInfo.Height, 10);
            g.FillRoundedRectangle(brush, this.pnlPriceInfo.HorizontalScroll.Value, this.pnlPriceInfo.VerticalScroll.Value, this.pnlPriceInfo.Width, this.pnlPriceInfo.Height, 10);

        }
        private void pnlRoomsInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(
                Color.FromArgb(0, 23, 35)
                );
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.FromArgb(0, 23, 35), 0.00f)), this.pnlRoomsInfo.HorizontalScroll.Value, this.pnlRoomsInfo.VerticalScroll.Value, this.pnlRoomsInfo.Width, this.pnlRoomsInfo.Height, 10);
            g.FillRoundedRectangle(brush, this.pnlRoomsInfo.HorizontalScroll.Value, this.pnlRoomsInfo.VerticalScroll.Value, this.pnlRoomsInfo.Width, this.pnlRoomsInfo.Height, 10);

        }
        private void pnlAdminInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(
                Color.FromArgb(255, 215, 0)
                );
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.FromArgb(255, 215, 0), 0.00f)), this.pnlAdminInfo.HorizontalScroll.Value, this.pnlAdminInfo.VerticalScroll.Value, this.pnlAdminInfo.Width, this.pnlAdminInfo.Height, 10);
            g.FillRoundedRectangle(brush, this.pnlAdminInfo.HorizontalScroll.Value, this.pnlAdminInfo.VerticalScroll.Value, this.pnlAdminInfo.Width, this.pnlAdminInfo.Height, 10);
        }
        private void MainPanel_Load(object sender, EventArgs e)
        {
            this.currencyTimer.Start();
            
        }

        private void currencyTimer_Tick(object sender, EventArgs e)
        {
            getCurrency();
            
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {

            int randomStepValue = rnd.Next(1, 4);

            if(progressHotelFullRatio.Value + randomStepValue < hotelRoomRatio)
            {
                progressHotelFullRatio.Value += randomStepValue;
                progressHotelFullRatio.Tag = '%' + progressHotelFullRatio.Value.ToString();
                progressHotelFullRatio.Text = progressHotelFullRatio.Tag.ToString();
            }

            else
            {
                progressHotelFullRatio.Value = hotelRoomRatio;
                progressHotelFullRatio.Tag = '%' + progressHotelFullRatio.Value.ToString();
                progressHotelFullRatio.Text = progressHotelFullRatio.Tag.ToString();
                progressTimer.Stop();
            }
        }
    }
}
