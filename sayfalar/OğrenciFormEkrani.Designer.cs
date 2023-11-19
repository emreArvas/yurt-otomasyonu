namespace YurtOtomasyonu1._0.sayfalar
{
    partial class OğrenciFormEkrani
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
            this.isimLabel = new System.Windows.Forms.Label();
            this.soyisimLabel = new System.Windows.Forms.Label();
            this.TCLabel = new System.Windows.Forms.Label();
            this.odaTipLabel = new System.Windows.Forms.Label();
            this.onaylandimi = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.soyisim = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.odatipi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isimLabel
            // 
            this.isimLabel.AutoSize = true;
            this.isimLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimLabel.Location = new System.Drawing.Point(80, 65);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(88, 20);
            this.isimLabel.TabIndex = 0;
            this.isimLabel.Text = "İsim        :";
            // 
            // soyisimLabel
            // 
            this.soyisimLabel.AutoSize = true;
            this.soyisimLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimLabel.Location = new System.Drawing.Point(77, 125);
            this.soyisimLabel.Name = "soyisimLabel";
            this.soyisimLabel.Size = new System.Drawing.Size(93, 20);
            this.soyisimLabel.TabIndex = 1;
            this.soyisimLabel.Text = "Soyisim  :";
            // 
            // TCLabel
            // 
            this.TCLabel.AutoSize = true;
            this.TCLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCLabel.Location = new System.Drawing.Point(77, 177);
            this.TCLabel.Name = "TCLabel";
            this.TCLabel.Size = new System.Drawing.Size(91, 20);
            this.TCLabel.TabIndex = 2;
            this.TCLabel.Text = "TC             :";
            // 
            // odaTipLabel
            // 
            this.odaTipLabel.AutoSize = true;
            this.odaTipLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaTipLabel.Location = new System.Drawing.Point(77, 229);
            this.odaTipLabel.Name = "odaTipLabel";
            this.odaTipLabel.Size = new System.Drawing.Size(91, 20);
            this.odaTipLabel.TabIndex = 3;
            this.odaTipLabel.Text = "Oda tipi :";
            // 
            // onaylandimi
            // 
            this.onaylandimi.AutoSize = true;
            this.onaylandimi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylandimi.Location = new System.Drawing.Point(522, 319);
            this.onaylandimi.Name = "onaylandimi";
            this.onaylandimi.Size = new System.Drawing.Size(180, 24);
            this.onaylandimi.TabIndex = 4;
            this.onaylandimi.Text = "ONAYLANMADI";
            this.onaylandimi.Click += new System.EventHandler(this.label5_Click);
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.Location = new System.Drawing.Point(198, 65);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(50, 20);
            this.isim.TabIndex = 5;
            this.isim.Text = "İsim";
            this.isim.Click += new System.EventHandler(this.isim_Click);
            // 
            // soyisim
            // 
            this.soyisim.AutoSize = true;
            this.soyisim.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisim.Location = new System.Drawing.Point(198, 125);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(50, 20);
            this.soyisim.TabIndex = 6;
            this.soyisim.Text = "İsim";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(198, 177);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(50, 20);
            this.tc.TabIndex = 7;
            this.tc.Text = "İsim";
            // 
            // odatipi
            // 
            this.odatipi.AutoSize = true;
            this.odatipi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odatipi.Location = new System.Drawing.Point(198, 229);
            this.odatipi.Name = "odatipi";
            this.odatipi.Size = new System.Drawing.Size(50, 20);
            this.odatipi.TabIndex = 8;
            this.odatipi.Text = "İsim";
            // 
            // OğrenciFormEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odatipi);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.onaylandimi);
            this.Controls.Add(this.odaTipLabel);
            this.Controls.Add(this.TCLabel);
            this.Controls.Add(this.soyisimLabel);
            this.Controls.Add(this.isimLabel);
            this.Name = "OğrenciFormEkrani";
            this.Text = "OğrenciFormEkrani";
            this.Load += new System.EventHandler(this.OğrenciFormEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isimLabel;
        private System.Windows.Forms.Label soyisimLabel;
        private System.Windows.Forms.Label TCLabel;
        private System.Windows.Forms.Label odaTipLabel;
        private System.Windows.Forms.Label onaylandimi;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label soyisim;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label odatipi;
    }
}