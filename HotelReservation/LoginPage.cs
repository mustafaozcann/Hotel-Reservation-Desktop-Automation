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
    public partial class LoginPage : KryptonForm
    {
        Database db;
        CustomMessageBox cmbox;
        Board board;        
        

        public LoginPage()
        {
            

            db = new Database();
            InitializeComponent();
            this.navigator.AllowTabFocus = false; //kenardaki ....(Odak) çerçevelerini kaldırır.
            
            
            
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(db.adminLogin(this.usernameBox.Text, this.passwordBox.Text))
            {
                cmbox = new CustomMessageBox("Giriş Başarılı",true, 1);
                string adminNameSurname = db.getAdminInfo(this.usernameBox.Text);
                board = new Board(adminNameSurname);
                this.Hide();
                board.Show();
            }
            else
            {
                cmbox = new CustomMessageBox("Kullanıcı adı veya parola yanlış", false, 1);
            }

        }

        private void setDefaultValue()
        {

            foreach(KryptonTextBox tb in this.signin.Controls.OfType<KryptonTextBox>())
                tb.Text = tb.Tag.ToString();
            
            


        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            string username, password, name, surname;

            username = tboxUserNameSign.Text;
            password = tboxPassSign.Text;
            name = tboxName.Text;
            surname = tboxSurName.Text;


            if(db.adminSignIn(username, password, name, surname))
            {

                cmbox = new CustomMessageBox("Kayıt Başarılı", true);
                setDefaultValue();


            }

            else
            {
                cmbox = new CustomMessageBox("Kullanıcı adı kullanılıyor.", false);
                
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        //Textbox enter event
        private void usernameBox_Enter(object sender, EventArgs e)
        {
            

            if (usernameBox.Text.Trim() != "" || usernameBox.Text != null)
                usernameBox.Text = "";
           
            

            
        }
        private void passwordBox_Enter(object sender, EventArgs e)
        {
            

            if (passwordBox.Text.Trim() != "" || passwordBox.Text != null)
                passwordBox.Text = "";
        }
        private void tboxName_Enter(object sender, EventArgs e)
        {
            

            if (tboxName.Text.Trim() != "" || tboxName.Text != null)
                tboxName.Text = "";       
        }
        private void tboxSurName_Enter(object sender, EventArgs e)
        {
            

            if (tboxSurName.Text.Trim() != "" || tboxSurName.Text != null)
                tboxSurName.Text = "";

            
        }
        private void tboxUserNameSign_Enter(object sender, EventArgs e)
        {

            

            if (tboxUserNameSign.Text.Trim() != "" || tboxUserNameSign.Text != null)
                tboxUserNameSign.Text = "";

        }
        private void tboxPassSign_Enter(object sender, EventArgs e)
        {
            

            if (tboxPassSign.Text.Trim() != "" || tboxPassSign.Text != null)
                tboxPassSign.Text = "";
        }

        //Textbox Leave event
        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text.Trim() == "" || usernameBox.Text == null)
                usernameBox.Text = usernameBox.Tag.ToString();
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text.Trim() == "" || passwordBox.Text == null)
                passwordBox.Text = passwordBox.Tag.ToString();
        }

        private void tboxName_Leave(object sender, EventArgs e)
        {
            if (tboxName.Text.Trim() == "" || tboxName.Text == null)
                tboxName.Text = tboxName.Tag.ToString();
        }

        private void tboxSurName_Leave(object sender, EventArgs e)
        {
            if (tboxSurName.Text.Trim() == "" || tboxSurName.Text == null)
                tboxSurName.Text = tboxSurName.Tag.ToString();
        }

        private void tboxUserNameSign_Leave(object sender, EventArgs e)
        {
            if (tboxUserNameSign.Text.Trim() == "" || tboxUserNameSign.Text == null)
                tboxUserNameSign.Text = tboxUserNameSign.Tag.ToString();
        }

        private void tboxPassSign_Leave(object sender, EventArgs e)
        {
            if (tboxPassSign.Text.Trim() == "" || tboxPassSign.Text == null)
                tboxPassSign.Text = tboxPassSign.Tag.ToString();
        }
    }
}
