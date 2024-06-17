namespace Project
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpVotingResult = new System.Windows.Forms.GroupBox();
            this.gvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpVotingResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopName
            // 
            this.lblShopName.BackColor = System.Drawing.Color.Transparent;
            this.lblShopName.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblShopName.Location = new System.Drawing.Point(160, 26);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(407, 50);
            this.lblShopName.TabIndex = 1;
            this.lblShopName.Text = "Sara\'s CoffeeMania";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(597, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // grpVotingResult
            // 
            this.grpVotingResult.BackColor = System.Drawing.Color.Transparent;
            this.grpVotingResult.Controls.Add(this.gvResult);
            this.grpVotingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVotingResult.ForeColor = System.Drawing.Color.DimGray;
            this.grpVotingResult.Location = new System.Drawing.Point(76, 110);
            this.grpVotingResult.Name = "grpVotingResult";
            this.grpVotingResult.Size = new System.Drawing.Size(679, 277);
            this.grpVotingResult.TabIndex = 17;
            this.grpVotingResult.TabStop = false;
            this.grpVotingResult.Text = "Voting Result";
            // 
            // gvResult
            // 
            this.gvResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(26, 46);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(616, 197);
            this.gvResult.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Neutral_Simple_Watercolor_Background_Notes_A4_Document__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpVotingResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblShopName);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpVotingResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpVotingResult;
        private System.Windows.Forms.DataGridView gvResult;
    }
}