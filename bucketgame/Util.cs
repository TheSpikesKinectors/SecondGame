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
using Microsoft.Kinect;
using System.IO;
namespace BucketGame
{
    /// <summary>
    /// This class contains util functions that could be used everywhere. 
    /// </summary>
    static class Util
    {
        /// <summary>
        /// this method creates and returns a random point with a fair distance
        /// from the point given, given what a fair distance IS.
        /// </summary>
        /// <param name="random">The randomizator object, using which the method generates the point</param>
        /// <param name="p">the point from which the generated point should be away</param>
        /// <param name="fairDistance">the minimum distance the generated point should have from
        /// the given point</param>
        /// <returns>a random point fairly away from the given point</returns>
        public static Point RandomPointWithFairDistanceFrom(this Random random,Point p, double fairDistance)
        {
            Point ran;
            do
            {
                ran = random.RandomPoint();
            } while (Util.Distance(ran, p) <= fairDistance);
            return ran;
        }

        /// <summary>
        /// Creates a random point using the Randomizator object, limited to the frame from the Kinect.
        /// </summary>
        /// <param name="random">the randomizator object</param>
        /// <returns>A random point, whose location is limited to the frame from the Kinect</returns>
        public static Point RandomPoint(this Random random)
        {
            Point p = new Point(random.Next(Consts.FrameWidth - 100), random.Next(Consts.FrameHeight - 100));
            return p;
        }
        
        /// <param name="random">the randomizator object</param>
        /// <returns>a random point at the top half of the frame from the Kinect sensor</returns>
        public static Point RandomPointAtTopHalfOfScreen(Random random)
        {
            return new Point(random.Next(Consts.TargetDiameter/2,Consts.FrameWidth-Consts.TargetDiameter/2), random.Next(0,Consts.FrameHeight / 2));
        }
       
        /// <summary>
        /// draws a color frame on an image object (WPF image)
        /// </summary>
        /// <param name="colorFrame">the color frame from the Kinect sensor</param>
        /// <param name="image">the image to draw the image on</param>
        public static void DrawOnImage(this ColorImageFrame colorFrame, Image image)
        {
            if (colorFrame == null || image == null)
            {
                throw new ArgumentNullException("Value cannot be null");
            }
            byte[] pixels = new byte[colorFrame.PixelDataLength];
            colorFrame.CopyPixelDataTo(pixels);
            int stride = colorFrame.Width * 4;
            image.Source = BitmapSource.Create(colorFrame.Width, colorFrame.Height, 96, 96, PixelFormats.Bgr32, null, pixels, stride);
        }


       
         /// <summary>
         /// Rounds the given number to the percision of 3 decimal points.
         /// </summary>
         /// <param name="num">The number to round</param>
         /// <returns>The rounded number</returns>
        public static float Round(this float num)
        {
            return ((int)(num * 1000)) / 1000.0f;
        }

        /// <summary>
        /// This generates a Point object with the coordinates of the given joint on a given skeleton
        /// </summary>
        /// <param name="skel">The skeleton of the player</param>
        /// <param name="joint">The joint to map from the skeleton</param>
        /// <param name="depth">A DepthImageFrame recieved from the sensor</param>
        /// <returns></returns> 
        public static Point GetPoint(this Skeleton skel, JointType joint, DepthImageFrame depth)
        {
           SkeletonPoint point = skel.Joints[joint].Position;
           if (depth == null)
           {
               MessageBox.Show("depth null");
           }
           if (point == null)
           {
               MessageBox.Show("point null");
           }
           DepthImagePoint dip = depth.MapFromSkeletonPoint(point);
           return new Point(dip.X, dip.Y);
        }

        /// <summary>
        /// This method return a point of the top left corner of an object, given its center point
        /// </summary>
        /// <param name="centerPoint">the point of the center of the object</param>
        /// <returns>the coordinates of the top left corner of the object</returns>
        public static Point FromCenterPointToTopLeftPoint(Point centerPoint)
        {
            return new Point(centerPoint.X - Consts.TargetDiameter/2, centerPoint.Y - Consts.TargetDiameter/2);
        }

