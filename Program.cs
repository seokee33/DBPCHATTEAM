﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if(Setting.GetInstance().Auto_Login())
            //    Application.Run(new FriendList());
            //else
            //    Application.Run(new Login());
            Application.Run(new Login());
        }
    }
}
