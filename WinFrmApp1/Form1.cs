using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (tbA.Text != String.Empty)
            {
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
                Calculation c = new Calculation(a, b);
                tbKq.Text = c.Execute("+").ToString();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbA.Text);
            int b = int.Parse(tbB.Text);
            Calculation c = new Calculation(a, b);
            tbKq.Text = c.Execute("-").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbA.Text);
            int b = int.Parse(tbB.Text);
            Calculation c = new Calculation(a, b);
            tbKq.Text = c.Execute("*").ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbA.Text);
            int b = int.Parse(tbB.Text);
            Calculation c = new Calculation(a, b);
            if (c.Execute("/") == -1) tbKq.Text = "Lỗi chia 0";
            else tbKq.Text = c.Execute("/").ToString();
        }
    }
}
