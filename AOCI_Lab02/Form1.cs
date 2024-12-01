using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

using Emgu.CV.UI;
using Emgu.CV.Util;

namespace AOCI_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FiltContrTxt.Text = "-1";
            FiltContrTxt1.Text = "-1";
            FiltContrTxt2.Text = "-1";
            FiltContrTxt3.Text = "-1";
            FiltContrTxt4.Text = "9";
            FiltContrTxt5.Text = "-1";
            FiltContrTxt6.Text = "-1";
            FiltContrTxt7.Text = "-1";
            FiltContrTxt8.Text = "-1";
            BrihtKontrTxt.Text = "2";
        }

        private Image<Bgr, byte> sourceImage; //глобальная переменная


        //ProcessImage Secon ImageBox for 
        private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла

                if (result == DialogResult.OK) // открытие выбранного файла
                {
                    string fileName = openFileDialog.FileName;
                    sourceImage = new Image<Bgr, byte>(fileName).Resize(640, 480, Inter.Linear);
                    DefaultImage.Image = sourceImage;//.Resize(640, 480, Inter.Linear)
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            OperationColor(sourceImage.Convert<Gray, byte>());
        }


        private void OperationColor(Image<Gray, byte> grayImage)
        {
            try
            {
                var channel = sourceImage.Split()[0];

                Image<Bgr, byte> destImage = sourceImage.CopyBlank();
                


                VectorOfMat vm = new VectorOfMat();
                
                switch (RGBTxt.Text)
                {
                    case "Red":
                        {
                            vm.Push(channel.CopyBlank());
                            vm.Push(channel.CopyBlank());
                            vm.Push(channel);
                            break;
                        };
                        
                    case "Green":
                        {
                            vm.Push(channel.CopyBlank());
                            vm.Push(channel);
                            vm.Push(channel.CopyBlank());
                            break;
                        };
                        
                    case "Blue":
                        {
                            vm.Push(channel);
                            vm.Push(channel.CopyBlank());
                            vm.Push(channel.CopyBlank());
                            break; 
                        };
                        
                    default: { break; };
                }

                CvInvoke.Merge(vm, destImage);


                ProcessImage.Image = destImage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void KontrastBtn_Click(object sender, EventArgs e)
        {
            var contrastImage = sourceImage.Copy();
            //int c = 2;
            for (int y = 0; y < contrastImage.Height; y++)
            {
                for (int x = 0; x < contrastImage.Width; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if ((contrastImage.Data[y, x, i] * Convert.ToInt32(BrihtKontrTxt.Text)) > 255)
                        {
                            contrastImage.Data[y, x, i] = 255;
                        }
                        else
                            contrastImage.Data[y, x, i] = Convert.ToByte(contrastImage.Data[y, x, i] * Convert.ToInt32(BrihtKontrTxt.Text));

                    }
                    //contrastImage.Data[y, x, 0] = Convert.ToByte(contrastImage.Data[y, x, 0] * c);
                    //contrastImage.Data[y, x, 1] = Convert.ToByte(contrastImage.Data[y, x, 1] * c);
                    //contrastImage.Data[y, x, 2] = Convert.ToByte(contrastImage.Data[y, x, 2] * c);
                }

            }



            ProcessImage.Image = contrastImage.Resize(640, 480, Inter.Linear);
        }

        private void HSVBtn_Click(object sender, EventArgs e)
        {
            //Image<Hsv,byte>
            var hsvImage = sourceImage.Convert<Hsv, byte>();

            for (int y = 0; y < hsvImage.Height; y++)
            {
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    hsvImage.Data[y, x, 0] = Convert.ToByte(HSVBar.Value);

                }
            }


            ProcessImage.Image = hsvImage.Resize(640, 480, Inter.Linear);
        }

        private void HSVBar_Scroll(object sender, EventArgs e)
        {
            var hsvImage = sourceImage.Convert<Hsv, byte>();

            for (int y = 0; y < hsvImage.Height; y++)
            {
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    hsvImage.Data[y, x, 0] = Convert.ToByte(HSVBar.Value);

                }
            }

            ProcessImage.Image = hsvImage.Resize(640, 480, Inter.Linear);
        }

        private void BlurBtn_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> gray = sourceImage.Convert<Gray, byte>();
            Image<Gray, byte> result = gray.CopyBlank();
            
            int sh = 1;
            int N = 3;

            List<byte> l = new List<byte>();


            for (int y = sh; y < gray.Height-sh; y++)
            {
                for (int x = sh; x < gray.Width-sh; x++)
                {
                    l.Clear();
                    
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        { 
                            l.Add(gray.Data[i+y, j+x, 0]);
                        }
                    }

                    l.Sort();

                    result.Data[y, x, 0] = l[N / 2];//l[(1+sh*2)];
                    //gray.Data[y, x, 0] = Convert.ToByte(HSVBar.Value);

                }
            }

            DefaultImage.Image = gray;//.Resize(640, 480, Inter.Linear);

            ProcessImage.Image = result;//.Resize(640, 480, Inter.Linear);
        }

        private void SharpBtn_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> gray = sourceImage.Convert<Gray, byte>();
            Image<Gray, byte> result = gray.CopyBlank();

            int[,] w = new int[3, 3] 
            {
               {Convert.ToInt32(FiltContrTxt.Text), Convert.ToInt32(FiltContrTxt1.Text), Convert.ToInt32(FiltContrTxt2.Text)},
               {Convert.ToInt32(FiltContrTxt3.Text), Convert.ToInt32(FiltContrTxt4.Text), Convert.ToInt32(FiltContrTxt5.Text)},
               {Convert.ToInt32(FiltContrTxt6.Text), Convert.ToInt32(FiltContrTxt7.Text), Convert.ToInt32(FiltContrTxt8.Text)},
            };


            for (int y = 1; y < gray.Height - 1; y++)
            {
                for (int x = 1; x < gray.Width - 1; x++)
                {
                    int r = 0;
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            r += gray.Data[i + y, j + x, 0] * w[i + 1, j + 1];
                        }
                    }

                    if (r > 255)
                        r = 255;
                    if (r < 0) 
                        r = 0;

                    result.Data[y, x, 0] = (byte)r;
                    //gray.Data[y, x, 0] = Convert.ToByte(HSVBar.Value);

                }
            }

            DefaultImage.Image = gray;//.Resize(640, 480, Inter.Linear);

            ProcessImage.Image = result;//.Resize(640, 480, Inter.Linear);
        }

        private void GrayBtn_Click(object sender, EventArgs e)
        {
            var grayImage = new Image<Gray, byte>(sourceImage.Size);

           
            //Image<Gray,byte> gray = sourceImage.Convert<Gray, byte>();
            for (int y = 1; y < grayImage.Height - 1; y++)
                for (int x = 1; x < grayImage.Width - 1; x++)
                {
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * sourceImage.Data[y, x, 2] + 0.587 * sourceImage.Data[y, x, 1] + 0.114 * sourceImage.Data[y, x, 0]);
                }
            ProcessImage.Image = grayImage.Resize(640, 480, Inter.Linear);
        }

        private void BrightnessBtn_Click(object sender, EventArgs e)
        {
            var brightnessImage = sourceImage.Copy();
            

            for (int y = 0; y < brightnessImage.Height; y++)
            {
                for (int x = 0; x < brightnessImage.Width; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if ((brightnessImage.Data[y, x, i] + Convert.ToInt32(BrihtKontrTxt.Text)) > 255)
                        {
                            brightnessImage.Data[y, x, i] = 255;
                        }
                        else
                            brightnessImage.Data[y, x, i] = Convert.ToByte(brightnessImage.Data[y, x, i] + Convert.ToInt32(BrihtKontrTxt.Text));

                    }
                    //contrastImage.Data[y, x, 0] = Convert.ToByte(contrastImage.Data[y, x, 0] * c);
                    //contrastImage.Data[y, x, 1] = Convert.ToByte(contrastImage.Data[y, x, 1] * c);
                    //contrastImage.Data[y, x, 2] = Convert.ToByte(contrastImage.Data[y, x, 2] * c);
                }

            }



            ProcessImage.Image = brightnessImage.Resize(640, 480, Inter.Linear);
        }

        private void SepiaBtn_Click(object sender, EventArgs e)
        {
            var sepiaImage = sourceImage.Copy();


            //Image<Gray,byte> gray = sourceImage.Convert<Gray, byte>();
            for (int y = 1; y < sepiaImage.Height - 1; y++)
                for (int x = 1; x < sepiaImage.Width - 1; x++)
                {
                    //if (Convert.ToByte(0.189 * sourceImage.Data[y, x, 2] + 0.769 * sourceImage.Data[y, x, 1] + 0.393 * sourceImage.Data[y, x, 0]) < 0)
                    //{
                    //    sepiaImage.Data[y, x, 0] = 0;
                    //}
                    //else if (Convert.ToByte(0.189 * sourceImage.Data[y, x, 2] + 0.769 * sourceImage.Data[y, x, 1] + 0.393 * sourceImage.Data[y, x, 0]) < 255)
                    //{
                    //    sepiaImage.Data[y, x, 0] = 255;
                    //}
                    //else
                    //{
                    //    sepiaImage.Data[y, x, 0] = Convert.ToByte(0.189 * sourceImage.Data[y, x, 2] + 0.769 * sourceImage.Data[y, x, 1] + 0.393 * sourceImage.Data[y, x, 0]);
                    //}

                    //if (Convert.ToByte(0.168 * sourceImage.Data[y, x, 2] + 0.686 * sourceImage.Data[y, x, 1] + 0.349 * sourceImage.Data[y, x, 0]) < 0)
                    //{
                    //    sepiaImage.Data[y, x, 1] = 0;
                    //}
                    //else if (Convert.ToByte(0.168 * sourceImage.Data[y, x, 2] + 0.686 * sourceImage.Data[y, x, 1] + 0.349 * sourceImage.Data[y, x, 0]) < 255)
                    //{
                    //    sepiaImage.Data[y, x, 1] = 255;
                    //}
                    //else
                    //{
                    //    sepiaImage.Data[y, x, 1] = Convert.ToByte(0.168 * sourceImage.Data[y, x, 2] + 0.686 * sourceImage.Data[y, x, 1] + 0.349 * sourceImage.Data[y, x, 0]);
                    //}

                    //if (Convert.ToByte(0.131 * sourceImage.Data[y, x, 2] + 0.534 * sourceImage.Data[y, x, 1] + 0.272 * sourceImage.Data[y, x, 0]) < 0)
                    //{
                    //    sepiaImage.Data[y, x, 2] = 0;
                    //}
                    //else if (Convert.ToByte(0.131 * sourceImage.Data[y, x, 2] + 0.534 * sourceImage.Data[y, x, 1] + 0.272 * sourceImage.Data[y, x, 0]) < 255)
                    //{
                    //    sepiaImage.Data[y, x, 2] = 255;
                    //}
                    //else
                    //{
                    //    sepiaImage.Data[y, x, 2] = Convert.ToByte(0.131 * sourceImage.Data[y, x, 2] + 0.534 * sourceImage.Data[y, x, 1] + 0.272 * sourceImage.Data[y, x, 0]);
                    //}

                    // Расчёт нового значения цвета для сепии
                    double blue = 0.189 * sourceImage.Data[y, x, 2] + 0.769 * sourceImage.Data[y, x, 1] + 0.393 * sourceImage.Data[y, x, 0];
                    double green = 0.168 * sourceImage.Data[y, x, 2] + 0.686 * sourceImage.Data[y, x, 1] + 0.349 * sourceImage.Data[y, x, 0];
                    double red = 0.131 * sourceImage.Data[y, x, 2] + 0.534 * sourceImage.Data[y, x, 1] + 0.272 * sourceImage.Data[y, x, 0];

                    // Ограничиваем значения в диапазоне от 0 до 255
                    sepiaImage.Data[y, x, 0] = (byte)(blue < 0 ? 0 : (blue > 255 ? 255 : blue));
                    sepiaImage.Data[y, x, 1] = (byte)(green < 0 ? 0 : (green > 255 ? 255 : green));
                    sepiaImage.Data[y, x, 2] = (byte)(red < 0 ? 0 : (red > 255 ? 255 : red));

                }
            ProcessImage.Image = sepiaImage.Resize(640, 480, Inter.Linear);
        }
    }
}












