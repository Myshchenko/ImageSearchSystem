using ImageSearchSystem.Models;
using Microsoft.Extensions.Configuration;
using System.Drawing.Imaging;

namespace ImageSearchSystem.Services
{
    public interface ISearchImageService
    {
        public void UpoladImages(string filePath);

        public List<Image> FindImagesByFileSize(ImageSize parameter);

        public List<Image> FindImagesByFileResolution(ImageResolution imageResolution);

        public List<Image> FindImagesByFileExtension(string fileExtension);

        public List<Image> FindImagesByNumberOfColors(PossibleNumberOfColors possibleNumberOfColors);
    }

    public class SearchImageService : ISearchImageService
    {
        private readonly List<Image> _imagesList;

        private string _sourceFolderPath { get; set; }

        public SearchImageService()
        {
            _imagesList = new List<Image>();
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

                        _imagesList.Add(image);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Image> FindImagesByFileSize(ImageSize parameter)
        {
            var filePaths = GetFilePaths();

            var images = new List<Image>();

            foreach (var path in filePaths)
            {
                byte[] byteData = File.ReadAllBytes(path);

                float mb = (byteData.Length / 1024f) / 1024f;

                switch (parameter)
                {
                    case ImageSize.Big:
                        if (mb > 3) images.Add(ConvertBytesToImage(byteData));
                        break;
                    case ImageSize.Medium:
                        if (mb >= 1 && mb <=3) images.Add(ConvertBytesToImage(byteData));
                        break;
                    case ImageSize.Small:
                        if (mb < 0.5) images.Add(ConvertBytesToImage(byteData));
                        break;
                    default:
                        break;
                }
            }

            return images;
        }

        private Image ConvertBytesToImage(byte[] byteData)
        {
            using (MemoryStream ms = new MemoryStream(byteData))
            {
                return Image.FromStream(ms);
            }
        }

        public List<Image> FindImagesByFileResolution(ImageResolution imageResolution)
        {
            var images = new List<Image>();

            foreach (var item in _imagesList)
            {
                switch (imageResolution)
                {
                    case ImageResolution.Small:
                        if (item.Height <= 256 || item.Width <=256) images.Add(item);
                        break;
                    case ImageResolution.Medium:
                        if ((item.Height > 256 || item.Width > 256) && (item.Height <= 999 || item.Width <= 999)) images.Add(item);
                        break;
                    case ImageResolution.Big:
                        if (item.Height >= 1000 || item.Width >= 1000) images.Add(item);
                        break;
                    default:
                        break;
                }
            }

            return images;
        }

        public List<Image> FindImagesByFileExtension(string fileExtension)
        {
            if (string.IsNullOrEmpty(fileExtension))
            {
                return new List<Image>();
            }

            var imageFormat = ParseImageFormat(new String(fileExtension.Where(Char.IsLetter).ToArray()));

            if (imageFormat == null)
            {
                return new List<Image>();
            }

            return _imagesList.Where(x => x.RawFormat.Equals(imageFormat)).ToList();
        }

        public List<Image> FindImagesByNumberOfColors(PossibleNumberOfColors possibleNumberOfColors)
        {
            var images = new List<Image>();

            foreach (var item in _imagesList)
            {
                var color = GetUniqueColorCount(item);

                switch (possibleNumberOfColors)
                {
                    case PossibleNumberOfColors.MoreThan5000:
                        if (color > 5000) images.Add(item);
                        break;
                    case PossibleNumberOfColors.From1000To5000:
                        if (color >= 1000 && color <= 5000) images.Add(item);
                        break;
                    case PossibleNumberOfColors.UpTo1000:
                        if (color < 1000) images.Add(item);
                        break;
                    default:
                        break;
                }
            }

            return images;
        }

        private ImageFormat? ParseImageFormat(string stringImageFormat)
        {
            switch (stringImageFormat.ToLower())
            {
                case "bmp":
                    return ImageFormat.Bmp;
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
