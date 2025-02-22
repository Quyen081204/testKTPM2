using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinh_cong_tru_2so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"a-b = {a - b}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"a+b = {a + b}");
        }


    }
}
