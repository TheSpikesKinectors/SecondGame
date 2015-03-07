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
        
        /// <summary>
        /// The score saved and showed on the screen
        /// </summary>
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

        /// <summary>
        /// The time that elapsed in MS
        /// </summary>
        public long TimeElapsedMS
        {
            get
            {
                return (DateTime.Now.Ticks - TimeStarted) / Consts.TicksPerMilisecond;
            }
        }

        /// <summary>
        /// The time that elapsed as a string
        /// </summary>
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

        /// <summary>
        /// Updates the label showing the current time
        /// </summary>
        public void UpdateCurrentTime()
        {
            LabelTime.Content = "Time: " + TimeString;
        }


        /// <summary>
        /// 
        /// </summary>
        public Status()
        {
            InitializeComponent();
            Left = 700;
        }

        /// <summary>
        /// The content of the Extra label in the window
        /// </summary>
        public string ExtraInfo
        {
            get { return LabelNothing.Content.ToString(); }
            set { LabelNothing.Content = value; }
        }


        /// <summary>
        /// The joint shown by the window
        /// </summary>
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


        private void sliderTouchingDistance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelTouchingDistance.Content = "מרחק מינימלי לנגיעה: " + sliderTouchingDistance.Value;
        }

        public double TouchingDistance
        {
            get
            {
                return sliderTouchingDistance.Value;
            }
        }

    }
}
