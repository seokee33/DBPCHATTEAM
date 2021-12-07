using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.UIControls
{
    public partial class Chat_Image : UserControl
    {
        private string name;
        private PictureBox pb;
        public Chat_Image()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return name; }
            set { name = value;lb_name.Text = value; }
        }
        public PictureBox PB
        {
            get { return pb; }
            set { pb = value;  pb_Emoticon.Image= value.Image; }
        }
    }
}
