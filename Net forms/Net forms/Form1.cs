using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(@"C:\Users\user\OneDrive\Desktop\Baku.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Baku_Click(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(@"C:\Users\user\OneDrive\Desktop\Baku.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_London_Click(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(@"C:\Users\user\OneDrive\Desktop\London.jpeg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