        /// <summary>
        /// return the distance between two given points.
        /// </summary>
        /// <param name="p1">the first point</param>
        /// <param name="p2">the second point</param>
        /// <returns>the distance between the two given points</returns>
        public static double Distance(this Point p1, Point p2)
        {
            double dx = p2.X - p1.X, dy = p2.Y - p1.Y;
            return Math.Sqrt(dx*dx + dy*dy);
        }

        /// <summary>
        /// converts a dynamic-type object, that  has int property of X,Y
        /// to a point object.
        /// </summary>
        /// <param name="point">the dynamic-type object, that has int
        /// properties of X,Y</param>
        /// <returns>a Point object with the corresponding coordinates</returns>
        public static Point ToPoint(dynamic point)
        {
            return new Point(point.X, point.Y);
        }

        /// <summary>
        /// convers a time in MS to time in CS-Ticks.
        /// </summary>
        /// <param name="ms">the time in MS</param>
        /// <returns>the time in units of CS-Ticks</returns>
        public static long Miliseconds(this long ms) //THIS LONG HAHA
        {
            return ms * Consts.TicksPerMilisecond;
        }
        /// <summary>
        /// convers a time in seconds to time in CS-Ticks.
        /// </summary>
        /// <param name="ms">the time in seconds</param>
        /// <returns>the time in units of CS-Ticks</returns>
        public static long Seconds(this long secs)
        {
            return Miliseconds(secs) * 1000;
        }
        /// <summary>
        /// gets a time unit and converts it to a string
        /// </summary>
        /// <param name="time">a time (for example - 9, for 9 seconds)</param>
        /// <returns>the time as a string (for example, if 
        /// the paramter is 9, returns "09"</returns>
        public static string Stringify(this long time)
        {
            return time < 10 ? "0" + time : "" + time;
        }

        /// <summary>
        /// Sums a list of doubles.
        /// </summary>
        /// <param name="list">a list of doubles</param>
        /// <returns>the list's sum</returns>
        public static double Sum(this List<double> list)
        {
            double sum = 0;
            foreach(double d in list)
            {
                sum += d;
            }
            return sum;
        }

        /// <summary>
        /// Avarages a list of doubles.
        /// </summary>
        /// <param name="list">a list of doubles</param>
        /// <returns>the list's avarage</returns>
        public static double Avg(this List<double> list)
        {
            return list.Sum() / list.Count;
        }

        /// <summary>
        /// Checks and returns if the given value is NaN
        /// </summary>
        /// <param name="x">The value to check is is NaN</param>
        /// <returns>true if the value is NaN, false otherwise</returns>
        public static bool IsNaN(this double x)
        {
            return x != x; //because NaN != NaN. Because FUCK YOU, that's why!
            //Also, ignore this green squigly line below the "x ,
            //it is an illusion and this dress is actually black and blue.
        }

        /// <summary>
        /// Returns an IEnumerable of the enum values.
        /// </summary>
        /// <typeparam name="T">An enum type</typeparam>
        /// <returns>An IEnumerable of the enum values</returns>
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
        
        /// <summary>
        /// chooses a random element from a list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="list">The list of elements to choose from</param>
        /// <param name="rand">The randomizator</param>
        /// <returns>A random element from the array</returns>
        public static T ChooseRandom<T>(this List<T> list, Random rand)
        {
            return list[rand.Next(list.Count)];
        }

        public static void MoveTo(this UIElement elem, Point point) //moves the given UIElement to the given point
        {
            Canvas.SetLeft(elem, point.X);
            Canvas.SetTop(elem, point.Y);
        }

        /// <summary>
        /// Makes the media player open the file given by its relative path
        /// </summary>
        /// <param name="mediaPlayer">the media player that should open the file</param>
        /// <param name="relativePath">the relative path of the file</param>
        public static void OpenFromRelativePath(this MediaPlayer mediaPlayer, string relativePath)
        {
            if (!relativePath.StartsWith("../../"))
            {
                relativePath = "../../" + relativePath;
            }
            mediaPlayer.Open((new Uri(relativePath, UriKind.Relative)));
            //if doesn't work, try adding @ before relativePath in this line ^
        }
    }
}
