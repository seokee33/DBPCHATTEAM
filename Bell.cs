using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DBUI
{
    public partial class Bell : Form
    {
        
        #region 높이/위쪽 위치 설정하기 대리자 - SetHeightTopDelegate(flag)

        private delegate void SetHeightTopDelegate(int flag);

        #endregion

        #region Field

        private SetHeightTopDelegate setHeightTopDelegate = null;

        private System.Timers.Timer timer;

        #endregion

        #region 생성자 - NoticeForm()

        public Bell() {
            InitializeComponent();
            this.pictureBoxClose.Click += closePictureBox_Click;
        }

        #endregion

        #region 폼 로드시 처리하기 - Form_Load(sender, e)

        private void Bell_Load(object sender, EventArgs e) {
            setHeightTopDelegate = new SetHeightTopDelegate(SetHeightTop);

            Size = new Size(Size.Width, 0);
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);

            this.timer = new System.Timers.Timer(2);

            this.timer.Elapsed += timer_Elapsed_PopUp;

            this.timer.Start();
        }

        #endregion
        #region 닫기 픽쳐 박스 클릭시 처리하기 - closePictureBox_Click(sender, e)

        private void closePictureBox_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion

        #region 타이머 경과시 처리하기 (팝업용) - timer_Elapsed_PopUp(sender, e)

        private void timer_Elapsed_PopUp(object sender, ElapsedEventArgs e) {
            if (Height < 120) {
                Invoke(setHeightTopDelegate, 0);
            } else {
                this.timer.Stop();

                this.timer.Elapsed -= timer_Elapsed_PopUp;
                this.timer.Elapsed += timer_Elapsed_PopOut;

                this.timer.Interval = 3000;

                this.timer.Start();
            }

            Application.DoEvents();
        }

        #endregion
        #region 타이머 경과시 처리하기 (팝아웃용) - timer_Elapsed_PopOut(sender, e)

        private void timer_Elapsed_PopOut(object sender, ElapsedEventArgs e) {
            while (Height > 2) {
                Invoke(setHeightTopDelegate, 1);
            }

            this.timer.Stop();

            Application.DoEvents();

            Invoke(setHeightTopDelegate, 2);
        }

        #endregion

        #region 높이/위쪽 위치 설정하기 - SetHeightTop(flag)


        private void SetHeightTop(int flag) {
            if (flag == 0) {
                Height++;

                Top--;
            } else if (flag == 1) {
                Height--;

                Top++;
            } else if (flag == 2) {
                Close();
            }
        }

        #endregion


    }
}
