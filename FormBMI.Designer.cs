namespace AE_Clinica
{
    partial class FormBMI
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
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioButtonKilogram = new System.Windows.Forms.RadioButton();
            this.radioButtonPound = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelWeight.Location = new System.Drawing.Point(139, 79);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(75, 28);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Weight";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelHeight.Location = new System.Drawing.Point(139, 122);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(109, 28);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height(cm)";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelResult.Location = new System.Drawing.Point(172, 202);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(64, 28);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(312, 84);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(115, 20);
            this.textBoxWeight.TabIndex = 3;
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(312, 126);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(115, 20);
            this.textBoxHeight.TabIndex = 4;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(172, 229);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(255, 85);
            this.textBoxResult.TabIndex = 5;
            // 
            // radioButtonKilogram
            // 
            this.radioButtonKilogram.AutoSize = true;
            this.radioButtonKilogram.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radioButtonKilogram.Location = new System.Drawing.Point(172, 168);
            this.radioButtonKilogram.Name = "radioButtonKilogram";
            this.radioButtonKilogram.Size = new System.Drawing.Size(101, 29);
            this.radioButtonKilogram.TabIndex = 6;
            this.radioButtonKilogram.TabStop = true;
            this.radioButtonKilogram.Text = "Kilogram";
            this.radioButtonKilogram.UseVisualStyleBackColor = true;
            // 
            // radioButtonPound
            // 
            this.radioButtonPound.AutoSize = true;
            this.radioButtonPound.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radioButtonPound.Location = new System.Drawing.Point(339, 168);
            this.radioButtonPound.Name = "radioButtonPound";
            this.radioButtonPound.Size = new System.Drawing.Size(81, 29);
            this.radioButtonPound.TabIndex = 7;
            this.radioButtonPound.TabStop = true;
            this.radioButtonPound.Text = "Pound";
            this.radioButtonPound.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCalculate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCalculate.Location = new System.Drawing.Point(172, 318);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(255, 21);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Location = new System.Drawing.Point(172, 344);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(103, 20);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Location = new System.Drawing.Point(332, 344);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 20);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(-3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 54);
            this.panel1.TabIndex = 11;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poor Richard", 27.75F);
            this.labelTitle.Location = new System.Drawing.Point(167, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 44);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "BMI Clculater";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AE_Clinica.Properties.Resources.AE_Clinica_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(502, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioButtonPound);
            this.Controls.Add(this.radioButtonKilogram);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Name = "FormBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBMI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RadioButton radioButtonKilogram;
        private System.Windows.Forms.RadioButton radioButtonPound;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}