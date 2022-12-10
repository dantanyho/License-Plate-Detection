using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.ImgHash;
using System.Globalization;
using System.Collections.Generic;
using System;
using Emgu.CV.Cuda;

namespace License_Plate_Detection
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> img = null;
        Image<Gray, Byte> gray_img = null;
        Image<Gray, Byte> binary_img = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, Byte>(opendlg.FileName);

                pictureBox1.Image = img.ToBitmap();
            }
        }

        private void Gray_btn_Click(object sender, EventArgs e)
        {
            gray_img = new Image<Gray, Byte>(img.Width, img.Height);
            int i, j;
            double gray_value;

            for (i = 0; i < gray_img.Height; i++)
            {
                for (j = 0; j < gray_img.Width; j++)
                {
                    gray_value = 0.299 * img.Data[i, j, 2]
                                + 0.587 * img.Data[i, j, 1]
                                + 0.114 * img.Data[i, j, 0];

                    gray_img.Data[i, j, 0] = (Byte)gray_value;
                }
            }

            pictureBox2.Image = gray_img.ToBitmap();
        }

        private void Otsu_btn_Click(object sender, EventArgs e)
        {
            binary_img = new Image<Gray, Byte>(gray_img.Width, gray_img.Height);
            float[] hist = new float[256];
            int i, j, t;
            float total = 0, sum = 0, sumB = 0, wB = 0, wF = 0, varMax = 0, threshold = 0;
            float totalpixel = (float) (gray_img.Height * gray_img.Width);


            if (gray_img != null)
            {
                for (t = 0; t < hist.Length; t++)
                {
                    for (i = 0; i < gray_img.Height; i++)
                    {
                        for (j = 0; j < gray_img.Width; j++)
                        {
                            if ( t == gray_img.Data[i, j, 0])
                            {
                                hist[t]++;
                            }
                        }
                    }

                    //System.Diagnostics.Debug.WriteLine(hist[t]);
                }

                for (t = 0; t < hist.Length; t++) total += t * hist[t];

                for (t = 0; t < hist.Length; t++)
                {
                    //sumB += hist[t];
                    //wB = sumB / totalpixel;
                    //float mB = (t * hist[t]) / sumB;

                    //sumF = totalpixel - sumB;
                    //wF = sumF / totalpixel;
                    //float mF = (total - t * hist[t]) / sumF;

                    //float varBetween = wB * wF * (mB - mF) * (mB - mF);

                    //if (varBetween > varMax)
                    //{
                    //    varMax = varBetween;
                    //    threshold = t;
                    //}

                    sum += t * hist[t];
                    wB += hist[t];
                    wF = (gray_img.Width * gray_img.Height) - wB;

                    sumB += t * hist[t];

                    float mB = sumB / wB;
                    float mF = (sum - sumB) / wF;

                    float varBetween = wB * wF * (mB - mF) * (mB - mF);

                    if (varBetween > varMax)
                    {
                        varMax = varBetween;
                        threshold = t;
                    }
                }

                for (i = 0; i < gray_img.Height; i++)
                {
                    for (j = 0; j < gray_img.Width; j++)
                    {
                        if (gray_img.Data[i, j, 0] < threshold) binary_img.Data[i, j, 0] = 0;
                        else binary_img.Data[i, j, 0] = 255;
                    }
                }

                pictureBox1.Image = binary_img.ToBitmap();
            }
        }
    }
}