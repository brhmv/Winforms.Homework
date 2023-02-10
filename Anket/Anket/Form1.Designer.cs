namespace Anket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_Father = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_surname = new System.Windows.Forms.TextBox();
            this.txtbox_father = new System.Windows.Forms.TextBox();
            this.txtbox_country = new System.Windows.Forms.TextBox();
            this.txtbox_city = new System.Windows.Forms.TextBox();
            this.txtbox_phone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdbtn_male = new System.Windows.Forms.RadioButton();
            this.rdbtn_female = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(60, 106);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 21);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(60, 147);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(78, 21);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname";
            // 
            // lbl_Father
            // 
            this.lbl_Father.AutoSize = true;
            this.lbl_Father.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Father.Location = new System.Drawing.Point(60, 186);
            this.lbl_Father.Name = "lbl_Father";
            this.lbl_Father.Size = new System.Drawing.Size(58, 21);
            this.lbl_Father.TabIndex = 1;
            this.lbl_Father.Text = "Father";
            this.lbl_Father.Click += new System.EventHandler(this.lbl_Father_Click);
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.Location = new System.Drawing.Point(60, 254);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(72, 21);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "Country";
            this.lbl_country.Click += new System.EventHandler(this.lbl_country_Click);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_city.Location = new System.Drawing.Point(60, 299);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(40, 21);
            this.lbl_city.TabIndex = 1;
            this.lbl_city.Text = "City";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.Location = new System.Drawing.Point(60, 339);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(59, 21);
            this.lbl_phone.TabIndex = 1;
            this.lbl_phone.Text = "Phone";
            this.lbl_phone.Click += new System.EventHandler(this.lbl_phone_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(60, 399);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(87, 21);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Birth Date";
            this.lbl_Date.Click += new System.EventHandler(this.lbl_phone_Click);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.Location = new System.Drawing.Point(60, 461);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(70, 21);
            this.lbl_gender.TabIndex = 1;
            this.lbl_gender.Text = "Gender:";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_phone_Click);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(189, 106);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(200, 23);
            this.txtbox_name.TabIndex = 2;
            // 
            // txtbox_surname
            // 
            this.txtbox_surname.Location = new System.Drawing.Point(189, 149);
            this.txtbox_surname.Name = "txtbox_surname";
            this.txtbox_surname.Size = new System.Drawing.Size(200, 23);
            this.txtbox_surname.TabIndex = 2;
            // 
            // txtbox_father
            // 
            this.txtbox_father.Location = new System.Drawing.Point(189, 184);
            this.txtbox_father.Name = "txtbox_father";
            this.txtbox_father.Size = new System.Drawing.Size(200, 23);
            this.txtbox_father.TabIndex = 2;
            this.txtbox_father.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbox_country
            // 
            this.txtbox_country.Location = new System.Drawing.Point(189, 254);
            this.txtbox_country.Name = "txtbox_country";
            this.txtbox_country.Size = new System.Drawing.Size(200, 23);
            this.txtbox_country.TabIndex = 2;
            this.txtbox_country.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbox_city
            // 
            this.txtbox_city.Location = new System.Drawing.Point(189, 297);
            this.txtbox_city.Name = "txtbox_city";
            this.txtbox_city.Size = new System.Drawing.Size(200, 23);
            this.txtbox_city.TabIndex = 2;
            this.txtbox_city.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbox_phone
            // 
            this.txtbox_phone.Location = new System.Drawing.Point(189, 337);
            this.txtbox_phone.Name = "txtbox_phone";
            this.txtbox_phone.Size = new System.Drawing.Size(200, 23);
            this.txtbox_phone.TabIndex = 2;
            this.txtbox_phone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 399);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // rdbtn_male
            // 
            this.rdbtn_male.AutoSize = true;
            this.rdbtn_male.Location = new System.Drawing.Point(202, 463);
            this.rdbtn_male.Name = "rdbtn_male";
            this.rdbtn_male.Size = new System.Drawing.Size(51, 19);
            this.rdbtn_male.TabIndex = 4;
            this.rdbtn_male.TabStop = true;
            this.rdbtn_male.Text = "Male";
            this.rdbtn_male.UseVisualStyleBackColor = true;
            // 
            // rdbtn_female
            // 
            this.rdbtn_female.AutoSize = true;
            this.rdbtn_female.Location = new System.Drawing.Point(294, 464);
            this.rdbtn_female.Name = "rdbtn_female";
            this.rdbtn_female.Size = new System.Drawing.Size(63, 19);
            this.rdbtn_female.TabIndex = 4;
            this.rdbtn_female.TabStop = true;
            this.rdbtn_female.Text = "Female";
            this.rdbtn_female.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(235, 515);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 31);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_load
            // 
            this.btn_load.AutoSize = true;
            this.btn_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_load.Location = new System.Drawing.Point(328, 26);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(61, 31);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_search.Location = new System.Drawing.Point(60, 29);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(61, 21);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "Search";
            this.lbl_search.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 589);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdbtn_female);
            this.Controls.Add(this.rdbtn_male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbox_phone);
            this.Controls.Add(this.txtbox_city);
            this.Controls.Add(this.txtbox_country);
            this.Controls.Add(this.txtbox_father);
            this.Controls.Add(this.txtbox_surname);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_Father);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_name);
            this.MaximumSize = new System.Drawing.Size(509, 628);
            this.MinimumSize = new System.Drawing.Size(509, 628);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private Label lbl_surname;
        private Label lbl_Father;
        private Label lbl_country;
        private Label lbl_city;
        private Label lbl_phone;
        private Label lbl_Date;
        private Label lbl_gender;
        private TextBox txtbox_name;
        private TextBox txtbox_surname;
        private TextBox txtbox_father;
        private TextBox txtbox_country;
        private TextBox txtbox_city;
        private TextBox txtbox_phone;
        private DateTimePicker dateTimePicker1;
        private RadioButton rdbtn_male;
        private RadioButton rdbtn_female;
        private TextBox textBox1;
        private Button btn_save;
        private Button btn_load;
        private Label lbl_search;
    }
}