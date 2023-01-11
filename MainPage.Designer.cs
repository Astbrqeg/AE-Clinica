namespace AE_Clinica
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelText = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonBMI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Haettenschweiler", 25F);
            this.labelText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelText.Location = new System.Drawing.Point(263, 182);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(243, 35);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Welcome To AE Clinica";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Black", 15F);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(331, 240);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLogin.Size = new System.Drawing.Size(120, 37);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonBMI
            // 
            this.buttonBMI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBMI.Font = new System.Drawing.Font("Arial Black", 15F);
            this.buttonBMI.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBMI.Location = new System.Drawing.Point(331, 298);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(120, 34);
            this.buttonBMI.TabIndex = 2;
            this.buttonBMI.Text = "BMI";
            this.buttonBMI.UseVisualStyleBackColor = false;
            this.buttonBMI.Click += new System.EventHandler(this.buttonBMI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AE_Clinica.Properties.Resources.AE_Clinica_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBMI);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelText);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonBMI;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}