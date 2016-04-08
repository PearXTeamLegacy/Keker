using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using PearXLib.Engine.Flat;

namespace Keker
{
    public partial class Main : FlatForm
    {
        public Main()
        {
            InitializeComponent();
            Color c = Color.FromArgb(241, 196, 15);
            TextColor = c;
            btnSave.ForeColor = Color.White;
            btnOpen.ForeColor = Color.White;
            useAlternative.ForeColor = Color.White;
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            dgOpen.ShowDialog();
        }

        private Bitmap kek;

        private void dgOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Bitmap main = new Bitmap(Image.FromFile(dgOpen.FileName));
            kek = new Bitmap(main.Width, main.Height);
            Graphics gr = Graphics.FromImage(kek);
            if (!useAlternative.Checked)
            {
                var v = main.Clone(new Rectangle(0, 0, main.Width / 2, main.Height), main.PixelFormat);
                gr.DrawImage(v, 0, 0);
                v.RotateFlip(RotateFlipType.RotateNoneFlipX);
                gr.DrawImage(v, v.Width, 0);
            }
            else
            {
                var v = main.Clone(new Rectangle(main.Width / 2, 0, main.Width / 2, main.Height), main.PixelFormat);
                gr.DrawImage(v, v.Width, 0);
                v.RotateFlip(RotateFlipType.RotateNoneFlipX);
                gr.DrawImage(v, 0, 0);
            }
            imgKek.Image = kek;
            main.Dispose();
            btnSave.Visible = true;
        }

        private void dgSave_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(File.Exists(dgSave.FileName))
                File.Delete(dgSave.FileName);
            kek.Save(dgSave.FileName, ImageFormat.Png);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            dgSave.ShowDialog();
        }
    }
}
