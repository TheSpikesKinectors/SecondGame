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
        public static readonly int ShapeRadius = 50, TouchingDistance = 55, NumberOfTargets = 3,
            FrameWidth = 640, FrameHeight = 480, PortalSize = 100,
            DistanceBetweenPortals = 200;
        
        public static readonly double FairDistance = 130, GoodLinePercision = 0;
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
