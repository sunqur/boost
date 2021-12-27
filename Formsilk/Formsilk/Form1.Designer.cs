namespace Formsilk
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
            this.btnIslem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.toplam = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(12, 382);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(116, 56);
            this.btnIslem.TabIndex = 0;
            this.btnIslem.Text = "FORM 2YE GİT";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "sayı 2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(141, 41);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(142, 85);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi2.TabIndex = 4;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(320, 65);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 5;
            // 
            // toplam
            // 
            this.toplam.Location = new System.Drawing.Point(142, 128);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(75, 23);
            this.toplam.TabIndex = 6;
            this.toplam.Text = "toplam";
            this.toplam.UseVisualStyleBackColor = true;
            this.toplam.Click += new System.EventHandler(this.toplam_Click);
            // 
            // cikar
            // 
            this.cikar.Location = new System.Drawing.Point(223, 128);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(75, 23);
            this.cikar.TabIndex = 7;
            this.cikar.Text = "-";
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.Click += new System.EventHandler(this.cikar_Click_1);
            // 
            // carp
            // 
            this.carp.Location = new System.Drawing.Point(333, 128);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(75, 23);
            this.carp.TabIndex = 8;
            this.carp.Text = "*";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Click += new System.EventHandler(this.carp_Click_1);
            // 
            // bol
            // 
            this.bol.Location = new System.Drawing.Point(435, 128);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(75, 23);
            this.bol.TabIndex = 9;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = true;
            this.bol.Click += new System.EventHandler(this.bol_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIslem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button toplam;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button bol;
    }
}

