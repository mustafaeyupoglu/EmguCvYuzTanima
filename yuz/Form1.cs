using System;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace yuz
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        Capture webcam;
        CascadeClassifier haar;
        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new Capture(0);
            haar = new CascadeClassifier("haarcascade_frontalface_default.xml");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> binaryGoruntu = webcam.QueryFrame().ToImage<Bgr, Byte>())
            {
                if (binaryGoruntu != null)
                {
                    Image<Gray, byte> greyScaleGoruntu = binaryGoruntu.Convert<Gray, byte>();// binary görüntüyü greyscale e dönüştürüyor.
                    Rectangle[] rectangles = haar.DetectMultiScale(greyScaleGoruntu, 1.4, 1, new Size(100, 100), new Size(800, 800));//grey scale görüntüyü haar dosyası ile tarayarak yüzleri buluyor.
                    foreach (var face in rectangles)
                    {
                        binaryGoruntu.Draw(face, new Bgr(0, double.MaxValue, 0), 3);
                    }
                    pictureBox1.Image = binaryGoruntu.ToBitmap();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
       }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = null;
        }
    }
}
