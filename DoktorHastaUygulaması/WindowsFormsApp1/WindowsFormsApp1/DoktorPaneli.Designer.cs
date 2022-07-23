
namespace WindowsFormsApp1
{
    partial class DoktorPaneli
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
            this.acilHastalar = new System.Windows.Forms.DataGridView();
            this.arananHastaBilgileri = new System.Windows.Forms.DataGridView();
            this.hastaSorgulamaButonu = new System.Windows.Forms.Button();
            this.hastaIDLabel = new System.Windows.Forms.Label();
            this.hastaID = new System.Windows.Forms.TextBox();
            this.normalHastalar = new System.Windows.Forms.DataGridView();
            this.acilDurumdakiHastalarLabel = new System.Windows.Forms.Label();
            this.normalDurumdakiHastalarLabel = new System.Windows.Forms.Label();
            this.guncelVerileriGosterButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.acilHastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arananHastaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // acilHastalar
            // 
            this.acilHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acilHastalar.Location = new System.Drawing.Point(202, 62);
            this.acilHastalar.Name = "acilHastalar";
            this.acilHastalar.Size = new System.Drawing.Size(244, 302);
            this.acilHastalar.TabIndex = 0;
            // 
            // arananHastaBilgileri
            // 
            this.arananHastaBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arananHastaBilgileri.Location = new System.Drawing.Point(260, 421);
            this.arananHastaBilgileri.Name = "arananHastaBilgileri";
            this.arananHastaBilgileri.Size = new System.Drawing.Size(543, 68);
            this.arananHastaBilgileri.TabIndex = 1;
            // 
            // hastaSorgulamaButonu
            // 
            this.hastaSorgulamaButonu.Location = new System.Drawing.Point(492, 562);
            this.hastaSorgulamaButonu.Name = "hastaSorgulamaButonu";
            this.hastaSorgulamaButonu.Size = new System.Drawing.Size(116, 23);
            this.hastaSorgulamaButonu.TabIndex = 2;
            this.hastaSorgulamaButonu.Text = "Hasta Sorgula";
            this.hastaSorgulamaButonu.UseVisualStyleBackColor = true;
            this.hastaSorgulamaButonu.Click += new System.EventHandler(this.hastaSorgulamaButonu_Click);
            // 
            // hastaIDLabel
            // 
            this.hastaIDLabel.AutoSize = true;
            this.hastaIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaIDLabel.Location = new System.Drawing.Point(518, 502);
            this.hastaIDLabel.Name = "hastaIDLabel";
            this.hastaIDLabel.Size = new System.Drawing.Size(66, 17);
            this.hastaIDLabel.TabIndex = 3;
            this.hastaIDLabel.Text = "Hasta ID:";
            // 
            // hastaID
            // 
            this.hastaID.Location = new System.Drawing.Point(481, 529);
            this.hastaID.Name = "hastaID";
            this.hastaID.Size = new System.Drawing.Size(136, 20);
            this.hastaID.TabIndex = 4;
            // 
            // normalHastalar
            // 
            this.normalHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.normalHastalar.Location = new System.Drawing.Point(603, 62);
            this.normalHastalar.Name = "normalHastalar";
            this.normalHastalar.Size = new System.Drawing.Size(244, 302);
            this.normalHastalar.TabIndex = 5;
            // 
            // acilDurumdakiHastalarLabel
            // 
            this.acilDurumdakiHastalarLabel.AutoSize = true;
            this.acilDurumdakiHastalarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acilDurumdakiHastalarLabel.Location = new System.Drawing.Point(231, 28);
            this.acilDurumdakiHastalarLabel.Name = "acilDurumdakiHastalarLabel";
            this.acilDurumdakiHastalarLabel.Size = new System.Drawing.Size(179, 20);
            this.acilDurumdakiHastalarLabel.TabIndex = 6;
            this.acilDurumdakiHastalarLabel.Text = "Acil Durumdaki Hastalar";
            // 
            // normalDurumdakiHastalarLabel
            // 
            this.normalDurumdakiHastalarLabel.AutoSize = true;
            this.normalDurumdakiHastalarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.normalDurumdakiHastalarLabel.Location = new System.Drawing.Point(622, 28);
            this.normalDurumdakiHastalarLabel.Name = "normalDurumdakiHastalarLabel";
            this.normalDurumdakiHastalarLabel.Size = new System.Drawing.Size(204, 20);
            this.normalDurumdakiHastalarLabel.TabIndex = 7;
            this.normalDurumdakiHastalarLabel.Text = "Normal Durumdaki Hastalar";
            // 
            // guncelVerileriGosterButonu
            // 
            this.guncelVerileriGosterButonu.Location = new System.Drawing.Point(467, 186);
            this.guncelVerileriGosterButonu.Name = "guncelVerileriGosterButonu";
            this.guncelVerileriGosterButonu.Size = new System.Drawing.Size(116, 42);
            this.guncelVerileriGosterButonu.TabIndex = 8;
            this.guncelVerileriGosterButonu.Text = "Güncel Verileri Göster";
            this.guncelVerileriGosterButonu.UseVisualStyleBackColor = true;
            this.guncelVerileriGosterButonu.Click += new System.EventHandler(this.guncelVerileriGosterButonu_Click);
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 650);
            this.Controls.Add(this.guncelVerileriGosterButonu);
            this.Controls.Add(this.normalDurumdakiHastalarLabel);
            this.Controls.Add(this.acilDurumdakiHastalarLabel);
            this.Controls.Add(this.normalHastalar);
            this.Controls.Add(this.hastaID);
            this.Controls.Add(this.hastaIDLabel);
            this.Controls.Add(this.hastaSorgulamaButonu);
            this.Controls.Add(this.arananHastaBilgileri);
            this.Controls.Add(this.acilHastalar);
            this.Name = "DoktorPaneli";
            this.Text = "Doktor Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.acilHastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arananHastaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView acilHastalar;
        private System.Windows.Forms.DataGridView arananHastaBilgileri;
        private System.Windows.Forms.Button hastaSorgulamaButonu;
        private System.Windows.Forms.Label hastaIDLabel;
        private System.Windows.Forms.TextBox hastaID;
        private System.Windows.Forms.DataGridView normalHastalar;
        private System.Windows.Forms.Label acilDurumdakiHastalarLabel;
        private System.Windows.Forms.Label normalDurumdakiHastalarLabel;
        private System.Windows.Forms.Button guncelVerileriGosterButonu;
    }
}