namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox_font = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.btn_bold = new System.Windows.Forms.Button();
            this.btn_italic = new System.Windows.Forms.Button();
            this.btn_underline = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.textbox_load = new System.Windows.Forms.TextBox();
            this.txtbox_save = new System.Windows.Forms.TextBox();
            this.lbl_font = new System.Windows.Forms.Label();
            this.lbl_fontstyle = new System.Windows.Forms.Label();
            this.lbl_alignment = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.btn_right = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(-2, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1192, 606);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox_font
            // 
            this.comboBox_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_font.FormattingEnabled = true;
            this.comboBox_font.Location = new System.Drawing.Point(51, 57);
            this.comboBox_font.Name = "comboBox_font";
            this.comboBox_font.Size = new System.Drawing.Size(121, 33);
            this.comboBox_font.TabIndex = 2;
            this.comboBox_font.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox_font.Click += new System.EventHandler(this.comboBox_font_Click);
            // 
            // comboBox_color
            // 
            this.comboBox_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(619, 58);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 33);
            this.comboBox_color.TabIndex = 2;
            this.comboBox_color.MouseHover += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);
            // 
            // btn_bold
            // 
            this.btn_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bold.Location = new System.Drawing.Point(267, 59);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(41, 31);
            this.btn_bold.TabIndex = 3;
            this.btn_bold.Text = "B";
            this.btn_bold.UseVisualStyleBackColor = true;
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // btn_italic
            // 
            this.btn_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_italic.Location = new System.Drawing.Point(364, 59);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(42, 31);
            this.btn_italic.TabIndex = 3;
            this.btn_italic.Text = "I";
            this.btn_italic.UseVisualStyleBackColor = true;
            this.btn_italic.Click += new System.EventHandler(this.btn_italic_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_underline.Location = new System.Drawing.Point(314, 59);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(44, 31);
            this.btn_underline.TabIndex = 3;
            this.btn_underline.Text = "U";
            this.btn_underline.UseVisualStyleBackColor = true;
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left.Location = new System.Drawing.Point(440, 59);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(42, 31);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "L";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_center
            // 
            this.btn_center.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_center.Location = new System.Drawing.Point(488, 59);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(40, 31);
            this.btn_center.TabIndex = 3;
            this.btn_center.Text = "C";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(1068, 18);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(82, 30);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1068, 60);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 30);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textbox_load
            // 
            this.textbox_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_load.Location = new System.Drawing.Point(816, 18);
            this.textbox_load.Name = "textbox_load";
            this.textbox_load.Size = new System.Drawing.Size(234, 30);
            this.textbox_load.TabIndex = 4;
            // 
            // txtbox_save
            // 
            this.txtbox_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_save.Location = new System.Drawing.Point(816, 60);
            this.txtbox_save.Name = "txtbox_save";
            this.txtbox_save.Size = new System.Drawing.Size(234, 30);
            this.txtbox_save.TabIndex = 4;
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_font.Location = new System.Drawing.Point(65, 18);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(96, 25);
            this.lbl_font.TabIndex = 5;
            this.lbl_font.Text = "Font edit";
            // 
            // lbl_fontstyle
            // 
            this.lbl_fontstyle.AutoSize = true;
            this.lbl_fontstyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fontstyle.Location = new System.Drawing.Point(287, 15);
            this.lbl_fontstyle.Name = "lbl_fontstyle";
            this.lbl_fontstyle.Size = new System.Drawing.Size(100, 25);
            this.lbl_fontstyle.TabIndex = 5;
            this.lbl_fontstyle.Text = "Fontstyle";
            // 
            // lbl_alignment
            // 
            this.lbl_alignment.AutoSize = true;
            this.lbl_alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alignment.Location = new System.Drawing.Point(455, 15);
            this.lbl_alignment.Name = "lbl_alignment";
            this.lbl_alignment.Size = new System.Drawing.Size(108, 25);
            this.lbl_alignment.TabIndex = 5;
            this.lbl_alignment.Text = "Alignment";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(642, 15);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(64, 25);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color";
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right.Location = new System.Drawing.Point(534, 59);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(42, 31);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "R";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 719);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_alignment);
            this.Controls.Add(this.lbl_fontstyle);
            this.Controls.Add(this.lbl_font);
            this.Controls.Add(this.txtbox_save);
            this.Controls.Add(this.textbox_load);
            this.Controls.Add(this.btn_underline);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_center);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_italic);
            this.Controls.Add(this.btn_bold);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_font);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox_font;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Button btn_bold;
        private System.Windows.Forms.Button btn_italic;
        private System.Windows.Forms.Button btn_underline;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textbox_load;
        private System.Windows.Forms.TextBox txtbox_save;
        private System.Windows.Forms.Label lbl_font;
        private System.Windows.Forms.Label lbl_fontstyle;
        private System.Windows.Forms.Label lbl_alignment;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
    }
}

