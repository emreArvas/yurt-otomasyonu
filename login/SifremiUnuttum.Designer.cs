namespace YurtOtomasyonu1._0.login
{
    partial class SifremiUnuttum
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
            this.grsBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // grsBTN
            // 
            this.grsBTN.BackColor = System.Drawing.Color.MintCream;
            this.grsBTN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.grsBTN.Location = new System.Drawing.Point(268, 266);
            this.grsBTN.Name = "grsBTN";
            this.grsBTN.Size = new System.Drawing.Size(269, 68);
            this.grsBTN.TabIndex = 18;
            this.grsBTN.Text = "GÖNDER";
            this.grsBTN.UseVisualStyleBackColor = false;
            this.grsBTN.Click += new System.EventHandler(this.grsBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(264, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "E MAİL";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(268, 186);
            this.emailText.Multiline = true;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(269, 46);
            this.emailText.TabIndex = 14;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grsBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailText);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grsBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailText;
    }
}