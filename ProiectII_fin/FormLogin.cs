using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII_fin
{
    public partial class FormLogin : Form
    {
        private bool pwvis = false;
        public FormLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
            defaultPw();
            defaultUs();
            label1.Select();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Type Your Username")
            {
                txtUsername.BackColor = Color.White;
                txtUsername.ForeColor = Color.RoyalBlue;
                txtUsername.ReadOnly = false;
                txtUsername.Text = "";
            }
        }

        public void defaultUs()
        {
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Gray;
            txtUsername.ReadOnly = true;
            txtUsername.Text = "Type Your Username";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                defaultUs();
            }
        }

        public void defaultPw()
        {
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Gray;
            txtPassword.ReadOnly = true;
            txtPassword.Text = "Type Your Password";
            txtPassword.PasswordChar = '\0';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                defaultPw();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Type Your Password")
            {
                txtPassword.BackColor = Color.White;
                txtPassword.ForeColor = Color.RoyalBlue;
                txtPassword.ReadOnly = false;
                txtPassword.Text = "";
                txtPassword.PasswordChar = '•';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new FormRegister()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void iconShowPW_MouseClick(object sender, MouseEventArgs e)
        {
            pwvis = !(pwvis);
            if (pwvis == true)
            {
                iconShowPW.Image = Image.FromFile("C:/Users/bogda/OneDrive/Desktop/Pt II/Eye-Icon.png");
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                iconShowPW.Image = Image.FromFile("C:/Users/bogda/OneDrive/Desktop/Pt II/eyecrossed.png");
                if (txtPassword.Text != "Type Your Password")
                    txtPassword.PasswordChar = '•';
            }
        }

        private void FormLogin_Click(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                SqlDataReader dr;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                cmd = new SqlCommand();
                bool isAdmin;
                OperationsDB obAdmin = new OperationsDB();
                isAdmin = obAdmin.IsAdmin(username);
                myCon.Open();
                cmd.Connection = myCon;
                cmd.CommandText = "SELECT * FROM tblUsers where Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    int id = obAdmin.GetUserId(username);
                    var th = new Thread(() => Application.Run(new FormHome(id)));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                    this.Close();
                }
                else
                {
                    labelError.Text="Invalid Login please check username and password.";
                    labelError.ForeColor = Color.Red;
                }
                myCon.Close();   
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
