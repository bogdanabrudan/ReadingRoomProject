using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII_fin
{
    public partial class FormRentBook : Form
    {
        int id;
        int Uid;
        public FormRentBook(int userId)
        {
            InitializeComponent();
            Uid = userId;
        }
        public void Search2()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
                using (SqlConnection myCon = new SqlConnection(connectionString))
                {
                    if (myCon.State == ConnectionState.Closed)
                        myCon.Open();

                    using (DataTable dt = new DataTable("RentedBook"))
                    {
                        if (byAuthor.Checked == true)
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblBooks WHERE Author = @Author", myCon))
                            {
                                cmd.Parameters.AddWithValue("Author", txtName.Text);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;

                            }
                        }
                        else if (byName.Checked == true)
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblBooks WHERE Name = @Name", myCon))
                            {
                                cmd.Parameters.AddWithValue("Name", txtName.Text);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                               
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search2();
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            OperationsDB Rent = new OperationsDB();
            if (Rent.BookIsRented(id) == true)
            {
                MessageBox.Show("Sorry this book is rented by someone.");
            }
            else
            {
                Rent.AddRentBook(id,Uid);
                Rent.UpdateBooks(id);
                MessageBox.Show("Good news! You successfully rented this book.");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cell = dataGridView1.CurrentRow.Cells;
            id = Convert.ToInt32(cell[0].Value.ToString());
            textBoxID.Text = id.ToString();
            textBoxName.Text = cell[1].Value.ToString();
            textBoxAuthor.Text = cell[2].Value.ToString();
            textBoxYear.Text = cell[3].Value.ToString();
            textBoxPublisher.Text = cell[4].Value.ToString();

        }
    }
}
