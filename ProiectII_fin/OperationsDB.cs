using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ProiectII_fin
{
    public class OperationsDB
    {
        public void AddProfile(string username)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {

                List<Profile> obProfiles = new List<Profile>();

                obProfiles.Add(new Profile
                {
                    Username = username
                });

                myCon.Execute("AddProfile @Username", obProfiles);
                myCon.Close();

            }
        }
        public void AddUser(string username, string password, string email)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {

                List<Users> obUsers = new List<Users>();

                obUsers.Add(new Users
                {
                    Username = username,
                    Password = password,
                    Email = email
                });

                myCon.Execute("AddUser @Username, @Password, @Email", obUsers);
                myCon.Close();

            }
        }
        public void UpdateProfile(string username, string name, string phone, string univ)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                List<Profile> obProfile = new List<Profile>();

                obProfile.Add(new Profile
                {
                    Username = username,
                    Name = name,
                    Phone = phone,
                    Univ = univ
                });

                myCon.Execute("UpdateProfile @Username, @Name, @Phone, @Univ", obProfile);
                myCon.Close();
            }
        }
        public void UpdateUser(string username, string password, string email)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                List<Users> obUsers = new List<Users>();

                obUsers.Add(new Users
                {
                    Username = username,
                    Password = password,
                    Email = email
                });

                myCon.Execute("UpdateUser @Username, @Password, @Email", obUsers);
                myCon.Close();

            }
        }
        public bool IsAdmin(string username)
        {
            bool exists = false;
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();
                using (SqlCommand cmd = new SqlCommand("set @isAdmin = 1; select count(*) From[ReadingRoom].[dbo].[tblUsers] where Username = @username And IsAdmin = @isAdmin", myCon))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("isAdmin", 1);
                    exists = (int)cmd.ExecuteScalar() > 0;
                }
            }
            return exists;
        }

        public void UpdateBooks(int id)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblBooks; UPDATE tblBooks SET IsRented=@isRented WHERE BooksId=@Id", myCon);
                myCon.Open();
                command.Parameters.AddWithValue("@isRented", 1);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                myCon.Close();
            }
        }
        public bool BookIsRented(int id)
        {
            bool isrented = false;
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();
                using (SqlCommand cmd = new SqlCommand("select count(*) From[ReadingRoom].[dbo].[tblBooks] where BooksId = @id And IsRented = @isrented", myCon))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("isrented", 1);
                    isrented = (int)cmd.ExecuteScalar() > 0;
                }
            }
            return isrented;
        }

        public void UpdateSeat(int id)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblSeats; UPDATE tblSeats SET IsReserved=@isres WHERE SeatId=@Id", myCon);
                myCon.Open();
                command.Parameters.AddWithValue("@isres", 1);
                command.Parameters.AddWithValue("@Id", id);
                
                command.ExecuteNonQuery();
                myCon.Close();
            }
        }

        public bool SeatIsRes(int id)
        {
            bool isrented = false;
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();
                using (SqlCommand cmd = new SqlCommand("select count(*) From[ReadingRoom].[dbo].[tblSeats] where SteatId = @id And IsReserved = @isres", myCon))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("isres", 1);
                }
            }
            return isrented;
        }

        public void AddResSeat(int seatId, int userId)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Insert into tblResSeats (SeatId,UserId) values(@SeatId, @UserId);", myCon);
                myCon.Open();
                command.Parameters.AddWithValue("@SeatId", seatId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.ExecuteNonQuery();
                myCon.Close();
            }
        }

        public void AddRentBook(int bookId, int userId)
        {
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Insert into tblRentedBooks (BooksId,UserId) values(@BooksId, @UserId);", myCon);
                myCon.Open();
                command.Parameters.AddWithValue("@BooksId", bookId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.ExecuteNonQuery();
                myCon.Close();
            }
        }
        public int GetUserId(string username)
        {
            int id;
            string connectionString = @"Data Source=DESKTOP-7S6PTPM\SQLEXPRESS;Initial Catalog = ReadingRoom; Integrated Security = True;";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select Id from [ReadingRoom].[dbo].[tblUsers] where Username = @username ", myCon);
                myCon.Open();
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
                id = (int)command.ExecuteScalar();
                myCon.Close();
                return id;
            }
        }
    }
}