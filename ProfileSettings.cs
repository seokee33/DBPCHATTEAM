using System;
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
    public partial class ProfileSettings : Form
    {
        public ProfileSettings()
        {
            InitializeComponent();
        }

        private void buttonChangeProfilePoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "( *.bmp; *.jpg; *.png; *.jpeg) | *.BMP; *.JPG; *.PNG; *.JPEG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                roundPictureBoxProfilePoto.Image = Bitmap.FromFile(openFileDialog.FileName);

            }
        }
    }
}
