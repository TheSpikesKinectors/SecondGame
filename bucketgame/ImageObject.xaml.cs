using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BucketGame
{
    /// <summary>
    /// This object lets you place an image on the screen with ease.
    /// </summary>
    public partial class ImageObject : UserControl
    {
        /// <summary>
        /// Creates an ImageObject by a relative path to the image and its dimensions
        /// </summary>
        /// <param name="relativePath">the relative path to the image</param>
        /// <param name="width">the width of the ImageObject wanted</param>
        /// <param name="height">the height of the ImageObject wanted</param>
        public ImageObject(String relativePath, int width, int height)
        {
            InitializeComponent();
            RelativePath = relativePath;
            grid.Width = width;
            grid.Height = height;
        }

        /// <summary>
        /// The relative path of the image
        /// </summary>
        public string RelativePath
        {
            set
            {
                image.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

        public string AbsolutePath
        {
            set
            {
                image.Source = new BitmapImage(new Uri(value, UriKind.Absolute));
            }
        }


    }
}
