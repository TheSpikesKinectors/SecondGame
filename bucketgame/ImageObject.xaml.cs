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
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class ImageObject : UserControl
    {
        public ImageObject(String relativePath, int width, int height)
        {
            InitializeComponent();
            SetRelativeSource(relativePath);
            grid.Width = width;
            grid.Height = height;
        }

        public void SetRelativeSource(String RelativePath)
        {
            image.Source = new BitmapImage(new Uri(RelativePath, UriKind.Relative));
        }

        public void SetAbsoluteSource(String AbsolutePath)
        {
            image.Source = new BitmapImage(new Uri(AbsolutePath, UriKind.Absolute));
        }

    }
}
