namespace NotUygulamasi_devamsizlikli
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
            txtVize = new TextBox();
            txtFinal = new TextBox();
            btnDegerlendir = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblOrtalama = new Label();
            lblDurum = new Label();
            chkDevam = new CheckBox();
            SuspendLayout();
            // 
            // txtVize
            // 
            txtVize.Location = new Point(579, 72);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(743, 61);
            txtVize.TabIndex = 1;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(579, 190);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(743, 61);
            txtFinal.TabIndex = 2;
            // 
            // btnDegerlendir
            // 
            btnDegerlendir.Location = new Point(579, 417);
            btnDegerlendir.Name = "btnDegerlendir";
            btnDegerlendir.Size = new Size(372, 92);
            btnDegerlendir.TabIndex = 3;
            btnDegerlendir.Text = "DEĞERLENDİR";
            btnDegerlendir.UseVisualStyleBackColor = true;
            btnDegerlendir.Click += btnDegerlendir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 72);
            label1.Name = "label1";
            label1.Size = new Size(122, 54);
            label1.TabIndex = 4;
            label1.Text = "VİZE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 197);
            label2.Name = "label2";
            label2.Size = new Size(149, 54);
            label2.TabIndex = 5;
            label2.Text = "FİNAL :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 650);
            label4.Name = "label4";
            label4.Size = new Size(247, 54);
            label4.TabIndex = 7;
            label4.Text = "ORTALAMA :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 812);
            label5.Name = "label5";
            label5.Size = new Size(185, 54);
            label5.TabIndex = 8;
            label5.Text = "DURUM :";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(579, 650);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(0, 54);
            lblOrtalama.TabIndex = 9;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(579, 812);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 54);
            lblDurum.TabIndex = 10;
            // 
            // chkDevam
            // 
            chkDevam.AutoSize = true;
            chkDevam.Location = new Point(579, 311);
            chkDevam.Name = "chkDevam";
            chkDevam.Size = new Size(472, 58);
            chkDevam.TabIndex = 11;
            chkDevam.Text = "Devam koşulu sağlandı.";
            chkDevam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1871, 1091);
            Controls.Add(chkDevam);
            Controls.Add(lblDurum);
            Controls.Add(lblOrtalama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDegerlendir);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtVize;
        private TextBox txtFinal;
        private Button btnDegerlendir;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lblOrtalama;
        private Label lblDurum;
        private CheckBox chkDevam;
    }
}
