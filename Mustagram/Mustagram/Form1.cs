using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;




namespace Mustagram
{

    public partial class Form1 : Form
    {

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            // this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15)); //play with these values till you are happy
            pictureBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Idbox_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "아이디")
            {
                txtId.Enabled = true;
                txtId.Focus();
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        private void Idbox_Click(object sender, EventArgs e)
        {
            Idbox_Enter(sender, e);
        }

        private void Idbox_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                txtId.Text = "아이디";
                txtId.ForeColor = Color.Gray;
            }
        }

        private void passwordbox_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("DSsd");
            if (txtPassword.Text == "비밀번호")
            {
                txtPassword.Enabled = true;
                txtPassword.Focus();
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void passwordbox_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "비밀번호";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (form2.IsDisposed) // 컨트롤이 죽었으면
            {
                form2 = new Form2(); // 다시 인스턴스생성하고 열어줍니다
                form2.Show();
            }
            else
            {
                form2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            form2.Left += 10;
            if (form2.Left >= 1000)
            {
                timer1.Stop();
                this.TopMost = false;
                form2.TopMost = true;
                timer2.Start();
            }
            timer1.Interval = 10;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            form2.Left -= 10;
            if (form2.Left <= this.Left)
            {
                timer2.Stop();
            }
            timer2.Interval = 10;
        }

        
    }
}




