namespace BurgerRestauranProjesi2
{
    partial class SiparisOluştur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOluştur));
            btnSiparisiOnayla = new Button();
            lblToplam = new Label();
            label4 = new Label();
            lstMusteriSecim = new ListBox();
            btnSiparisiEkle = new Button();
            nmdAdet = new NumericUpDown();
            label3 = new Label();
            grpBoy = new GroupBox();
            rdbBuyuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbKucuk = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            cboxMenu = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nmdAdet).BeginInit();
            grpBoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.BackColor = SystemColors.MenuText;
            btnSiparisiOnayla.ForeColor = Color.White;
            btnSiparisiOnayla.Location = new Point(569, 444);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(158, 50);
            btnSiparisiOnayla.TabIndex = 27;
            btnSiparisiOnayla.Text = "Siparişi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = false;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.BackColor = SystemColors.Control;
            lblToplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Red;
            lblToplam.Location = new Point(412, 444);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(41, 21);
            lblToplam.TabIndex = 26;
            lblToplam.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(337, 444);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 25;
            label4.Text = "Toplam";
            // 
            // lstMusteriSecim
            // 
            lstMusteriSecim.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstMusteriSecim.FormattingEnabled = true;
            lstMusteriSecim.Location = new Point(260, 36);
            lstMusteriSecim.Name = "lstMusteriSecim";
            lstMusteriSecim.Size = new Size(516, 394);
            lstMusteriSecim.TabIndex = 24;
            // 
            // btnSiparisiEkle
            // 
            btnSiparisiEkle.BackColor = SystemColors.MenuText;
            btnSiparisiEkle.ForeColor = Color.White;
            btnSiparisiEkle.Location = new Point(43, 460);
            btnSiparisiEkle.Name = "btnSiparisiEkle";
            btnSiparisiEkle.Size = new Size(124, 41);
            btnSiparisiEkle.TabIndex = 23;
            btnSiparisiEkle.Text = "Siparişi Ekle";
            btnSiparisiEkle.UseVisualStyleBackColor = false;
            btnSiparisiEkle.Click += btnSiparisiEkle_Click;
            // 
            // nmdAdet
            // 
            nmdAdet.Location = new Point(86, 425);
            nmdAdet.Name = "nmdAdet";
            nmdAdet.Size = new Size(120, 23);
            nmdAdet.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 427);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 21;
            label3.Text = "Adet";
            // 
            // grpBoy
            // 
            grpBoy.Controls.Add(rdbBuyuk);
            grpBoy.Controls.Add(rdbOrta);
            grpBoy.Controls.Add(rdbKucuk);
            grpBoy.ForeColor = Color.White;
            grpBoy.Location = new Point(25, 369);
            grpBoy.Name = "grpBoy";
            grpBoy.Size = new Size(190, 52);
            grpBoy.TabIndex = 20;
            grpBoy.TabStop = false;
            grpBoy.Text = "Boyu Seçiniz";
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(123, 18);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(58, 19);
            rdbBuyuk.TabIndex = 2;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(69, 18);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(48, 19);
            rdbOrta.TabIndex = 1;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(8, 18);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(58, 19);
            rdbKucuk.TabIndex = 0;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(31, 257);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(136, 97);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 229);
            label2.Name = "label2";
            label2.Size = new Size(143, 17);
            label2.TabIndex = 18;
            label2.Text = "Ekstra Malzeme Seçiniz";
            // 
            // cboxMenu
            // 
            cboxMenu.FormattingEnabled = true;
            cboxMenu.Location = new Point(31, 203);
            cboxMenu.Name = "cboxMenu";
            cboxMenu.Size = new Size(121, 23);
            cboxMenu.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 176);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 16;
            label1.Text = "Menü Seçiniz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // SiparisOluştur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(812, 555);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(lblToplam);
            Controls.Add(label4);
            Controls.Add(lstMusteriSecim);
            Controls.Add(btnSiparisiEkle);
            Controls.Add(nmdAdet);
            Controls.Add(label3);
            Controls.Add(grpBoy);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(cboxMenu);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOluştur";
            Text = "SiparisOluştur";
            Load += SiparisOluştur_Load_1;
            ((System.ComponentModel.ISupportInitialize)nmdAdet).EndInit();
            grpBoy.ResumeLayout(false);
            grpBoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiparisiOnayla;
        private Label lblToplam;
        private Label label4;
        private ListBox lstMusteriSecim;
        private Button btnSiparisiEkle;
        private NumericUpDown nmdAdet;
        private Label label3;
        private GroupBox grpBoy;
        private RadioButton rdbBuyuk;
        private RadioButton rdbOrta;
        private RadioButton rdbKucuk;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ComboBox cboxMenu;
        private Label label1;
        private PictureBox pictureBox1;
    }
}