
namespace WindowsFormsApp1
{
    partial class HastaPaneli
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
            this.nabız = new System.Windows.Forms.TextBox();
            this.buyukTansiyon = new System.Windows.Forms.TextBox();
            this.kucukTansiyon = new System.Windows.Forms.TextBox();
            this.vucutSıcaklıgı = new System.Windows.Forms.TextBox();
            this.nabızLabel = new System.Windows.Forms.Label();
            this.buyukTansiyonLabel = new System.Windows.Forms.Label();
            this.kucukTansiyonLabel = new System.Windows.Forms.Label();
            this.vucutSıcaklığıLabel = new System.Windows.Forms.Label();
            this.biglileriGuncelleButonu = new System.Windows.Forms.Button();
            this.hastaIDAcıklamaLabel = new System.Windows.Forms.Label();
            this.hastaIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nabız
            // 
            this.nabız.Location = new System.Drawing.Point(219, 147);
            this.nabız.Name = "nabız";
            this.nabız.Size = new System.Drawing.Size(100, 20);
            this.nabız.TabIndex = 0;
            // 
            // buyukTansiyon
            // 
            this.buyukTansiyon.Location = new System.Drawing.Point(219, 185);
            this.buyukTansiyon.Name = "buyukTansiyon";
            this.buyukTansiyon.Size = new System.Drawing.Size(100, 20);
            this.buyukTansiyon.TabIndex = 1;
            // 
            // kucukTansiyon
            // 
            this.kucukTansiyon.Location = new System.Drawing.Point(219, 223);
            this.kucukTansiyon.Name = "kucukTansiyon";
            this.kucukTansiyon.Size = new System.Drawing.Size(100, 20);
            this.kucukTansiyon.TabIndex = 2;
            // 
            // vucutSıcaklıgı
            // 
            this.vucutSıcaklıgı.Location = new System.Drawing.Point(219, 263);
            this.vucutSıcaklıgı.Name = "vucutSıcaklıgı";
            this.vucutSıcaklıgı.Size = new System.Drawing.Size(100, 20);
            this.vucutSıcaklıgı.TabIndex = 3;
            // 
            // nabızLabel
            // 
            this.nabızLabel.AutoSize = true;
            this.nabızLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nabızLabel.Location = new System.Drawing.Point(165, 148);
            this.nabızLabel.Name = "nabızLabel";
            this.nabızLabel.Size = new System.Drawing.Size(48, 17);
            this.nabızLabel.TabIndex = 4;
            this.nabızLabel.Text = "Nabız:";
            // 
            // buyukTansiyonLabel
            // 
            this.buyukTansiyonLabel.AutoSize = true;
            this.buyukTansiyonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buyukTansiyonLabel.Location = new System.Drawing.Point(100, 185);
            this.buyukTansiyonLabel.Name = "buyukTansiyonLabel";
            this.buyukTansiyonLabel.Size = new System.Drawing.Size(113, 17);
            this.buyukTansiyonLabel.TabIndex = 5;
            this.buyukTansiyonLabel.Text = "Büyük Tansiyon:";
            // 
            // kucukTansiyonLabel
            // 
            this.kucukTansiyonLabel.AutoSize = true;
            this.kucukTansiyonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kucukTansiyonLabel.Location = new System.Drawing.Point(101, 223);
            this.kucukTansiyonLabel.Name = "kucukTansiyonLabel";
            this.kucukTansiyonLabel.Size = new System.Drawing.Size(113, 17);
            this.kucukTansiyonLabel.TabIndex = 6;
            this.kucukTansiyonLabel.Text = "Küçük Tansiyon:";
            // 
            // vucutSıcaklığıLabel
            // 
            this.vucutSıcaklığıLabel.AutoSize = true;
            this.vucutSıcaklığıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vucutSıcaklığıLabel.Location = new System.Drawing.Point(112, 263);
            this.vucutSıcaklığıLabel.Name = "vucutSıcaklığıLabel";
            this.vucutSıcaklığıLabel.Size = new System.Drawing.Size(103, 17);
            this.vucutSıcaklığıLabel.TabIndex = 7;
            this.vucutSıcaklığıLabel.Text = "Vücut Sıcaklığı:";
            // 
            // biglileriGuncelleButonu
            // 
            this.biglileriGuncelleButonu.Location = new System.Drawing.Point(352, 201);
            this.biglileriGuncelleButonu.Name = "biglileriGuncelleButonu";
            this.biglileriGuncelleButonu.Size = new System.Drawing.Size(120, 23);
            this.biglileriGuncelleButonu.TabIndex = 8;
            this.biglileriGuncelleButonu.Text = "Bilgileri Güncelle";
            this.biglileriGuncelleButonu.UseVisualStyleBackColor = true;
            this.biglileriGuncelleButonu.Click += new System.EventHandler(this.biglileriGuncelleButonu_Click);
            // 
            // hastaIDAcıklamaLabel
            // 
            this.hastaIDAcıklamaLabel.AutoSize = true;
            this.hastaIDAcıklamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaIDAcıklamaLabel.Location = new System.Drawing.Point(147, 92);
            this.hastaIDAcıklamaLabel.Name = "hastaIDAcıklamaLabel";
            this.hastaIDAcıklamaLabel.Size = new System.Drawing.Size(66, 17);
            this.hastaIDAcıklamaLabel.TabIndex = 9;
            this.hastaIDAcıklamaLabel.Text = "Hasta ID:";
            // 
            // hastaIdLabel
            // 
            this.hastaIdLabel.AutoSize = true;
            this.hastaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaIdLabel.Location = new System.Drawing.Point(216, 92);
            this.hastaIdLabel.Name = "hastaIdLabel";
            this.hastaIdLabel.Size = new System.Drawing.Size(0, 17);
            this.hastaIdLabel.TabIndex = 10;
            // 
            // HastaPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.hastaIdLabel);
            this.Controls.Add(this.hastaIDAcıklamaLabel);
            this.Controls.Add(this.biglileriGuncelleButonu);
            this.Controls.Add(this.vucutSıcaklığıLabel);
            this.Controls.Add(this.kucukTansiyonLabel);
            this.Controls.Add(this.buyukTansiyonLabel);
            this.Controls.Add(this.nabızLabel);
            this.Controls.Add(this.vucutSıcaklıgı);
            this.Controls.Add(this.kucukTansiyon);
            this.Controls.Add(this.buyukTansiyon);
            this.Controls.Add(this.nabız);
            this.Name = "HastaPaneli";
            this.Text = "Hasta Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nabız;
        private System.Windows.Forms.TextBox buyukTansiyon;
        private System.Windows.Forms.TextBox kucukTansiyon;
        private System.Windows.Forms.TextBox vucutSıcaklıgı;
        private System.Windows.Forms.Label nabızLabel;
        private System.Windows.Forms.Label buyukTansiyonLabel;
        private System.Windows.Forms.Label kucukTansiyonLabel;
        private System.Windows.Forms.Label vucutSıcaklığıLabel;
        private System.Windows.Forms.Button biglileriGuncelleButonu;
        private System.Windows.Forms.Label hastaIDAcıklamaLabel;
        private System.Windows.Forms.Label hastaIdLabel;
    }
}