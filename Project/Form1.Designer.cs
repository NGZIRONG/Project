namespace Project
{
    partial class Form1
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
            this.lblShopName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpboxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picboxDrink = new System.Windows.Forms.PictureBox();
            this.txtboxVoting = new System.Windows.Forms.TextBox();
            this.lblVoting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowVoting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpboxPersonalDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopName
            // 
            this.lblShopName.BackColor = System.Drawing.Color.Transparent;
            this.lblShopName.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblShopName.Location = new System.Drawing.Point(159, 9);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(407, 50);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Sara\'s CoffeeMania";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name : ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpboxPersonalDetails
            // 
            this.grpboxPersonalDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpboxPersonalDetails.Controls.Add(this.txtboxPhoneNumber);
            this.grpboxPersonalDetails.Controls.Add(this.lblPhoneNumber);
            this.grpboxPersonalDetails.Controls.Add(this.radbtnFemale);
            this.grpboxPersonalDetails.Controls.Add(this.radbtnMale);
            this.grpboxPersonalDetails.Controls.Add(this.txtboxName);
            this.grpboxPersonalDetails.Controls.Add(this.lblGender);
            this.grpboxPersonalDetails.Controls.Add(this.lblName);
            this.grpboxPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxPersonalDetails.ForeColor = System.Drawing.Color.DimGray;
            this.grpboxPersonalDetails.Location = new System.Drawing.Point(12, 86);
            this.grpboxPersonalDetails.Name = "grpboxPersonalDetails";
            this.grpboxPersonalDetails.Size = new System.Drawing.Size(281, 237);
            this.grpboxPersonalDetails.TabIndex = 3;
            this.grpboxPersonalDetails.TabStop = false;
            this.grpboxPersonalDetails.Text = "Personal Details";
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(6, 136);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(171, 21);
            this.txtboxPhoneNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 104);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(179, 29);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number : ";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnFemale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radbtnFemale.Location = new System.Drawing.Point(184, 188);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(77, 20);
            this.radbtnFemale.TabIndex = 8;
            this.radbtnFemale.TabStop = true;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.UseVisualStyleBackColor = true;
            // 
            // radbtnMale
            // 
            this.radbtnMale.AutoSize = true;
            this.radbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radbtnMale.Location = new System.Drawing.Point(126, 189);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(59, 20);
            this.radbtnMale.TabIndex = 6;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxName.Location = new System.Drawing.Point(6, 59);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(171, 21);
            this.txtboxName.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGender.Location = new System.Drawing.Point(6, 183);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(106, 33);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender : ";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picboxDrink);
            this.groupBox1.Controls.Add(this.txtboxVoting);
            this.groupBox1.Controls.Add(this.lblVoting);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(311, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 237);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vote Favourite Drinks";
            // 
            // picboxDrink
            // 
            this.picboxDrink.Location = new System.Drawing.Point(221, 33);
            this.picboxDrink.Name = "picboxDrink";
            this.picboxDrink.Size = new System.Drawing.Size(235, 132);
            this.picboxDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDrink.TabIndex = 13;
            this.picboxDrink.TabStop = false;
            // 
            // txtboxVoting
            // 
            this.txtboxVoting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxVoting.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxVoting.Location = new System.Drawing.Point(6, 181);
            this.txtboxVoting.Name = "txtboxVoting";
            this.txtboxVoting.Size = new System.Drawing.Size(314, 21);
            this.txtboxVoting.TabIndex = 11;
            // 
            // lblVoting
            // 
            this.lblVoting.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoting.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVoting.Location = new System.Drawing.Point(6, 142);
            this.lblVoting.Name = "lblVoting";
            this.lblVoting.Size = new System.Drawing.Size(116, 23);
            this.lblVoting.TabIndex = 12;
            this.lblVoting.Text = "Voting : ";
            this.lblVoting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Drinks :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Americano",
            "Cappuccino",
            "Mocha",
            "Espresso",
            "Latte"});
            this.comboBox1.Location = new System.Drawing.Point(6, 59);
            this.comboBox1.MaximumSize = new System.Drawing.Size(187, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(187, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSubmit.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(165, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 43);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PeachPuff;
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(302, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 43);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnShowVoting
            // 
            this.btnShowVoting.BackColor = System.Drawing.Color.PeachPuff;
            this.btnShowVoting.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowVoting.Location = new System.Drawing.Point(501, 346);
            this.btnShowVoting.Name = "btnShowVoting";
            this.btnShowVoting.Size = new System.Drawing.Size(237, 43);
            this.btnShowVoting.TabIndex = 14;
            this.btnShowVoting.Text = " Show Voting Result";
            this.btnShowVoting.UseVisualStyleBackColor = false;
            this.btnShowVoting.Click += new System.EventHandler(this.btnShowVoting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(632, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Neutral_Simple_Watercolor_Background_Notes_A4_Document__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShowVoting);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.grpboxPersonalDetails);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Form1";
            this.Text = "Project";
            this.grpboxPersonalDetails.ResumeLayout(false);
            this.grpboxPersonalDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpboxPersonalDetails;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.RadioButton radbtnMale;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.TextBox txtboxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picboxDrink;
        private System.Windows.Forms.TextBox txtboxVoting;
        private System.Windows.Forms.Label lblVoting;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowVoting;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

