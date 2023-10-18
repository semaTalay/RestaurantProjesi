namespace BurgerRestauranProjesi2
{
    partial class MenuEkle
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
            grpMenuEkle = new GroupBox();
            nmdMenuFiyat = new NumericUpDown();
            txtMenuAd = new TextBox();
            label3 = new Label();
            btnMenuEkle = new Button();
            label2 = new Label();
            grpMenuEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // grpMenuEkle
            // 
            grpMenuEkle.Controls.Add(nmdMenuFiyat);
            grpMenuEkle.Controls.Add(txtMenuAd);
            grpMenuEkle.Controls.Add(label3);
            grpMenuEkle.Controls.Add(btnMenuEkle);
            grpMenuEkle.Controls.Add(label2);
            grpMenuEkle.ForeColor = Color.White;
            grpMenuEkle.Location = new Point(31, 66);
            grpMenuEkle.Name = "grpMenuEkle";
            grpMenuEkle.Size = new Size(280, 260);
            grpMenuEkle.TabIndex = 1;
            grpMenuEkle.TabStop = false;
            grpMenuEkle.Text = "Menü Ekle";
            // 
            // nmdMenuFiyat
            // 
            nmdMenuFiyat.Location = new Point(106, 106);
            nmdMenuFiyat.Name = "nmdMenuFiyat";
            nmdMenuFiyat.Size = new Size(120, 23);
            nmdMenuFiyat.TabIndex = 10;
            // 
            // txtMenuAd
            // 
            txtMenuAd.Location = new Point(106, 44);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(100, 23);
            txtMenuAd.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 108);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 8;
            label3.Text = "Fiyat";
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.BackColor = SystemColors.MenuText;
            btnMenuEkle.Location = new Point(106, 189);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(126, 48);
            btnMenuEkle.TabIndex = 7;
            btnMenuEkle.Text = "Ekle";
            btnMenuEkle.UseVisualStyleBackColor = false;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 46);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 6;
            label2.Text = "Ad";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(385, 379);
            Controls.Add(grpMenuEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "MenuEkle";
            grpMenuEkle.ResumeLayout(false);
            grpMenuEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMenuEkle;
        private NumericUpDown nmdMenuFiyat;
        private TextBox txtMenuAd;
        private Label label3;
        private Button btnMenuEkle;
        private Label label2;
    }
}