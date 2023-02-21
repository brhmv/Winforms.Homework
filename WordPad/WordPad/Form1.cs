using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily fontFamily = new FontFamily("Arial");
            FontFamily fontFamily1 = new FontFamily("");
            FontFamily fontFamily2 = new FontFamily("");
            
            if (comboBox_font.SelectedItem.ToString() != null)
            {
                fontFamily = new FontFamily(comboBox_font.SelectedItem.ToString());
            }

            richTextBox1.SelectionFont = new Font(fontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                    return;
                }

                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void comboBox_font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    return;
                }

                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                    return;
                }

                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
