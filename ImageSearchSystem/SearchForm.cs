using ImageSearchSystem.Models;
using ImageSearchSystem.Services;

namespace ImageSearchSystem
{
    public partial class SearchForm : Form
    {
        private readonly ISearchImageService _searchImageService;
        private SearchParameter _searchCondition;

        private string sourceFolderPath;

        private ImageSize _imageSize;
        private PossibleNumberOfColors _possibleNumberOfColors;

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

            Image? image;

            switch (_searchCondition)
            {
                case SearchParameter.ImageSize:
                    image = _searchImageService.FindImageByFileSize(_imageSize);
                    break;
                case SearchParameter.ImageResolution:
                    image = _searchImageService.FindImageByFileResolution(WidthTextBox.Text, HeightTextBox.Text);
                    break;
                case SearchParameter.FileFormat:
                    image = _searchImageService.FindImageByFileExtension(SearchValueTextBox.Text);
                    break ;
                case SearchParameter.NumberOfColors:
                    image = _searchImageService.FindImageByNumberOfColors(_possibleNumberOfColors);
                    break;
                default:
                    image = null;
                    break;
            }

            if(image == null)
            {
                FoundImagePictureBox.Visible = false;
                ImageLabel.Visible = false;
                MessageBox.Show("Oops! Image was not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FoundImagePictureBox.Visible = true;
            FoundImagePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            FoundImagePictureBox.Image = image;
            ImageLabel.Visible = true;

            Controls.Add(FoundImagePictureBox);
        }

        private void ImageResolutionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageResolutionRadioButton.Checked)
            {
                _searchCondition = SearchParameter.ImageResolution;
                groupBox2.Visible = true;

            }
            else
            {
                groupBox2.Visible = false;
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
    }
}