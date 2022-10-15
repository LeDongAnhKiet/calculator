using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (tbA.Text != String.Empty && tbB.Text != String.Empty)
            {
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                double c = a + b;
                tbKq.Text = c.ToString();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbA.Text);
            double b = double.Parse(tbB.Text);
            double c = a - b;
            tbKq.Text = c.ToString();
        }
    }
}
