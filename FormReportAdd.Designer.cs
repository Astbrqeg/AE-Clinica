
namespace AE_Clinica
{
    partial class FormReportAdd
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxReportID = new System.Windows.Forms.TextBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.textBoxMedicamentName = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.labelReportID = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelMedicamentName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxRN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poor Richard", 27.75F);
            this.labelTitle.Location = new System.Drawing.Point(195, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 44);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Add Patients Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AE_Clinica.Properties.Resources.AE_Clinica_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(604, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.Location = new System.Drawing.Point(420, 381);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 31);
            this.buttonAdd.TabIndex = 51;
            this.buttonAdd.Text = "Add Report";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(450, 355);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 79;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(404, 82);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerDate.TabIndex = 78;
            // 
            // textBoxReportID
            // 
            this.textBoxReportID.Location = new System.Drawing.Point(403, 249);
            this.textBoxReportID.Multiline = true;
            this.textBoxReportID.Name = "textBoxReportID";
            this.textBoxReportID.Size = new System.Drawing.Size(134, 23);
            this.textBoxReportID.TabIndex = 74;
            this.textBoxReportID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReportID_KeyPress);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(401, 167);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(134, 23);
            this.textBoxDetails.TabIndex = 73;
            this.textBoxDetails.TextChanged += new System.EventHandler(this.textBoxDetails_TextChanged);
            // 
            // textBoxMedicamentName
            // 
            this.textBoxMedicamentName.Location = new System.Drawing.Point(403, 122);
            this.textBoxMedicamentName.Multiline = true;
            this.textBoxMedicamentName.Name = "textBoxMedicamentName";
            this.textBoxMedicamentName.Size = new System.Drawing.Size(134, 23);
            this.textBoxMedicamentName.TabIndex = 72;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(155, 295);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(162, 23);
            this.labelRoomNumber.TabIndex = 71;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(155, 82);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 23);
            this.labelDate.TabIndex = 70;
            this.labelDate.Text = "Date:";
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.Location = new System.Drawing.Point(155, 205);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(125, 23);
            this.labelPatientID.TabIndex = 68;
            this.labelPatientID.Text = "Patient ID:";
            // 
            // labelReportID
            // 
            this.labelReportID.AutoSize = true;
            this.labelReportID.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportID.Location = new System.Drawing.Point(155, 249);
            this.labelReportID.Name = "labelReportID";
            this.labelReportID.Size = new System.Drawing.Size(118, 23);
            this.labelReportID.TabIndex = 67;
            this.labelReportID.Text = "Report ID:";
            this.labelReportID.Click += new System.EventHandler(this.labelReportID_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(155, 167);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(90, 23);
            this.labelDetails.TabIndex = 66;
            this.labelDetails.Text = "Details:";
            // 
            // labelMedicamentName
            // 
            this.labelMedicamentName.AutoSize = true;
            this.labelMedicamentName.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicamentName.Location = new System.Drawing.Point(155, 122);
            this.labelMedicamentName.Name = "labelMedicamentName";
            this.labelMedicamentName.Size = new System.Drawing.Size(207, 23);
            this.labelMedicamentName.TabIndex = 65;
            this.labelMedicamentName.Text = "Medicament Name:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(669, 398);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 31);
            this.buttonBack.TabIndex = 80;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(401, 207);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(134, 21);
            this.comboBoxID.TabIndex = 81;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxRN
            // 
            this.comboBoxRN.FormattingEnabled = true;
            this.comboBoxRN.Location = new System.Drawing.Point(401, 295);
            this.comboBoxRN.Name = "comboBoxRN";
            this.comboBoxRN.Size = new System.Drawing.Size(134, 21);
            this.comboBoxRN.TabIndex = 82;
            // 
            // FormReportAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.comboBoxRN);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxReportID);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.textBoxMedicamentName);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.labelReportID);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelMedicamentName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormReportAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportAdd";
            this.Load += new System.EventHandler(this.FormReportAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxReportID;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.TextBox textBoxMedicamentName;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Label labelReportID;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelMedicamentName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxRN;
    }
}