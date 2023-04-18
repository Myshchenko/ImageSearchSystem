using System.Windows.Forms;

namespace ImageSearchSystem
{
    partial class SearchForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.ImageSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageResolutionRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchValueTextBox = new System.Windows.Forms.TextBox();
            this.OneSearchParameterGroupBox = new System.Windows.Forms.GroupBox();
            this.ImageSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallPictureSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumPictureSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.BIgImageRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberOfColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.UpTo1000RadioButton = new System.Windows.Forms.RadioButton();
            this.From1000To5000RadioButton = new System.Windows.Forms.RadioButton();
            this.MoreThan5000RadioButton = new System.Windows.Forms.RadioButton();
            this.FoundImagePictureBox = new System.Windows.Forms.PictureBox();
            this.FileFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberOfFileColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentSourceFolderLabel = new System.Windows.Forms.Label();
            this.PreviousPictureButton = new System.Windows.Forms.Button();
            this.NextPictureButton = new System.Windows.Forms.Button();
            this.ImageResolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallImageResolutionRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumImageResolutionRadioButton = new System.Windows.Forms.RadioButton();
            this.BigImageResolutionRadioButton = new System.Windows.Forms.RadioButton();
            this.OneSearchParameterGroupBox.SuspendLayout();
            this.ImageSizeGroupBox.SuspendLayout();
            this.NumberOfColorsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ImageResolutionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(84, 505);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(32, 159);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(135, 20);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search parameters:";
            // 
            // ImageSizeRadioButton
            // 
            this.ImageSizeRadioButton.AutoSize = true;
            this.ImageSizeRadioButton.Location = new System.Drawing.Point(32, 198);
            this.ImageSizeRadioButton.Name = "ImageSizeRadioButton";
            this.ImageSizeRadioButton.Size = new System.Drawing.Size(101, 24);
            this.ImageSizeRadioButton.TabIndex = 10;
            this.ImageSizeRadioButton.TabStop = true;
            this.ImageSizeRadioButton.Text = "Image size";
            this.ImageSizeRadioButton.UseVisualStyleBackColor = true;
            this.ImageSizeRadioButton.CheckedChanged += new System.EventHandler(this.ImageSizeRadioButton_CheckedChanged);
            // 
            // ImageResolutionRadioButton
            // 
            this.ImageResolutionRadioButton.AutoSize = true;
            this.ImageResolutionRadioButton.Location = new System.Drawing.Point(32, 228);
            this.ImageResolutionRadioButton.Name = "ImageResolutionRadioButton";
            this.ImageResolutionRadioButton.Size = new System.Drawing.Size(194, 24);
            this.ImageResolutionRadioButton.TabIndex = 12;
            this.ImageResolutionRadioButton.TabStop = true;
            this.ImageResolutionRadioButton.Text = "Image resolution (pixels)";
            this.ImageResolutionRadioButton.UseVisualStyleBackColor = true;
            this.ImageResolutionRadioButton.CheckedChanged += new System.EventHandler(this.ImageResolutionRadioButton_CheckedChanged);
            // 
            // SearchValueTextBox
            // 
            this.SearchValueTextBox.Location = new System.Drawing.Point(39, 40);
            this.SearchValueTextBox.Name = "SearchValueTextBox";
            this.SearchValueTextBox.Size = new System.Drawing.Size(125, 27);
            this.SearchValueTextBox.TabIndex = 13;
            // 
            // OneSearchParameterGroupBox
            // 
            this.OneSearchParameterGroupBox.Controls.Add(this.SearchValueTextBox);
            this.OneSearchParameterGroupBox.Location = new System.Drawing.Point(32, 322);
            this.OneSearchParameterGroupBox.Name = "OneSearchParameterGroupBox";
            this.OneSearchParameterGroupBox.Size = new System.Drawing.Size(205, 102);
            this.OneSearchParameterGroupBox.TabIndex = 0;
            this.OneSearchParameterGroupBox.TabStop = false;
            this.OneSearchParameterGroupBox.Visible = false;
            // 
            // ImageSizeGroupBox
            // 
            this.ImageSizeGroupBox.Controls.Add(this.SmallPictureSizeRadioButton);
            this.ImageSizeGroupBox.Controls.Add(this.MediumPictureSizeRadioButton);
            this.ImageSizeGroupBox.Controls.Add(this.BIgImageRadioButton);
            this.ImageSizeGroupBox.Location = new System.Drawing.Point(26, 348);
            this.ImageSizeGroupBox.Name = "ImageSizeGroupBox";
            this.ImageSizeGroupBox.Size = new System.Drawing.Size(250, 125);
            this.ImageSizeGroupBox.TabIndex = 19;
            this.ImageSizeGroupBox.TabStop = false;
            this.ImageSizeGroupBox.Visible = false;
            // 
            // SmallPictureSizeRadioButton
            // 
            this.SmallPictureSizeRadioButton.AutoSize = true;
            this.SmallPictureSizeRadioButton.Location = new System.Drawing.Point(36, 88);
            this.SmallPictureSizeRadioButton.Name = "SmallPictureSizeRadioButton";
            this.SmallPictureSizeRadioButton.Size = new System.Drawing.Size(140, 24);
            this.SmallPictureSizeRadioButton.TabIndex = 25;
            this.SmallPictureSizeRadioButton.TabStop = true;
            this.SmallPictureSizeRadioButton.Text = "Small (< 0,5 mb)";
            this.SmallPictureSizeRadioButton.UseVisualStyleBackColor = true;
            this.SmallPictureSizeRadioButton.CheckedChanged += new System.EventHandler(this.SmallPictureSizeRadioButton_CheckedChanged);
            // 
            // MediumPictureSizeRadioButton
            // 
            this.MediumPictureSizeRadioButton.AutoSize = true;
            this.MediumPictureSizeRadioButton.Location = new System.Drawing.Point(36, 58);
            this.MediumPictureSizeRadioButton.Name = "MediumPictureSizeRadioButton";
            this.MediumPictureSizeRadioButton.Size = new System.Drawing.Size(166, 24);
            this.MediumPictureSizeRadioButton.TabIndex = 24;
            this.MediumPictureSizeRadioButton.TabStop = true;
            this.MediumPictureSizeRadioButton.Text = "Medium (0,5 - 3 mb)";
            this.MediumPictureSizeRadioButton.UseVisualStyleBackColor = true;
            this.MediumPictureSizeRadioButton.CheckedChanged += new System.EventHandler(this.MediumPictureSizeRadioButton_CheckedChanged);
            // 
            // BIgImageRadioButton
            // 
            this.BIgImageRadioButton.AutoSize = true;
            this.BIgImageRadioButton.Location = new System.Drawing.Point(36, 28);
            this.BIgImageRadioButton.Name = "BIgImageRadioButton";
            this.BIgImageRadioButton.Size = new System.Drawing.Size(114, 24);
            this.BIgImageRadioButton.TabIndex = 23;
            this.BIgImageRadioButton.TabStop = true;
            this.BIgImageRadioButton.Text = "Big (> 3 mb)";
            this.BIgImageRadioButton.UseVisualStyleBackColor = true;
            this.BIgImageRadioButton.CheckedChanged += new System.EventHandler(this.BIgImageRadioButton_CheckedChanged);
            // 
            // NumberOfColorsGroupBox
            // 
            this.NumberOfColorsGroupBox.Controls.Add(this.UpTo1000RadioButton);
            this.NumberOfColorsGroupBox.Controls.Add(this.From1000To5000RadioButton);
            this.NumberOfColorsGroupBox.Controls.Add(this.MoreThan5000RadioButton);
            this.NumberOfColorsGroupBox.Location = new System.Drawing.Point(20, 348);
            this.NumberOfColorsGroupBox.Name = "NumberOfColorsGroupBox";
            this.NumberOfColorsGroupBox.Size = new System.Drawing.Size(250, 125);
            this.NumberOfColorsGroupBox.TabIndex = 26;
            this.NumberOfColorsGroupBox.TabStop = false;
            this.NumberOfColorsGroupBox.Visible = false;
            // 
            // UpTo1000RadioButton
            // 
            this.UpTo1000RadioButton.AutoSize = true;
            this.UpTo1000RadioButton.Location = new System.Drawing.Point(36, 88);
            this.UpTo1000RadioButton.Name = "UpTo1000RadioButton";
            this.UpTo1000RadioButton.Size = new System.Drawing.Size(103, 24);
            this.UpTo1000RadioButton.TabIndex = 25;
            this.UpTo1000RadioButton.TabStop = true;
            this.UpTo1000RadioButton.Text = "Up to 1000";
            this.UpTo1000RadioButton.UseVisualStyleBackColor = true;
            this.UpTo1000RadioButton.CheckedChanged += new System.EventHandler(this.UpTo1000RadioButton_CheckedChanged);
            // 
            // From1000To5000RadioButton
            // 
            this.From1000To5000RadioButton.AutoSize = true;
            this.From1000To5000RadioButton.Location = new System.Drawing.Point(36, 58);
            this.From1000To5000RadioButton.Name = "From1000To5000RadioButton";
            this.From1000To5000RadioButton.Size = new System.Drawing.Size(154, 24);
            this.From1000To5000RadioButton.TabIndex = 24;
            this.From1000To5000RadioButton.TabStop = true;
            this.From1000To5000RadioButton.Text = "From 1000 to 5000";
            this.From1000To5000RadioButton.UseVisualStyleBackColor = true;
            this.From1000To5000RadioButton.CheckedChanged += new System.EventHandler(this.From1000To5000RadioButton_CheckedChanged);
            // 
            // MoreThan5000RadioButton
            // 
            this.MoreThan5000RadioButton.AutoSize = true;
            this.MoreThan5000RadioButton.Location = new System.Drawing.Point(36, 28);
            this.MoreThan5000RadioButton.Name = "MoreThan5000RadioButton";
            this.MoreThan5000RadioButton.Size = new System.Drawing.Size(134, 24);
            this.MoreThan5000RadioButton.TabIndex = 23;
            this.MoreThan5000RadioButton.TabStop = true;
            this.MoreThan5000RadioButton.Text = "More than 5000";
            this.MoreThan5000RadioButton.UseVisualStyleBackColor = true;
            this.MoreThan5000RadioButton.CheckedChanged += new System.EventHandler(this.MoreThan5000RadioButton_CheckedChanged);
            // 
            // FoundImagePictureBox
            // 
            this.FoundImagePictureBox.ImageLocation = "";
            this.FoundImagePictureBox.Location = new System.Drawing.Point(373, 198);
            this.FoundImagePictureBox.Name = "FoundImagePictureBox";
            this.FoundImagePictureBox.Size = new System.Drawing.Size(516, 360);
            this.FoundImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoundImagePictureBox.TabIndex = 13;
            this.FoundImagePictureBox.TabStop = false;
            this.FoundImagePictureBox.Visible = false;
            // 
            // FileFormatRadioButton
            // 
            this.FileFormatRadioButton.AutoSize = true;
            this.FileFormatRadioButton.Location = new System.Drawing.Point(32, 258);
            this.FileFormatRadioButton.Name = "FileFormatRadioButton";
            this.FileFormatRadioButton.Size = new System.Drawing.Size(102, 24);
            this.FileFormatRadioButton.TabIndex = 15;
            this.FileFormatRadioButton.TabStop = true;
            this.FileFormatRadioButton.Text = "File format";
            this.FileFormatRadioButton.UseVisualStyleBackColor = true;
            this.FileFormatRadioButton.CheckedChanged += new System.EventHandler(this.FileFormatRadioButton_CheckedChanged_1);
            // 
            // NumberOfFileColorsRadioButton
            // 
            this.NumberOfFileColorsRadioButton.AutoSize = true;
            this.NumberOfFileColorsRadioButton.Location = new System.Drawing.Point(32, 288);
            this.NumberOfFileColorsRadioButton.Name = "NumberOfFileColorsRadioButton";
            this.NumberOfFileColorsRadioButton.Size = new System.Drawing.Size(146, 24);
            this.NumberOfFileColorsRadioButton.TabIndex = 16;
            this.NumberOfFileColorsRadioButton.TabStop = true;
            this.NumberOfFileColorsRadioButton.Text = "Number of colors";
            this.NumberOfFileColorsRadioButton.UseVisualStyleBackColor = true;
            this.NumberOfFileColorsRadioButton.CheckedChanged += new System.EventHandler(this.NumberOfFileColorsRadioButton_CheckedChanged);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(373, 159);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(87, 20);
            this.ImageLabel.TabIndex = 19;
            this.ImageLabel.Text = "Your image:";
            this.ImageLabel.Visible = false;
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(18, 60);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(116, 29);
            this.SelectFolderButton.TabIndex = 20;
            this.SelectFolderButton.Text = "Select folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "To start work with application please select source folder with images:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentSourceFolderLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SelectFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 136);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // CurrentSourceFolderLabel
            // 
            this.CurrentSourceFolderLabel.AutoSize = true;
            this.CurrentSourceFolderLabel.Location = new System.Drawing.Point(18, 103);
            this.CurrentSourceFolderLabel.Name = "CurrentSourceFolderLabel";
            this.CurrentSourceFolderLabel.Size = new System.Drawing.Size(151, 20);
            this.CurrentSourceFolderLabel.TabIndex = 23;
            this.CurrentSourceFolderLabel.Text = "Current source folder:";
            // 
            // PreviousPictureButton
            // 
            this.PreviousPictureButton.Location = new System.Drawing.Point(373, 569);
            this.PreviousPictureButton.Name = "PreviousPictureButton";
            this.PreviousPictureButton.Size = new System.Drawing.Size(94, 29);
            this.PreviousPictureButton.TabIndex = 27;
            this.PreviousPictureButton.Text = "Previous";
            this.PreviousPictureButton.UseVisualStyleBackColor = true;
            this.PreviousPictureButton.Visible = false;
            this.PreviousPictureButton.Click += new System.EventHandler(this.PreviousPictureButton_Click);
            // 
            // NextPictureButton
            // 
            this.NextPictureButton.Location = new System.Drawing.Point(795, 569);
            this.NextPictureButton.Name = "NextPictureButton";
            this.NextPictureButton.Size = new System.Drawing.Size(94, 29);
            this.NextPictureButton.TabIndex = 28;
            this.NextPictureButton.Text = "Next";
            this.NextPictureButton.UseVisualStyleBackColor = true;
            this.NextPictureButton.Visible = false;
            this.NextPictureButton.Click += new System.EventHandler(this.NextPictureButton_Click);
            // 
            // ImageResolutionGroupBox
            // 
            this.ImageResolutionGroupBox.Controls.Add(this.SmallImageResolutionRadioButton);
            this.ImageResolutionGroupBox.Controls.Add(this.MediumImageResolutionRadioButton);
            this.ImageResolutionGroupBox.Controls.Add(this.BigImageResolutionRadioButton);
            this.ImageResolutionGroupBox.Location = new System.Drawing.Point(20, 342);
            this.ImageResolutionGroupBox.Name = "ImageResolutionGroupBox";
            this.ImageResolutionGroupBox.Size = new System.Drawing.Size(340, 125);
            this.ImageResolutionGroupBox.TabIndex = 26;
            this.ImageResolutionGroupBox.TabStop = false;
            this.ImageResolutionGroupBox.Visible = false;
            // 
            // SmallImageResolutionRadioButton
            // 
            this.SmallImageResolutionRadioButton.AutoSize = true;
            this.SmallImageResolutionRadioButton.Location = new System.Drawing.Point(36, 88);
            this.SmallImageResolutionRadioButton.Name = "SmallImageResolutionRadioButton";
            this.SmallImageResolutionRadioButton.Size = new System.Drawing.Size(190, 24);
            this.SmallImageResolutionRadioButton.TabIndex = 25;
            this.SmallImageResolutionRadioButton.TabStop = true;
            this.SmallImageResolutionRadioButton.Text = "Icons (256x256 and less)";
            this.SmallImageResolutionRadioButton.UseVisualStyleBackColor = true;
            this.SmallImageResolutionRadioButton.CheckedChanged += new System.EventHandler(this.SmallImageResolutionRadioButton_CheckedChanged);
            // 
            // MediumImageResolutionRadioButton
            // 
            this.MediumImageResolutionRadioButton.AutoSize = true;
            this.MediumImageResolutionRadioButton.Location = new System.Drawing.Point(36, 58);
            this.MediumImageResolutionRadioButton.Name = "MediumImageResolutionRadioButton";
            this.MediumImageResolutionRadioButton.Size = new System.Drawing.Size(267, 24);
            this.MediumImageResolutionRadioButton.TabIndex = 24;
            this.MediumImageResolutionRadioButton.TabStop = true;
            this.MediumImageResolutionRadioButton.Text = "Medium (from 257x257 to 999x999)";
            this.MediumImageResolutionRadioButton.UseVisualStyleBackColor = true;
            this.MediumImageResolutionRadioButton.CheckedChanged += new System.EventHandler(this.MediumImageResolutionRadioButton_CheckedChanged);
            // 
            // BigImageResolutionRadioButton
            // 
            this.BigImageResolutionRadioButton.AutoSize = true;
            this.BigImageResolutionRadioButton.Location = new System.Drawing.Point(36, 28);
            this.BigImageResolutionRadioButton.Name = "BigImageResolutionRadioButton";
            this.BigImageResolutionRadioButton.Size = new System.Drawing.Size(173, 24);
            this.BigImageResolutionRadioButton.TabIndex = 23;
            this.BigImageResolutionRadioButton.TabStop = true;
            this.BigImageResolutionRadioButton.Text = "Big (from 1000x1000)";
            this.BigImageResolutionRadioButton.UseVisualStyleBackColor = true;
            this.BigImageResolutionRadioButton.CheckedChanged += new System.EventHandler(this.BigImageResolutionRadioButton_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 610);
            this.Controls.Add(this.ImageResolutionGroupBox);
            this.Controls.Add(this.NextPictureButton);
            this.Controls.Add(this.PreviousPictureButton);
            this.Controls.Add(this.NumberOfColorsGroupBox);
            this.Controls.Add(this.ImageSizeGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.NumberOfFileColorsRadioButton);
            this.Controls.Add(this.FileFormatRadioButton);
            this.Controls.Add(this.FoundImagePictureBox);
            this.Controls.Add(this.OneSearchParameterGroupBox);
            this.Controls.Add(this.ImageResolutionRadioButton);
            this.Controls.Add(this.ImageSizeRadioButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search system";
            this.OneSearchParameterGroupBox.ResumeLayout(false);
            this.OneSearchParameterGroupBox.PerformLayout();
            this.ImageSizeGroupBox.ResumeLayout(false);
            this.ImageSizeGroupBox.PerformLayout();
            this.NumberOfColorsGroupBox.ResumeLayout(false);
            this.NumberOfColorsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ImageResolutionGroupBox.ResumeLayout(false);
            this.ImageResolutionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchButton;
        private Label searchLabel;
        private RadioButton ImageSizeRadioButton;
        private RadioButton ImageResolutionRadioButton;
        private TextBox SearchValueTextBox;
        private GroupBox OneSearchParameterGroupBox;
        private PictureBox FoundImagePictureBox;
        private RadioButton FileFormatRadioButton;
        private RadioButton NumberOfFileColorsRadioButton;
        private Label ImageLabel;
        private Button SelectFolderButton;
        private Label label3;
        private GroupBox groupBox1;
        private Label CurrentSourceFolderLabel;
        private RadioButton BIgImageRadioButton;
        private GroupBox ImageSizeGroupBox;
        private RadioButton SmallPictureSizeRadioButton;
        private RadioButton MediumPictureSizeRadioButton;
        private GroupBox NumberOfColorsGroupBox;
        private RadioButton UpTo1000RadioButton;
        private RadioButton From1000To5000RadioButton;
        private RadioButton MoreThan5000RadioButton;
        private Button PreviousPictureButton;
        private Button NextPictureButton;
        private GroupBox ImageResolutionGroupBox;
        private RadioButton SmallImageResolutionRadioButton;
        private RadioButton MediumImageResolutionRadioButton;
        private RadioButton BigImageResolutionRadioButton;
    }
}