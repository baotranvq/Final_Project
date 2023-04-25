using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void widget1_Load(object sender, EventArgs e)
        {

        }

        private void widget2_Load(object sender, EventArgs e)
        {

        }

        private void widget3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void widget1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    

        private void btnTong_Click(object sender, EventArgs e)
        {
            double tong;
            if(lblHienThi.Text == button1.Text)
            {
                tong = double.Parse(lblGiab.Text) * double.Parse(txtSL.Text);
                lblKetQua.Text = tong + "đ";
            }
            if (lblHienThi.Text == button2.Text)
            {
                tong = double.Parse(lblgiaA.Text) * double.Parse(txtSL.Text);
                lblKetQua.Text = tong + "đ";
            }
            if (lblHienThi.Text == button3.Text)
            {
                tong = double.Parse(lblGiaC.Text) * double.Parse(txtSL.Text);
                lblKetQua.Text = tong + "đ";
            }
            if (lblHienThi.Text == button7.Text)
            {
                tong = double.Parse(lblGiaD.Text) * double.Parse(txtSL.Text);
                lblKetQua.Text = tong + "đ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "T-Shirt-Green";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lblHienThi.Text = "T-Shirt-Black";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            lblHienThi.Text = "Shorts-Black";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "Shorts-White";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "Baggy-Blue";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
