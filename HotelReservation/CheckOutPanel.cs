using System;
using System.Data;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class CheckOutPanel : Form
    {

        DataView dw;
        DataTable dt;
        Database db;
        CustomMessageBox cmBox;

        PaymentPanel pnlPay;

        public CheckOutPanel()
        {
            InitializeComponent();
            dw = new DataView(hotelDBDataSet.CustomerTb);
            db = new Database();


            
        }

        private void CheckOutPanel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hotelDBDataSet.CustomerTb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customerTbTableAdapter.Fill(this.hotelDBDataSet.CustomerTb);

            dw.RowFilter = "CheckoutDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckoutDate <= #"
                + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'True'";

            dt = dw.ToTable();

            this.checkOutDataGridView.DataSource = dt;

        }

        private void btnAcceptCheckout_Click(object sender, EventArgs e)
        {
            if (checkOutDataGridView.SelectedRows.Count == 1)
            {

                int selectedrowindex = checkOutDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = checkOutDataGridView.Rows[selectedrowindex];

                string customerName = selectedRow.Cells["guest"].Value.ToString() + " " + selectedRow.Cells["surname"].Value.ToString();
                
                string roomNo = selectedRow.Cells["roomNo"].Value.ToString();
                string identityNo = Convert.ToString(selectedRow.Cells["identityNo"].Value);
                string passPortNo = Convert.ToString(selectedRow.Cells["passportNo"].Value);

                int customerId = identityNo.Length == 0 ? db.getCustomerId(passPortNo) : db.getCustomerId(identityNo);

                string[] payInfo = db.getAmountPaid(customerId);

                pnlPay = new PaymentPanel(customerName, roomNo, payInfo[1], payInfo[0]);
                pnlPay.ShowDialog();

                if (pnlPay.state)
                {
                    db.customerCheckOutAccept(customerId);
                    db.earnings(payInfo[0].Substring(0,3),Convert.ToDouble(payInfo[1]));
                    checkOutDataGridView.Rows.Remove(selectedRow);
                    cmBox = new CustomMessageBox("Müşteri başarıyla checkout edildi.", true);

                }
                else
                    cmBox = new CustomMessageBox("İşlem İptal Edildi.", true);

            }
        }

        private void btnFindGuest_Click(object sender, EventArgs e)
        {
            string guestName = findGuestNameOut.Text;
            string guestSurname = findGuestSurNameOut.Text;

            if(!guestName.Equals("") && !guestSurname.Equals(""))
            {
                
                dw.RowFilter = "CheckoutDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckoutDate <= #"
                    + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'True' And Name = '" + guestName + "' And Surname = '" + guestSurname + "'";
                dt = dw.ToTable();

                this.checkOutDataGridView.DataSource = dt;

                
            }

            else if(guestName.Length != 0 && guestSurname.Length == 0)
            {
                dw.RowFilter = "CheckoutDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckoutDate <= #"
                        + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'True' And Name = '" + guestName + "'";
                dt = dw.ToTable();

                this.checkOutDataGridView.DataSource = dt;
            }

            else if(guestSurname.Length != 0 && guestName.Length == 0)
            {
                dw.RowFilter = "CheckoutDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckoutDate <= #"
                        + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'True' And Surname = '" + guestSurname + "'";
                dt = dw.ToTable();

                this.checkOutDataGridView.DataSource = dt;
            }

            else
            {
                dw.RowFilter = "CheckoutDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckoutDate <= #"
                + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'True'";

                dt = dw.ToTable();

                this.checkOutDataGridView.DataSource = dt;
            }
        }

        private void findGuestNameOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }
    }
}
