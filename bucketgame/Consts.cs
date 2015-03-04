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
namespace BucketGame
{
    class Consts
    {
        /// <summary>
        /// The minimal distance between two object so they would be considered "touching".
        /// </summary>
        public static readonly int TouchingDistance = 55;

        /// <summary>
        /// The width (in pixels) of a frame sent by the Kinect sensor.
        /// </summary>
        public static readonly int FrameWidth = 640;
        
        /// <summary>
        /// The height (in pixels) of a frame sent by the Kinect sensor.
        /// </summary>
        public static readonly int FrameHeight = 640;


        /// <summary>
        /// The distance between the left-top-corners of targets.
        /// </summary>
        public static readonly int DistanceBetweenTargets = 200;
        
        /// <summary>
        /// The minimal distance between two objects that is consider "fair", that is, minimal and yet long enough.
        /// </summary>
        public static readonly double FairDistance = 130;
        
        /// <summary>
        /// The amount of points that scoring is worth
        /// </summary>
        public static readonly int ScorePerShape = 100;
        public static readonly long TicksPerMilisecond = 10000, GameStartingTime = 120000;
        public static readonly JointType[] DefaultJoints = { JointType.HandRight, JointType.HandLeft },
            ReasonableJoints = {JointType.HandLeft, JointType.HandRight, JointType.ElbowLeft, JointType.ElbowRight};
        public static readonly int WantedScore = 10*ScorePerShape;
        public static readonly string RelativeCandy = "imgs\\candy.gif";
        public static readonly string RelativeChocolate = "imgs\\chocolate.png";
        public static readonly string RelativeBalloon = "imgs\\balloon.png";
        
        public static readonly string RelativeCandyBag = "imgs\\candyBag.png";
        public static readonly string RelativeChocolateBag = "imgs\\chocolateBag.png";
        public static readonly string RelativeBalloonBag = "imgs\\balloonBag.png";

        //IT IS VERY IMPORTANT FOR TWO ARRAYS BELOW TO BE IN THE SAME ORDER
        public static readonly string[] ImageObjectPaths = { RelativeBalloon, RelativeCandy, RelativeChocolate };
        public static readonly string[] BagPaths = { RelativeBalloonBag, RelativeCandyBag, RelativeChocolateBag };
              
    }
}
