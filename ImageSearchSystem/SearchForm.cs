using ImageSearchSystem.Models;
using ImageSearchSystem.Services;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageSearchSystem
{
    public partial class SearchForm : Form
    {
        private readonly ISearchImageService _searchImageService;
        private SearchParameter _searchCondition;

        private string sourceFolderPath;

        private ImageSize _imageSize;
        private ImageResolution _imageResolution;
        private PossibleNumberOfColors _possibleNumberOfColors;

        int nTotalNumber = 0;
        int nCurrentItem = 0;
        List<Image> images = new List<Image>();

        public SearchForm(ISearchImageService searchImageService)
        {
            _searchImageService = searchImageService;
            sourceFolderPath = string.Empty;
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFolderPath))
            {
                MessageBox.Show("Select source folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_searchCondition)
            {
                case SearchParameter.ImageSize:
                    images = _searchImageService.FindImagesByFileSize(_imageSize);
                    break;
                case SearchParameter.ImageResolution:
                    images = _searchImageService.FindImagesByFileResolution(_imageResolution);
                    break;
                case SearchParameter.FileFormat:
                    images = _searchImageService.FindImagesByFileExtension(SearchValueTextBox.Text);
                    break ;
                case SearchParameter.NumberOfColors:
                    images = _searchImageService.FindImagesByNumberOfColors(_possibleNumberOfColors);
                    break;
                default:
                    break;
            }

            if(images == null || images.Count == 0)
            {
                FoundImagePictureBox.Visible = false;
                ImageLabel.Visible = false;
                MessageBox.Show("Oops! Image was not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FoundImagePictureBox.Visible = true;
            PreviousPictureButton.Visible = true;
            NextPictureButton.Visible = true;
            ImageLabel.Visible = true;

            FoundImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            FoundImagePictureBox.Image = images[0];
            nTotalNumber = images.Count;
            Controls.Add(FoundImagePictureBox);
        }

        private void ImageResolutionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageResolutionRadioButton.Checked)
            {
                _searchCondition = SearchParameter.ImageResolution;
                ImageResolutionGroupBox.Visible = true;

            }
            else
            {
                ImageResolutionGroupBox.Visible = false;
            }
        }

        private void ImageSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageSizeRadioButton.Checked)
            {
                _searchCondition = SearchParameter.ImageSize;
                ImageSizeGroupBox.Visible = true;
            }
            else
            {
                ImageSizeGroupBox.Visible = false;
            }
        }

        private void FileFormatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageSizeRadioButton.Checked)
            {
                _searchCondition = SearchParameter.FileFormat;
                OneSearchParameterGroupBox.Visible = true;
            }
            else
            {
                OneSearchParameterGroupBox.Visible = false;
            }
        }

        private void FileFormatRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (FileFormatRadioButton.Checked)
            {
                _searchCondition = SearchParameter.FileFormat;
                OneSearchParameterGroupBox.Visible = true;
            }
            else
            {
                OneSearchParameterGroupBox.Visible = false;
            }
        }

        private void NumberOfFileColorsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NumberOfFileColorsRadioButton.Checked)
            {
                _searchCondition = SearchParameter.NumberOfColors;
                NumberOfColorsGroupBox.Visible = true;
            }
            else
            {
                NumberOfColorsGroupBox.Visible = false;
            }
        }
        
        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                sourceFolderPath = folderDialog.SelectedPath;
                CurrentSourceFolderLabel.Text += " " + sourceFolderPath;
                _searchImageService.UpoladImages(sourceFolderPath);
            }
        }

        private void BIgImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imageSize = ImageSize.Big;
        }

        private void MediumPictureSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imageSize = ImageSize.Medium;
        }

        private void SmallPictureSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imageSize = ImageSize.Small;
        }

        private void MoreThan5000RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _possibleNumberOfColors = PossibleNumberOfColors.MoreThan5000;
        }

        private void From1000To5000RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _possibleNumberOfColors = PossibleNumberOfColors.From1000To5000;
        }

        private void UpTo1000RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _possibleNumberOfColors = PossibleNumberOfColors.UpTo1000;
        }


        private void BigImageResolutionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imageResolution = ImageResolution.Big;
        }


        private void MediumImageResolutionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imageResolution = ImageResolution.Medium;
        }

        private void SmallImageResolutionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imageResolution = ImageResolution.Small;
        }

        private void PreviousPictureButton_Click(object sender, EventArgs e)
        {
            nCurrentItem--;

            if (nCurrentItem < 0)
            {
                nCurrentItem = 0;
            }
            else if (nCurrentItem < nTotalNumber)
            {
                FoundImagePictureBox.Image = images[nCurrentItem];
            }         
        }

        private void NextPictureButton_Click(object sender, EventArgs e)
        {
            nCurrentItem++;

            if (nCurrentItem > nTotalNumber)
            {
                nCurrentItem = nTotalNumber;
            }
            else if (nCurrentItem < nTotalNumber)
            {
                FoundImagePictureBox.Image = images[nCurrentItem];
            }     
        }
    }
}