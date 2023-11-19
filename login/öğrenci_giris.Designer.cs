namespace YurtOtomasyonu1._0.login
{
    partial class öğrenci_giris
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
            this.emailText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grsBTN = new System.Windows.Forms.Button();
            this.SFRM_UNTM = new System.Windows.Forms.LinkLabel();
            this.YNKYT = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(116, 105);
            this.emailText.Multiline = true;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(269, 46);
            this.emailText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE";
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(116, 196);
            this.sifreText.Multiline = true;
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(269, 46);
            this.sifreText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC/E MAİL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grsBTN
            // 
            this.grsBTN.BackColor = System.Drawing.Color.MintCream;
            this.grsBTN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.grsBTN.Location = new System.Drawing.Point(116, 268);
            this.grsBTN.Name = "grsBTN";
            this.grsBTN.Size = new System.Drawing.Size(269, 68);
            this.grsBTN.TabIndex = 13;
            this.grsBTN.Text = "GİRİŞ";
            this.grsBTN.UseVisualStyleBackColor = false;
            this.grsBTN.Click += new System.EventHandler(this.grsBTN_Click);
            // 
            // SFRM_UNTM
            // 
            this.SFRM_UNTM.AutoSize = true;
            this.SFRM_UNTM.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SFRM_UNTM.LinkColor = System.Drawing.Color.Black;
            this.SFRM_UNTM.Location = new System.Drawing.Point(112, 360);
            this.SFRM_UNTM.Name = "SFRM_UNTM";
            this.SFRM_UNTM.Size = new System.Drawing.Size(164, 24);
            this.SFRM_UNTM.TabIndex = 14;
            this.SFRM_UNTM.TabStop = true;
            this.SFRM_UNTM.Text = "Şifremi Unuttum";
            // 
            // YNKYT
            // 
            this.YNKYT.AutoSize = true;
            this.YNKYT.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YNKYT.LinkColor = System.Drawing.Color.Black;
            this.YNKYT.Location = new System.Drawing.Point(521, 360);
            this.YNKYT.Name = "YNKYT";
            this.YNKYT.Size = new System.Drawing.Size(102, 24);
            this.YNKYT.TabIndex = 15;
            this.YNKYT.TabStop = true;
            this.YNKYT.Text = "Yeni Kayıt";
            this.YNKYT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YNKYT_LinkClicked);
            // 
            // öğrenci_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YNKYT);
            this.Controls.Add(this.SFRM_UNTM);
            this.Controls.Add(this.grsBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailText);
            this.Name = "öğrenci_giris";
            this.Text = "öğrenci_giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button grsBTN;
        private System.Windows.Forms.LinkLabel SFRM_UNTM;
        private System.Windows.Forms.LinkLabel YNKYT;
    }
}