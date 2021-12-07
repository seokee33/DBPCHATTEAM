﻿using System;
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

    public partial class Chatmsg : UserControl
    {
        public Chatmsg(string name, string msg)
        {
            InitializeComponent();
            lb_name.Text = name;
            tb_msg.Text = msg;
        }

    }
}
