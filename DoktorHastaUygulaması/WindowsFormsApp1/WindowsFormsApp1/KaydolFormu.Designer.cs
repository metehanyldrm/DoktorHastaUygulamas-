
namespace WindowsFormsApp1
{
    partial class KaydolFormu
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
            this.idLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kaydolButonu = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.doktorMu = new System.Windows.Forms.RadioButton();
            this.hastaMı = new System.Windows.Forms.RadioButton();
            this.gostersinMi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.Location = new System.Drawing.Point(201, 165);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(189, 208);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(41, 17);
            this.sifreLabel.TabIndex = 1;
            this.sifreLabel.Text = "Şifre:";
            // 
            // kaydolButonu
            // 
            this.kaydolButonu.Location = new System.Drawing.Point(265, 278);
            this.kaydolButonu.Name = "kaydolButonu";
            this.kaydolButonu.Size = new System.Drawing.Size(94, 23);
            this.kaydolButonu.TabIndex = 2;
            this.kaydolButonu.Text = "Kaydol";
            this.kaydolButonu.UseVisualStyleBackColor = true;
            this.kaydolButonu.Click += new System.EventHandler(this.kaydolButonu_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(232, 164);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(156, 20);
            this.id.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(232, 208);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(156, 20);
            this.sifre.TabIndex = 4;
            // 
            // doktorMu
            // 
            this.doktorMu.AutoSize = true;
            this.doktorMu.Location = new System.Drawing.Point(252, 245);
            this.doktorMu.Name = "doktorMu";
            this.doktorMu.Size = new System.Drawing.Size(57, 17);
            this.doktorMu.TabIndex = 5;
            this.doktorMu.TabStop = true;
            this.doktorMu.Text = "Doktor";
            this.doktorMu.UseVisualStyleBackColor = true;
            // 
            // hastaMı
            // 
            this.hastaMı.AutoSize = true;
            this.hastaMı.Location = new System.Drawing.Point(324, 245);
            this.hastaMı.Name = "hastaMı";
            this.hastaMı.Size = new System.Drawing.Size(53, 17);
            this.hastaMı.TabIndex = 6;
            this.hastaMı.TabStop = true;
            this.hastaMı.Text = "Hasta";
            this.hastaMı.UseVisualStyleBackColor = true;
            // 
            // gostersinMi
            // 
            this.gostersinMi.AutoSize = true;
            this.gostersinMi.Location = new System.Drawing.Point(395, 210);
            this.gostersinMi.Name = "gostersinMi";
            this.gostersinMi.Size = new System.Drawing.Size(57, 17);
            this.gostersinMi.TabIndex = 7;
            this.gostersinMi.Text = "Göster";
            this.gostersinMi.UseVisualStyleBackColor = true;
            this.gostersinMi.CheckedChanged += new System.EventHandler(this.gostersinMi_CheckedChanged);
            // 
            // KaydolFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.gostersinMi);
            this.Controls.Add(this.hastaMı);
            this.Controls.Add(this.doktorMu);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.kaydolButonu);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "KaydolFormu";
            this.Text = "Kaydol Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Button kaydolButonu;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.RadioButton doktorMu;
        private System.Windows.Forms.RadioButton hastaMı;
        private System.Windows.Forms.CheckBox gostersinMi;
    }
}