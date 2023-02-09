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
            this.btn_Baku = new System.Windows.Forms.Button();
            this.btn_London = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 535);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.btn_Baku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baku;
        private System.Windows.Forms.Button btn_London;
    }
}

