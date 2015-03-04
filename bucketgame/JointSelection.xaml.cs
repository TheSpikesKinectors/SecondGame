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
    /// Interaction logic for JointSelection.xaml
    /// </summary>
    public partial class JointSelection : Window
    {
        private List<CheckBox> checkboxes = new List<CheckBox>();
        public static readonly List<JointType> Joints = Consts.ReasonableJoints.ToList();//Util.GetValues<JointType>().ToList();
        MainWindow parent;
        public JointSelection(MainWindow parent)
        {
            this.parent = parent;
            Top = 0;
            Left = 0;
            InitializeComponent();
            foreach (JointType joint in Joints)
            {
                CheckBox cb = new CheckBox();
                cb.Content = joint.ToString();
                checkboxes.Add(cb);
                if (Consts.DefaultJoints.Contains(joint))
                {
                    cb.IsChecked = true;
                }
                else
                {
                    cb.IsChecked = false;
                }
                Panel.Children.Add(cb);
                Label label = new Label();
                label.Content = "        ";
                Panel.Children.Add(label);
                cb.Checked += cb_Checked;
                
            }
        }

        void cb_Checked(object sender, RoutedEventArgs e)
        {
            parent.ChangeJoint();
        }
        public List<JointType> Selected
        {
            get
            {
                List<JointType> ret = new List<JointType>();
                int i = 0;
                foreach(JointType joint in Joints)
                {
                    if(checkboxes[i].IsChecked.HasValue)
                    {
                        if ((bool) checkboxes[i].IsChecked)
                        {
                            ret.Add(joint);   
                        }
                    }
                    i++;
                }
                return ret;
            }
        }

        private void AllBits_Click(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox cb in checkboxes)
            {
                cb.IsChecked = true;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            foreach (JointType joint in Joints)
            {
                CheckBox cb = checkboxes[i];
                if (Consts.DefaultJoints.Contains(joint))
                {
                    cb.IsChecked = true;
                }
                else
                {
                    cb.IsChecked = false;
                }
                i++;

            }
        }

    }
}
