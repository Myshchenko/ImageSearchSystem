using ImageSearchSystem.Models;
using Microsoft.Extensions.Configuration;
using System.Drawing.Imaging;

namespace ImageSearchSystem.Services
{
    public interface ISearchImageService
    {
        public void UpoladImages(string filePath);

        public Image? FindImageByFileSize(ImageSize parameter);

        public Image? FindImageByFileResolution(string width, string height);

        public Image? FindImageByFileExtension(string fileExtension);

        public Image? FindImageByNumberOfColors(PossibleNumberOfColors possibleNumberOfColors);
    }

    public class SearchImageService : ISearchImageService
    {
        private readonly List<Image> _imagesAsImages;

        private string _sourceFolderPath { get; set; }

        public SearchImageService()
        {
            _imagesAsImages = new List<Image>();
            _sourceFolderPath = string.Empty;
        }

        public void UpoladImages(string pathToDirectoryWithImages)
        {
            try
            {
                _sourceFolderPath = pathToDirectoryWithImages;

                var filePaths = GetFilePaths();

                foreach (var path in filePaths)
                {
                    byte[] byteData = File.ReadAllBytes(path);

                    using (MemoryStream ms = new MemoryStream(byteData))
                    {
                        Image image = Image.FromStream(ms);

                        _imagesAsImages.Add(image);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Image? FindImageByFileSize(ImageSize parameter)
        {
            var filePaths = GetFilePaths();

            foreach (var path in filePaths)
            {
                byte[] byteData = File.ReadAllBytes(path);

                float mb = (byteData.Length / 1024f) / 1024f;

                switch (parameter)
                {
                    case ImageSize.Big:
                        if (mb > 3) return ConvertBytesToImage(byteData);
                        break;
                    case ImageSize.Medium:
                        if (mb >= 1 && mb <=3) return ConvertBytesToImage(byteData);
                        break;
                    case ImageSize.Small:
                        if (mb < 0.5) return ConvertBytesToImage(byteData);
                        break;
                    default:
                        return null;
                }
            }

            return null;
        }

        private Image ConvertBytesToImage(byte[] byteData)
        {
            using (MemoryStream ms = new MemoryStream(byteData))
            {
                return Image.FromStream(ms);
            }
        }

        public Image? FindImageByFileResolution(string width, string height)
        {
            if(string.IsNullOrEmpty(width) || string.IsNullOrEmpty(height))
            {
                return null;
            }

            if(!width.All(Char.IsDigit) || !height.All(Char.IsDigit))
            {
                return null;
            }

            return _imagesAsImages.FirstOrDefault(image => image.Height == Convert.ToInt32(height) && image.Width == Convert.ToInt32(width));
        }

        public Image? FindImageByFileExtension(string fileExtension)
        {
            if (string.IsNullOrEmpty(fileExtension))
            {
                return null;
            }

            var imageFormat = ParseImageFormat(new String(fileExtension.Where(Char.IsLetter).ToArray()));

            if (imageFormat == null)
            {
                return null;
            }

            return _imagesAsImages.FirstOrDefault(x => x.RawFormat.Equals(imageFormat));
        }

        public Image? FindImageByNumberOfColors(PossibleNumberOfColors possibleNumberOfColors)
        {
            foreach (var item in _imagesAsImages)
            {
                var color = GetUniqueColorCount(item);

                switch (possibleNumberOfColors)
                {
                    case PossibleNumberOfColors.MoreThan5000:
                        if (color > 5000) return item;
                        break;
                    case PossibleNumberOfColors.From1000To5000:
                        if (color >= 1000 && color <= 5000) return item;
                        break;
                    case PossibleNumberOfColors.UpTo1000:
                        if (color < 1000) return item;
                        break;
                    default:
                        return null;
                }
            }

            return null;
        }

        private ImageFormat? ParseImageFormat(string stringImageFormat)
        {
            switch (stringImageFormat.ToLower())
            {
                case "bmp":
                    return ImageFormat.Bmp;
                case "gif":
                    return ImageFormat.Gif;
                case "jpeg":
                case "jpg":
                    return ImageFormat.Jpeg;
                case "png":
                    return ImageFormat.Png;
                case "tif":
                case "tiff":
                    return ImageFormat.Tiff;
                default:
                    return null;
            }
        }

        private static int GetUniqueColorCount(Image image)
        {
            HashSet<Color> colors = new HashSet<Color>();

            Bitmap bmp = new Bitmap(image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    colors.Add(pixelColor);
                }
            }

            return colors.Count;
        }

        private string[] GetFilePaths()
        {
            if (string.IsNullOrEmpty(_sourceFolderPath))
            {
                return new string[] { };
            }

            return Directory.GetFiles(_sourceFolderPath, "*", SearchOption.AllDirectories);
        }
    }
}
