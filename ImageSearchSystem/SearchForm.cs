using ImageSearchSystem.Models;
using ImageSearchSystem.Services;

namespace ImageSearchSystem
{
    public partial class SearchForm : Form
    {
        private readonly ISearchImageService _searchImageService;
        private SearchParameter _searchCondition;

        public SearchForm(ISearchImageService searchImageService)
        {
            _searchImageService = searchImageService;
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            _searchImageService.UpoladImages();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Image? image;

            switch (_searchCondition)
            {
                case SearchParameter.ImageSize:
                    image = _searchImageService.FindImageByFileSize(SearchValueTextBox.Text);
                    break;
                case SearchParameter.ImageResolution:
                    image = _searchImageService.FindImageByFileResolution(WidthTextBox.Text, HeightTextBox.Text);
                    break;
                case SearchParameter.FileFormat:
                    image = _searchImageService.FindImageByFileExtension(SearchValueTextBox.Text);
                    break ;
                case SearchParameter.NumberOfColors:
                    image = _searchImageService.FindImageByNumberOfColors(SearchValueTextBox.Text);
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
                OneSearchParameterGroupBox.Visible = true;
            }
            else
            {
                OneSearchParameterGroupBox.Visible = false;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                _searchCondition = SearchParameter.NumberOfColors;
                OneSearchParameterGroupBox.Visible = true;
            }
            else
            {
                OneSearchParameterGroupBox.Visible = false;
            }
        }
    }
}