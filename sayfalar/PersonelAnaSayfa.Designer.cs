namespace YurtOtomasyonu1._0.sayfalar
{
    partial class PersonelAnaSayfa
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kart = new System.Windows.Forms.Panel();
            this.isim = new System.Windows.Forms.Label();
            this.soyisim = new System.Windows.Forms.Label();
            this.odaTipi = new System.Windows.Forms.Label();
            this.onayla = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.durum = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.kart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.kart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1281, 636);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // kart
            // 
            this.kart.BackColor = System.Drawing.Color.Gray;
            this.kart.Controls.Add(this.durum);
            this.kart.Controls.Add(this.iptal);
            this.kart.Controls.Add(this.onayla);
            this.kart.Controls.Add(this.odaTipi);
            this.kart.Controls.Add(this.soyisim);
            this.kart.Controls.Add(this.isim);
            this.kart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kart.Location = new System.Drawing.Point(3, 3);
            this.kart.Name = "kart";
            this.kart.Size = new System.Drawing.Size(1261, 69);
            this.kart.TabIndex = 0;
            this.kart.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.ForeColor = System.Drawing.SystemColors.Control;
            this.isim.Location = new System.Drawing.Point(38, 24);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(74, 20);
            this.isim.TabIndex = 0;
            this.isim.Text = "isim......";
            // 
            // soyisim
            // 
            this.soyisim.AutoSize = true;
            this.soyisim.ForeColor = System.Drawing.SystemColors.Control;
            this.soyisim.Location = new System.Drawing.Point(177, 24);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(103, 20);
            this.soyisim.TabIndex = 1;
            this.soyisim.Text = "soyisim......";
            // 
            // odaTipi
            // 
            this.odaTipi.AutoSize = true;
            this.odaTipi.ForeColor = System.Drawing.SystemColors.Control;
            this.odaTipi.Location = new System.Drawing.Point(367, 24);
            this.odaTipi.Name = "odaTipi";
            this.odaTipi.Size = new System.Drawing.Size(128, 20);
            this.odaTipi.TabIndex = 2;
            this.odaTipi.Text = "kaç kişilik oda";
            this.odaTipi.Click += new System.EventHandler(this.label2_Click);
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(827, 13);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(195, 42);
            this.onayla.TabIndex = 3;
            this.onayla.Text = "onayla";
            this.onayla.UseVisualStyleBackColor = true;
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(1065, 13);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(176, 42);
            this.iptal.TabIndex = 4;
            this.iptal.Text = "iptal";
            this.iptal.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.ForeColor = System.Drawing.SystemColors.Control;
            this.durum.Location = new System.Drawing.Point(604, 24);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(113, 20);
            this.durum.TabIndex = 5;
            this.durum.Text = "onaylanmadı";
            this.durum.Click += new System.EventHandler(this.durum_Click);
            // 
            // PersonelAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1325, 683);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PersonelAnaSayfa";
            this.Text = "PersonelAnaSayfa";
            this.Load += new System.EventHandler(this.PersonelAnaSayfa_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kart.ResumeLayout(false);
            this.kart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel kart;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Label odaTipi;
        private System.Windows.Forms.Label soyisim;
        private System.Windows.Forms.Label isim;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label durum;
    }
}