using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Net_forms
{
    public partial class Form1 : Form
    {
        public Bitmap Baku = Properties.Resources.Baku;
        public Bitmap London = Properties.Resources.London;

        public Form1()
        {
            InitializeComponent();
            BackgroundImage = Baku;
            BackgroundImageLayout = ImageLayout.Stretch;
            Form1_Load(this, new EventArgs());
        }

        bool status = true;

        private void btn_Baku_Click(object sender, EventArgs e)
        {
            status = true;
            BackgroundImage = Baku;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_London_Click(object sender, EventArgs e)
        {
            status = false;
            BackgroundImage = London;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += (s,w) => lbl_time.Text = status ? DateTime.Now.ToLongTimeString() : DateTime.UtcNow.ToLongTimeString();
        }
    }
}
