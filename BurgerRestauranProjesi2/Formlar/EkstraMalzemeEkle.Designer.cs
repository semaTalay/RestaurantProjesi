namespace BurgerRestauranProjesi2
{
    partial class EkstraMalzemeEkle
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
            grpEkstraEkle = new GroupBox();
            btnEkstraEkle = new Button();
            nmdEkstraAd = new NumericUpDown();
            txtEkstraAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpEkstraEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdEkstraAd).BeginInit();
            SuspendLayout();
            // 
            // grpEkstraEkle
            // 
            grpEkstraEkle.Controls.Add(btnEkstraEkle);
            grpEkstraEkle.Controls.Add(nmdEkstraAd);
            grpEkstraEkle.Controls.Add(txtEkstraAd);
            grpEkstraEkle.Controls.Add(label2);
            grpEkstraEkle.Controls.Add(label1);
            grpEkstraEkle.ForeColor = Color.White;
            grpEkstraEkle.Location = new Point(28, 57);
            grpEkstraEkle.Name = "grpEkstraEkle";
            grpEkstraEkle.Size = new Size(306, 278);
            grpEkstraEkle.TabIndex = 1;
            grpEkstraEkle.TabStop = false;
            grpEkstraEkle.Text = "Ekstra Ekle";
            // 
            // btnEkstraEkle
            // 
            btnEkstraEkle.BackColor = SystemColors.MenuText;
            btnEkstraEkle.Location = new Point(78, 202);
            btnEkstraEkle.Name = "btnEkstraEkle";
            btnEkstraEkle.Size = new Size(127, 49);
            btnEkstraEkle.TabIndex = 4;
            btnEkstraEkle.Text = "Ekstra Ekle";
            btnEkstraEkle.UseVisualStyleBackColor = false;
            btnEkstraEkle.Click += btnEkstraEkle_Click;
            // 
            // nmdEkstraAd
            // 
            nmdEkstraAd.Location = new Point(120, 131);
            nmdEkstraAd.Name = "nmdEkstraAd";
            nmdEkstraAd.Size = new Size(120, 23);
            nmdEkstraAd.TabIndex = 3;
            // 
            // txtEkstraAd
            // 
            txtEkstraAd.Location = new Point(120, 61);
            txtEkstraAd.Name = "txtEkstraAd";
            txtEkstraAd.Size = new Size(100, 23);
            txtEkstraAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 131);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 59);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(372, 375);
            Controls.Add(grpEkstraEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            grpEkstraEkle.ResumeLayout(false);
            grpEkstraEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdEkstraAd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEkstraEkle;
        private Button btnEkstraEkle;
        private NumericUpDown nmdEkstraAd;
        private TextBox txtEkstraAd;
        private Label label2;
        private Label label1;
    }
}