using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace HotelReservation
{
    public partial class PaymentPanel : KryptonForm
    {

        CustomMessageBox cmBox;

        string customerName;
        string roomNo;
        string amount;
        string currency;

        public bool state { get; set; }

        public PaymentPanel(string customerName, string roomNo, string amount, string currency)
        {
            InitializeComponent();


            this.customerName = customerName;
            this.roomNo = roomNo;
            this.amount = amount;
            this.currency = currency;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            cmBox = new CustomMessageBox("Müşteri Checkout Edilecek\n\t\tOnaylıyor Musun?");
            cmBox.ShowDialog();


            if (cmBox.answer)
            {
                state = true;

            }
            else
            {
                state = false;
            }

            this.Hide();
            
        }

        private void pnlPayment_Paint(object sender, PaintEventArgs e)
        {
            txtNamePayment.Text = customerName;
            txtAmountPayment.Text = txtAmountPayment.Tag.ToString() + amount + " " + currency;
            txtRoomPayment.Text = txtRoomPayment.Tag.ToString() + roomNo;
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
