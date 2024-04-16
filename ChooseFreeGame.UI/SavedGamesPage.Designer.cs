namespace ChooseFreeGame.UI
{
    partial class SavedGamesPage
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
            this.SavedGamesComboBox = new System.Windows.Forms.ComboBox();
            this.SavedGamesLabel = new System.Windows.Forms.Label();
            this.GameThumbnailPictureBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DeleteGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameThumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SavedGamesComboBox
            // 
            this.SavedGamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SavedGamesComboBox.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavedGamesComboBox.FormattingEnabled = true;
            this.SavedGamesComboBox.Location = new System.Drawing.Point(120, 59);
            this.SavedGamesComboBox.Name = "SavedGamesComboBox";
            this.SavedGamesComboBox.Size = new System.Drawing.Size(245, 32);
            this.SavedGamesComboBox.TabIndex = 6;
            this.SavedGamesComboBox.SelectedIndexChanged += new System.EventHandler(this.SavedGamesComboBox_SelectedIndexChanged);
            // 
            // SavedGamesLabel
            // 
            this.SavedGamesLabel.AutoSize = true;
            this.SavedGamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.SavedGamesLabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavedGamesLabel.Location = new System.Drawing.Point(99, 9);
            this.SavedGamesLabel.Name = "SavedGamesLabel";
            this.SavedGamesLabel.Size = new System.Drawing.Size(289, 47);
            this.SavedGamesLabel.TabIndex = 7;
            this.SavedGamesLabel.Text = "Saved Games:";
            // 
            // GameThumbnailPictureBox
            // 
            this.GameThumbnailPictureBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GameThumbnailPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameThumbnailPictureBox.Location = new System.Drawing.Point(65, 240);
            this.GameThumbnailPictureBox.Name = "GameThumbnailPictureBox";
            this.GameThumbnailPictureBox.Size = new System.Drawing.Size(354, 158);
            this.GameThumbnailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameThumbnailPictureBox.TabIndex = 10;
            this.GameThumbnailPictureBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(65, 104);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(350, 121);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteGameButton
            // 
            this.DeleteGameButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.DeleteGameButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteGameButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteGameButton.Location = new System.Drawing.Point(175, 408);
            this.DeleteGameButton.Name = "DeleteGameButton";
            this.DeleteGameButton.Size = new System.Drawing.Size(130, 33);
            this.DeleteGameButton.TabIndex = 14;
            this.DeleteGameButton.Text = "Delete Game";
            this.DeleteGameButton.UseVisualStyleBackColor = false;
            this.DeleteGameButton.Click += new System.EventHandler(this.DeleteGameButton_Click);
            // 
            // SavedGamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.DeleteGameButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.GameThumbnailPictureBox);
            this.Controls.Add(this.SavedGamesLabel);
            this.Controls.Add(this.SavedGamesComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavedGamesPage";
            this.Text = "Saved games";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SavedGamesPage_FormClosing);
            this.Load += new System.EventHandler(this.SavedGamesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameThumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SavedGamesComboBox;
        private System.Windows.Forms.Label SavedGamesLabel;
        private System.Windows.Forms.PictureBox GameThumbnailPictureBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button DeleteGameButton;
    }
}