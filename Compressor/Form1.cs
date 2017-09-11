using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compressor
{
    public partial class Form1 : Form
    {
        private string saveRoute;
        private string filesPath;
        private long imgQuality;
        private int imgSize;

        Thread thread;
        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            labelSaved.Visible = false;
            progressBar.Visible = false;
            trackBarQuality.Maximum = 100;
            numericUDQuality.Value = 70;
            trackBarQuality.Value = 70;
            numericUDSize.Value = 700;
        }

        private void ChangeImage()
        {
            var files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*jpg*", SearchOption.AllDirectories);

            progressBar.Invoke((MethodInvoker)delegate // Running on the UI
            {
                progressBar.Visible = true;
                progressBar.Maximum = files.Length;
            });

            foreach (var path in files)
            {
                string fileName = System.IO.Path.GetFileName(path.ToString()); //name of file
                string fullRoute = filesPath + "\\copressed\\" + fileName; // full way to file

                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value++;
                });
                try
                {
                    if (!Directory.Exists(saveRoute))
                    {
                        Directory.CreateDirectory(saveRoute); // If the directory doesn't exist, create it.
                    }
                }
                catch
                {

                }

                SqueezeImage(path.ToString(), fullRoute);
            }
            MessageBox.Show("Изображения сохранены в " + saveRoute);
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = 0;
                labelSaved.Visible = true;
                labelFolderForSave.Text = saveRoute;
                labelRoute.Visible = false;
                labelSaved.Visible = true;
                labelFolderForSave.Visible = true;
            });
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filesPath = folderBrowserDialog.SelectedPath;
                labelRoute.Text = filesPath;
                saveRoute = filesPath + "\\copressed"; //way to folder where files will be saved
                btnStart.Enabled = true;
                labelRoute.Visible = true;
                labelFolderForSave.Visible = false;
                labelSaved.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(ChangeImage);
            thread.Start();
        }

        private void SqueezeImage(string filePath, string route)
        {
            Bitmap bmp1 = new Bitmap(filePath);
            // ScaleImage(bmp1, 700, 700);
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, imgQuality);
            myEncoderParameters.Param[0] = myEncoderParameter;

            //using (var newImage = ResizeImage(bmp1, 700, 400))
            //{
            //    newImage.Save(route, jpgEncoder, myEncoderParameters);
            //}

            bmp1.Save(route, jpgEncoder, myEncoderParameters);
            bmp1.Dispose();

        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private static Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Max(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void trackBarQuality_Scroll(object sender, EventArgs e)
        {
            numericUDQuality.Text = trackBarQuality.Value.ToString();
        }

        private void numericUDQuality_ValueChanged(object sender, EventArgs e)
        {
            trackBarQuality.Value = Int32.Parse(numericUDQuality.Text);
            imgQuality = Int32.Parse(numericUDQuality.Text);
        }

        private void numericUDSize_ValueChanged(object sender, EventArgs e)
        {
            imgSize = Int32.Parse(numericUDSize.Text);
        }

    }
}