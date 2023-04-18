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
    public partial class FormMyRes : Form
    {
        int uid;
        public FormMyRes(int id)
        {
            uid = id;
            InitializeComponent();
            showbooks();
            showseats();
        }
        public void showbooks()
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                using (DataTable dt = new DataTable("RentedBook"))
                {
                    using (SqlCommand cmd = new SqlCommand("select S.SeatId,S.Room from tblSeats S inner join tblResSeats R on S.SeatId = R.SeatId where R.UserId = @id", myCon))
                    {
                        cmd.Parameters.AddWithValue("id",uid);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
        }
        public void showseats()
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                using (DataTable dt = new DataTable("ReservedSeat"))
                {
                    using (SqlCommand cmd = new SqlCommand("select B.Name, B.Author from tblBooks B inner join tblRentedBooks R on B.BooksId = R.BooksId where R.UserId = @id", myCon))
                    {
                        cmd.Parameters.AddWithValue("id", uid);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
    }
}
