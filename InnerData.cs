using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class InnerData
    {
        private InnerData() { }
        private static InnerData instance_ = new InnerData();
        public static InnerData getInstance()
        {
            return instance_;
        }


    }
}
