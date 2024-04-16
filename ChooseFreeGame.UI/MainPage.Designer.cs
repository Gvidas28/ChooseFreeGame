namespace ChooseFreeGame.UI
{
    partial class MainPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GameImagePictureBox = new System.Windows.Forms.PictureBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.FiltersLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.GameIDLabel = new System.Windows.Forms.Label();
            this.GameDescriptionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.SavedGamesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(139, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(520, 56);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Choose a free game!";
            // 
            // GameImagePictureBox
            // 
            this.GameImagePictureBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GameImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameImagePictureBox.Location = new System.Drawing.Point(27, 183);
            this.GameImagePictureBox.Name = "GameImagePictureBox";
            this.GameImagePictureBox.Size = new System.Drawing.Size(393, 253);
            this.GameImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameImagePictureBox.TabIndex = 1;
            this.GameImagePictureBox.TabStop = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.GenerateButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateButton.Location = new System.Drawing.Point(525, 470);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(188, 76);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate Random Game";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // FiltersLabel
            // 
            this.FiltersLabel.AutoSize = true;
            this.FiltersLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.FiltersLabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiltersLabel.Location = new System.Drawing.Point(523, 194);
            this.FiltersLabel.Name = "FiltersLabel";
            this.FiltersLabel.Size = new System.Drawing.Size(190, 47);
            this.FiltersLabel.TabIndex = 3;
            this.FiltersLabel.Text = "Filters:";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.PlatformLabel.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlatformLabel.Location = new System.Drawing.Point(568, 269);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(101, 20);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform:";
            // 
            // PlatformComboBox
            // 
            this.PlatformComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlatformComboBox.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlatformComboBox.FormattingEnabled = true;
            this.PlatformComboBox.Location = new System.Drawing.Point(534, 306);
            this.PlatformComboBox.Name = "PlatformComboBox";
            this.PlatformComboBox.Size = new System.Drawing.Size(165, 26);
            this.PlatformComboBox.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.CategoryLabel.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(570, 356);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(99, 20);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(534, 390);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(165, 26);
            this.CategoryComboBox.TabIndex = 7;
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameTitleLabel.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitleLabel.Location = new System.Drawing.Point(74, 124);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(295, 47);
            this.GameTitleLabel.TabIndex = 8;
            this.GameTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameIDLabel
            // 
            this.GameIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameIDLabel.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameIDLabel.Location = new System.Drawing.Point(193, 99);
            this.GameIDLabel.Name = "GameIDLabel";
            this.GameIDLabel.Size = new System.Drawing.Size(53, 25);
            this.GameIDLabel.TabIndex = 9;
            this.GameIDLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameDescriptionLabel
            // 
            this.GameDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameDescriptionLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameDescriptionLabel.Location = new System.Drawing.Point(74, 445);
            this.GameDescriptionLabel.Name = "GameDescriptionLabel";
            this.GameDescriptionLabel.Size = new System.Drawing.Size(295, 130);
            this.GameDescriptionLabel.TabIndex = 10;
            this.GameDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(481, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ViewDetailsButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewDetailsButton.ForeColor = System.Drawing.Color.Black;
            this.ViewDetailsButton.Location = new System.Drawing.Point(139, 588);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(188, 54);
            this.ViewDetailsButton.TabIndex = 12;
            this.ViewDetailsButton.Text = "View Game Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = false;
            this.ViewDetailsButton.Visible = false;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SaveGameButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveGameButton.ForeColor = System.Drawing.Color.Black;
            this.SaveGameButton.Location = new System.Drawing.Point(169, 648);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(130, 33);
            this.SaveGameButton.TabIndex = 13;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = false;
            this.SaveGameButton.Visible = false;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // SavedGamesButton
            // 
            this.SavedGamesButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SavedGamesButton.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavedGamesButton.ForeColor = System.Drawing.Color.Black;
            this.SavedGamesButton.Location = new System.Drawing.Point(613, 690);
            this.SavedGamesButton.Name = "SavedGamesButton";
            this.SavedGamesButton.Size = new System.Drawing.Size(157, 51);
            this.SavedGamesButton.TabIndex = 14;
            this.SavedGamesButton.Text = "Saved Games";
            this.SavedGamesButton.UseVisualStyleBackColor = false;
            this.SavedGamesButton.Click += new System.EventHandler(this.SavedGamesButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.SavedGamesButton);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.ViewDetailsButton);
            this.Controls.Add(this.GameDescriptionLabel);
            this.Controls.Add(this.GameIDLabel);
            this.Controls.Add(this.GameTitleLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PlatformComboBox);
            this.Controls.Add(this.PlatformLabel);
            this.Controls.Add(this.FiltersLabel);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.GameImagePictureBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.Text = "Choose a free game!";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox GameImagePictureBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label FiltersLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.ComboBox PlatformComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label GameTitleLabel;
        private System.Windows.Forms.Label GameIDLabel;
        private System.Windows.Forms.Label GameDescriptionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.Button SavedGamesButton;
    }
}