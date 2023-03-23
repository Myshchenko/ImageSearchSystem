﻿namespace ImageSearchSystem
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.FoundImagePictureBox = new System.Windows.Forms.PictureBox();
            this.FileFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberOfFileColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentSourceFolderLabel = new System.Windows.Forms.Label();
            this.OneSearchParameterGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.ImageSizeRadioButton.Size = new System.Drawing.Size(131, 24);
            this.ImageSizeRadioButton.TabIndex = 10;
            this.ImageSizeRadioButton.TabStop = true;
            this.ImageSizeRadioButton.Text = "Image size (kb)";
            this.ImageSizeRadioButton.UseVisualStyleBackColor = true;
            this.ImageSizeRadioButton.CheckedChanged += new System.EventHandler(this.ImageSizeRadioButton_CheckedChanged);
            // 
            // ImageResolutionRadioButton
            // 
            this.ImageResolutionRadioButton.AutoSize = true;
            this.ImageResolutionRadioButton.Location = new System.Drawing.Point(32, 228);
            this.ImageResolutionRadioButton.Name = "ImageResolutionRadioButton";
            this.ImageResolutionRadioButton.Size = new System.Drawing.Size(142, 24);
            this.ImageResolutionRadioButton.TabIndex = 12;
            this.ImageResolutionRadioButton.TabStop = true;
            this.ImageResolutionRadioButton.Text = "Image resolution";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HeightTextBox);
            this.groupBox2.Controls.Add(this.WidthTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Width:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(96, 81);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(125, 27);
            this.HeightTextBox.TabIndex = 14;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(96, 26);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 13;
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
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.NumberOfFileColorsRadioButton);
            this.Controls.Add(this.FileFormatRadioButton);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private PictureBox FoundImagePictureBox;
        private RadioButton FileFormatRadioButton;
        private RadioButton NumberOfFileColorsRadioButton;
        private Label label1;
        private Label label2;
        private Label ImageLabel;
        private Button SelectFolderButton;
        private Label label3;
        private GroupBox groupBox1;
        private Label CurrentSourceFolderLabel;
    }
}