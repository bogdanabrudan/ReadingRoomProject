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
using Dapper;

namespace ProiectII_fin
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            txtPass.PasswordChar = '•';
            txtPassconf.PasswordChar = '•';
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new FormLogin()));
            th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
            th.Start();

            this.Close();
        }
        public void ClearAllTxt()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtPassconf.Clear();
            txtEmail.Clear();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                labelError.Text = "Enter A Username.";
            }
            else if (txtPass.Text == "")
            {
                labelError.Text = "Enter A Password.";
            }
            else if (txtPass.Text != txtPassconf.Text)
            {
                labelError.Text = "Your Password And Confirmation Password Must Match.";
            }
            else if (txtEmail.Text == "")
            {
                labelError.Text = "Enter An Email Adress.";
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
                using (SqlConnection myCon = new SqlConnection(connectionString))
                {
                    myCon.Open();

                    bool exists = false;

                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [tblUsers] where Username = @Username", myCon))
                    {
                        cmd.Parameters.AddWithValue("Username", txtUser.Text);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }

                    // if exists, show a message error
                    if (exists)
                        labelError.Text = "This Username Already Exists. Try Another One.";
                    else
                    {
                        // does not exists, so, persist the user
                        OperationsDB obAdd = new OperationsDB();
                        obAdd.AddProfile(txtUser.Text);
                        obAdd.AddUser(txtUser.Text, txtPass.Text, txtEmail.Text);

                        this.tblUsersTableAdapter.Fill(this.readingRoomDataSet.tblUsers);

                        ClearAllTxt();
                        MessageBox.Show("Account Successfully Registered!", "Congratulations");
                        txtUser.Focus();
                        labelError.Text = "";
                        myCon.Close();
                        
                    }
                }
            }
        }

        private void FormRegister_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'readingRoomDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.readingRoomDataSet.tblUsers);
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
