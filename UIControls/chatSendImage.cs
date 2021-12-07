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
    public partial class chatSendImage : UserControl
    {
        public chatSendImage(string name, PictureBox pb)
        {
            InitializeComponent();
            lb_name.Text = name;
            pb_Emoticon.Image = pb.Image;
        }
    }
}
