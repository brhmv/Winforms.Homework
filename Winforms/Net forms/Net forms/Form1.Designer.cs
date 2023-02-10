namespace Net_forms
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
            this.components = new System.ComponentModel.Container();
            this.btn_Baku = new System.Windows.Forms.Button();
            this.btn_London = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Baku
            // 
            this.btn_Baku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Baku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baku.Location = new System.Drawing.Point(184, 49);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(158, 44);
            this.btn_Baku.TabIndex = 0;
            this.btn_Baku.Text = "B A K U";
            this.btn_Baku.UseVisualStyleBackColor = false;
            this.btn_Baku.Click += new System.EventHandler(this.btn_Baku_Click);
            // 
            // btn_London
            // 
            this.btn_London.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_London.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_London.Location = new System.Drawing.Point(507, 49);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(158, 44);
            this.btn_London.TabIndex = 1;
            this.btn_London.Text = "L O N D O N";
            this.btn_London.UseVisualStyleBackColor = false;
            this.btn_London.Click += new System.EventHandler(this.btn_London_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Cyan;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(29, 469);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(81, 32);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Net_forms.Properties.Resources.Baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 535);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.btn_Baku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Baku;
        private System.Windows.Forms.Button btn_London;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
    }
}

