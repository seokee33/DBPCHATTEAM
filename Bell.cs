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

        //////////////////////////////////////////////////////////////////////////////////////////////////// Delegate
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region 높이/위쪽 위치 설정하기 대리자 - SetHeightTopDelegate(flag)

        /// <summary>
        /// 높이/위쪽 위치 설정하기 대리자
        /// </summary>
        /// <param name="flag">플래그</param>
        private delegate void SetHeightTopDelegate(int flag);

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 높이/위쪽 위치 설정하기 대리자
        /// </summary>
        private SetHeightTopDelegate setHeightTopDelegate = null;

        /// <summary>
        /// 타이머
        /// </summary>
        private System.Timers.Timer timer;


        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - NoticeForm()

        /// <summary>
        /// 생성자
        /// </summary>
        public Bell() {
            InitializeComponent();

            this.pictureBoxClose.Click += closePictureBox_Click;

        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Private
        //////////////////////////////////////////////////////////////////////////////// Event

        #region 폼 로드시 처리하기 - Form_Load(sender, e)

        /// <summary>
        /// 폼 로드시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        /// 
        private void Bell_Load(object sender, EventArgs e) {
            setHeightTopDelegate = new SetHeightTopDelegate(SetHeightTop);

            Size = new Size(300, 0);
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 20, Screen.PrimaryScreen.WorkingArea.Height - Height);


            this.timer = new System.Timers.Timer(2);

            this.timer.Elapsed += timer_Elapsed_PopUp;

            this.timer.Start();
        }

        #endregion
        #region 닫기 픽쳐 박스 클릭시 처리하기 - closePictureBox_Click(sender, e)

        /// <summary>
        /// 닫기 픽처 박스 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void closePictureBox_Click(object sender, EventArgs e) {
            Close();
        }


        #endregion

        #region 타이머 경과시 처리하기 (팝업용) - timer_Elapsed_PopUp(sender, e)

        /// <summary>
        /// 타이머 경과시 처리하기 (팝업용)
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
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

        /// <summary>
        /// 타이머 경과시 처리하기 (팝아웃용)
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void timer_Elapsed_PopOut(object sender, ElapsedEventArgs e) {
            while (Height > 2) {
                Invoke(setHeightTopDelegate, 1);
            }

            this.timer.Stop();

            Application.DoEvents();

            Invoke(setHeightTopDelegate, 2);
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////// Function

        #region 높이/위쪽 위치 설정하기 - SetHeightTop(flag)

        /// <summary>
        /// 높이/위쪽 위치 설정하기
        /// </summary>
        /// <param name="flag">플래그</param>
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

        //public Bell() {
        //    InitializeComponent();
        //}
        //#region 상단부분
        //private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        this.panelBorder.Capture = false;

        //        const int WM_NCLBUTTONDOWN = 0x00A1;
        //        const int HTCAPTION = 2;

        //        Message message = Message.Create(Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);

        //        DefWndProc(ref message);
        //    }
        //}

        //private void pictureBoxClose_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //#endregion


    }
}
