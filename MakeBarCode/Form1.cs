using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Dynamsoft.Barcode;
using TouchlessLib;
using System.Diagnostics;

namespace MakeBarCode
{
    public partial class Form1 : Form
    {
        Image File;
        Bitmap bitmap = null;
        //SerialPort _serialPort;
        BarcodeReader _barcodeReader = new BarcodeReader();
        TouchlessMgr _touch = new TouchlessMgr();
        //private int _previewWidth;
        //private int _previewHight;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = textBox1.Text;
            Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font ofont = new System.Drawing.Font("IDAutomationHC39M Free Version", 20);
                //Font ofont = new System.Drawing.Font("AGLRY", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush fontcolor = new SolidBrush(Color.Black);
                SolidBrush BackGroundColor = new SolidBrush(Color.White);
                graphics.FillRectangle(BackGroundColor, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", ofont, fontcolor, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBox1.Image = bitmap;
                pictureBox1.Width = bitmap.Width;
                pictureBox1.Height = bitmap.Height;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odlg = new OpenFileDialog())
            {
                odlg.Title = "Select Image";
                if (odlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bitmap = new Bitmap(odlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File not supported.");
                        return;
                    }
                    pictureBox2.Image = new Bitmap(odlg.FileName);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Please Load Image");
                return;
            }
            ReadBarCode((Bitmap)pictureBox2.Image);
        }

        private void ReadBarCode(Bitmap image)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            BarcodeResult[] results = _barcodeReader.DecodeBitmap(image);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds + "ms");
            textBox2.Clear();
            if (results == null)
            {
                textBox2.Text = "No Barcode Detected";
            }
            else
            {
                foreach (BarcodeResult result in results)
                {
                    textBox2.AppendText(result.BarcodeText + "\n");
                    textBox2.AppendText("\n");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QR_CODE oQR = new QR_CODE();
            oQR.ShowDialog();
            this.Hide();
        }

        private void barcodeSave_btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Sorry! No Image Found");
                return;
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(sfd.FileName, ImageFormat.Bmp);
                        //File.Save(sfd.FileName, ImageFormat.Bmp);
                        //pictureBox1.Image.Save("C:\\Users\\Theta-Team2\\Pictures\\" + textBox1.Text + "Barcode.bmp", ImageFormat.Bmp);
                    }
                }
            }
        }
    }
}
