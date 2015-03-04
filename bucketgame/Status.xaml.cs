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
using System.Windows.Shapes;
using Microsoft.Kinect;
namespace BucketGame
{
    /// <summary>
    /// Interaction logic for Status.xaml
    /// </summary>
    public partial class Status : Window
    {
        private int score;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                LabelScore.Content = " Score: " + Score;
            }
        }

        public long TimeStarted;
        public long TimeElapsedMS
        {
            get
            {
                return (DateTime.Now.Ticks - TimeStarted) / Consts.TicksPerMilisecond;
            }
        }
        public string TimeString
        {
            get
            {
                long ms = TimeElapsedMS;
                long centies = ms % 1000 / 10;
                long secs = ms / 1000 % 60;
                long minutes = ms / 1000 / 60;
                return Util.Stringify(minutes) + ":" + Util.Stringify(secs) + "." + Util.Stringify(centies);
            }
        }

        public void UpdateCurrentTime()
        {
            LabelTime.Content = "Time: " + TimeString;
        }

        public Status()
        {
            InitializeComponent();
            Left = 700;
        }

        public string ExtraInfo
        {
            get { return LabelNothing.Content.ToString(); }
            set { LabelNothing.Content = value; }
        }

        public JointType Joint
        {
            set
            {
                if (value.ToString().Equals("HandLeft"))
                {
                    LabelJoint.Content = "!יד שמאל";
                }
                else if (value.ToString().Equals("HandRight"))
                {
                    LabelJoint.Content = "!יד ימין";
                }
                else
                {
                    LabelJoint.Content = "Use " + value;
                }
            }
        }

    }
}
