using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII_fin
{
    public partial class FormReserveSeat : Form
    {
        public int sid;
        public int uid;
        public FormReserveSeat(int id)
        {
            InitializeComponent();
            uid = id;
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton1.Text;
            sid = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton2.Text;
            sid = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton3.Text;
            sid = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton4.Text;
            sid = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton5.Text;
            sid = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton6.Text;
            sid = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton7.Text;
            sid = 7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton8.Text;
            sid = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton9.Text;
            sid = 9;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton10.Text;
            sid = 10;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton20.Text;
            sid = 20;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton19.Text;
            sid = 19;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton18.Text;
            sid = 18;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton17.Text;
            sid = 17;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton16.Text;
            sid = 16;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton15.Text;
            sid = 15;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton14.Text;
            sid = 14;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton13.Text;
            sid = 13;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton12.Text;
            sid = 12;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton11.Text;
            sid = 11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationsDB Res = new OperationsDB();
            if (Res.SeatIsRes(sid) == true)
            {
                MessageBox.Show("Sorry this seat is already taken.");
            }
            else
            {
                Res.AddResSeat(sid, uid);
                Res.UpdateSeat(sid);
                MessageBox.Show("Good news! You successfully reserved this seat.");
            }
        }
    }
}
