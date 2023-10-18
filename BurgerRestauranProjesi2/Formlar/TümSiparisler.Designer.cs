namespace BurgerRestauranProjesi2
{
    partial class TümSiparisler
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
            lblSatılanUrunAdedi = new Label();
            label6 = new Label();
            lblEkstraMalzemeGeliri = new Label();
            label3 = new Label();
            lblToplamSiparis = new Label();
            label4 = new Label();
            lblCiro = new Label();
            label2 = new Label();
            lstAlinanTumSiparisler = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSatılanUrunAdedi
            // 
            lblSatılanUrunAdedi.AutoSize = true;
            lblSatılanUrunAdedi.BorderStyle = BorderStyle.FixedSingle;
            lblSatılanUrunAdedi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSatılanUrunAdedi.ForeColor = Color.Red;
            lblSatılanUrunAdedi.Location = new Point(610, 390);
            lblSatılanUrunAdedi.Name = "lblSatılanUrunAdedi";
            lblSatılanUrunAdedi.Size = new Size(2, 23);
            lblSatılanUrunAdedi.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(599, 355);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 18;
            label6.Text = "Satılan Ürün Adedi";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.BorderStyle = BorderStyle.FixedSingle;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(610, 290);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(2, 23);
            lblEkstraMalzemeGeliri.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(599, 256);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 16;
            label3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.BorderStyle = BorderStyle.FixedSingle;
            lblToplamSiparis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(610, 174);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(2, 23);
            lblToplamSiparis.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(599, 136);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 14;
            label4.Text = "Toplam Sipariş";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.BorderStyle = BorderStyle.FixedSingle;
            lblCiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(610, 86);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(2, 23);
            lblCiro.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(592, 49);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 12;
            label2.Text = "Ciro";
            // 
            // lstAlinanTumSiparisler
            // 
            lstAlinanTumSiparisler.FormattingEnabled = true;
            lstAlinanTumSiparisler.ItemHeight = 15;
            lstAlinanTumSiparisler.Location = new Point(37, 100);
            lstAlinanTumSiparisler.Name = "lstAlinanTumSiparisler";
            lstAlinanTumSiparisler.Size = new Size(498, 304);
            lstAlinanTumSiparisler.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 10;
            label1.Text = "Alınan Tüm Siparişler";
            // 
            // TümSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(755, 450);
            Controls.Add(lblSatılanUrunAdedi);
            Controls.Add(label6);
            Controls.Add(lblEkstraMalzemeGeliri);
            Controls.Add(label3);
            Controls.Add(lblToplamSiparis);
            Controls.Add(label4);
            Controls.Add(lblCiro);
            Controls.Add(label2);
            Controls.Add(lstAlinanTumSiparisler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TümSiparisler";
            Text = "TümSiparisler";
            Load += TümSiparisler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSatılanUrunAdedi;
        private Label label6;
        private Label lblEkstraMalzemeGeliri;
        private Label label3;
        private Label lblToplamSiparis;
        private Label label4;
        private Label lblCiro;
        private Label label2;
        private ListBox lstAlinanTumSiparisler;
        private Label label1;
    }
}