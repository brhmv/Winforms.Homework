using System;
using System.Drawing;
using System.Windows.Forms;

namespace Net_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_uncatchable_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            Point point = new Point(int.Parse(random.Next(400).ToString()),
            int.Parse(random.Next(250).ToString()));
            btn_uncatchable.Location = point;
        }

        private void btn_uncatchable_Click(object sender, EventArgs e)
        {
            btn_uncatchable.Text = "You Won";
        }
    }
}
