namespace YurtOtomasyonu1._0.login
{
    partial class Dogrula
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
            this.label3 = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.grsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "YENİ ŞİFRE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(268, 216);
            this.sifreText.Multiline = true;
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(269, 46);
            this.sifreText.TabIndex = 18;
            this.sifreText.TextChanged += new System.EventHandler(this.sifreText_TextChanged);
            // 
            // grsBTN
            // 
            this.grsBTN.BackColor = System.Drawing.Color.MintCream;
            this.grsBTN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.grsBTN.Location = new System.Drawing.Point(268, 291);
            this.grsBTN.Name = "grsBTN";
            this.grsBTN.Size = new System.Drawing.Size(269, 68);
            this.grsBTN.TabIndex = 19;
            this.grsBTN.Text = "GÖNDER";
            this.grsBTN.UseVisualStyleBackColor = false;
            this.grsBTN.Click += new System.EventHandler(this.grsBTN_Click);
            // 
            // Dogrula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grsBTN);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.label3);
            this.Name = "Dogrula";
            this.Text = "Dogrula";
            this.Load += new System.EventHandler(this.Dogrula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button grsBTN;
    }
}