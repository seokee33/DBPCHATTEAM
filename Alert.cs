﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    public partial class Alert : Form
    {
        public Alert(string name,string msg)
        {
            InitializeComponent();
            showalert(name, msg);
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private Alert.enmAction action;

        private int x, y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 1;
            //action = enmAction.close;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showalert(string name, string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i =0; i<10; i++)
            {
                fname = "alert" + i.ToString();
                Alert frm = (Alert)Application.OpenForms[fname];

                if(frm == null)
                {
                    this.Name = fname;
                    //this.x = 100;
                    //this.y = 200;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                    //this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(x, y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            try
            {
                //lb_Name.BeginInvoke(new Action(() =>
                //{
                //    this.lb_Name.Text = name;
                //}));
                //lb_Msg.BeginInvoke(new Action(() =>
                //{
                //    this.lb_Msg.Text = msg;
                //}));
                this.lb_Name.Text = name;
                this.lb_Msg.Text = msg;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;

            timer1.Start();


        }
    }
}
