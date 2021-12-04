using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public class EmoticonInfo
    {
        private int _Seq;
        private PictureBox _PB;

        public EmoticonInfo(int seq, PictureBox pB)
        {
            _Seq = seq;
            _PB = pB;
        }

        public int Seq
        {
            get { return _Seq; }
            set { _Seq = value; }
        }
        public PictureBox PB
        {
            get { return _PB; }
            set { _PB = value; }
        }
    }
}
