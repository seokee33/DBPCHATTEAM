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
    public partial class Emoticonitem : UserControl
    {
        private int _Seq;
        private PictureBox _PB;
        public Emoticonitem()
        {
            InitializeComponent();
        }
        public int Seq
        {
            get { return this._Seq; }
            set { _Seq = value; }
        }
        public PictureBox PB
        {
            get { return this._PB; }
            set { _PB = value; }
        }
    }
}
