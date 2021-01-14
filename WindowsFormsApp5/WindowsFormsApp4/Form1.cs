using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你喜歡豬");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你喜歡鳥");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你喜歡狗");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你喜歡貓");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
