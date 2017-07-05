using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MakeBarCode
{
    public partial class QR_CODE : Form
    {
        Bitmap bitmap = null;
        public QR_CODE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Loadfile_PictureBox.Image == null)
            {
                MessageBox.Show("No Image Found");
                return;
            }
            ReadQrCode((Bitmap)Loadfile_PictureBox.Image);
        }

        private void ReadQrCode(Bitmap image)
        {
            MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
            textBox2.Text = decoder.Decode(new QRCodeBitmapImage(image));
        }
        private void QR_Code_generate_Click(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 8;
            Bitmap bitmap = encoder.Encode(Encoder_textbox.Text);
            encoder_image.Image = bitmap;
        }

        private void load_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Image";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bitmap = new Bitmap(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File not supported.");
                        return;
                    }
                    Loadfile_PictureBox.Image = bitmap;
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (encoder_image.Image == null)
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
                        encoder_image.Image.Save(sfd.FileName, ImageFormat.Bmp);
                        //bitmap.Save("C:\\Users\\Theta-Team2\\Pictures\\" + Encoder_textbox.Text + "QRcode.bmp", ImageFormat.Bmp);
                        //encoder_image.Image.Save("C:\\Users\\Theta-Team2\\Pictures\\" + Encoder_textbox.Text + "QRcode.bmp", ImageFormat.Bmp);
                    }
                }
            }
        }
    }
}
