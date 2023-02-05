using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 gg=new Form5();
            gg.TopLevel = false;
            pnlmain.Controls.Add(gg);
            gg.BringToFront();
            gg.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Form3 fg = new Form3();
            fg.TopLevel = false;
            pnlmain.Controls.Add(fg);
            fg.BringToFront();
            fg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 hh=new Form6();
            hh.TopLevel = false;
            pnlmain.Controls.Add(hh);
            hh.BringToFront();
            hh.Show();
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            Form7 jj = new Form7();
            jj.TopLevel = false;
            pnlmain.Controls.Add(jj);   
            jj.BringToFront();
                jj.Show();
        }
    }
}
