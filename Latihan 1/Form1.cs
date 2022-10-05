using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Latihan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNama.Focus();
            txtSop.Visible = false;
            txtRica.Visible = false;
            txtEsTeh.Visible = false;
            txtTotal.ReadOnly = true;
        }

        private void cbSop_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSop.Checked == true){
                txtSop.Visible = true;
                txtSop.Focus();
            } else{
                txtSop.Visible = false;
            }
        } 

        private void cbAyam_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRica.Checked == true){
                txtRica.Visible = true;
                txtRica.Focus();
            } else{
                txtRica.Visible = false;
            }
        }

        private void cbEsTeh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEsTeh.Checked == true)
            {
                txtEsTeh.Visible = true;
                txtEsTeh.Focus();
            }
            else
            {
                txtEsTeh.Visible = false;
            }
        }

        private void btHitung_Click(object sender, EventArgs e)
        {
            double total = 0;
            int sop, rica, teh;
            if (cbSop.Checked) {
                sop = int.Parse(txtSop.Text);
                total = total + 9000 * sop;
            }

            if (cbRica.Checked)
            {
                rica = int.Parse(txtRica.Text);
                total = total + 9000 * rica;
            }

            if (cbEsTeh.Checked)
            {
                teh = int.Parse(txtEsTeh.Text);
                total = total + 9000 * teh;
            }

            if (rbYa.Checked)
            {
                total = total - 0.25 * total;
                txtTotal.Text = total.ToString();
            }

            else
            {
                txtTotal.Text = total.ToString();
            }
        }
    }
}
