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

namespace ProiectII_fin
{
    public partial class FormHome : Form
    {
        public int uid;
        public FormHome(int userId)
        {
            InitializeComponent();
            uid = userId;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //labelMyProfile.Font = new Font(labelMyProfile.Font.Name, labelMyProfile.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            //labelMyProfile.Font = new Font(labelMyProfile.Font.Name, labelMyProfile.Font.SizeInPoints, FontStyle.Regular);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            FormRentBook Frent = new FormRentBook(uid);
            Frent.Show();
        }

        private void buttonReserv_Click(object sender, EventArgs e)
        {
            FormReserveSeat Fres = new FormReserveSeat(uid);
            Fres.Show();
        }

        private void buttonMyRes_Click(object sender, EventArgs e)
        {
            FormMyRes Fmyres = new FormMyRes(uid);
            Fmyres.Show();
        }

        private void labelMyProfile_Click(object sender, EventArgs e)
        {
            //FormProfile Fmypr = new FormProfile(uid);
            //Fmypr.Show();
        }

        private void buttonSignout_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new FormLogin()));
            th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
            th.Start();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
