using System.Drawing.Imaging;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;

            for (int i = 1; i <= 10; i++)
            {
                domainBlockSize.Items.Add(i.ToString());
                domainThreshHold.Items.Add(i.ToString());
                domainQrate.Items.Add(i.ToString());
            }

            domainBlockSize.SelectedItem = "4";
            domainQrate.SelectedItem = "8";
            domainThreshHold.SelectedItem = "6";
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn hình ảnh";
            openFile.Filter = "Tất cả các tệp|*.*|Hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFile.FileName;
                    Image selectedImage = Image.FromFile(selectedImagePath);
                    Image resizedImage = ResizeImage(selectedImage, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = resizedImage;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private ImageCodecInfo GetJpegCodecInfo()
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == ImageFormat.Jpeg.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private Image CompressBitmapToJpeg(Image image, int threshold, int blockSize, int qualityRate)
        {
            // Tạo đối tượng EncoderParameter để thiết lập các tham số nén
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, qualityRate);
            EncoderParameter thresholdParam = new EncoderParameter(Encoder.Compression, threshold);
            EncoderParameter blockSizeParam = new EncoderParameter(Encoder.ColorDepth, blockSize);

            // Tạo mảng EncoderParameters chứa các tham số nén
            EncoderParameters encoderParams = new EncoderParameters(3);
            encoderParams.Param[0] = qualityParam;
            encoderParams.Param[1] = thresholdParam;
            encoderParams.Param[2] = blockSizeParam;

            String outputImagePath = @"D:\ALl\img_compress.jpeg";

            using (MemoryStream ms = new MemoryStream())
            {
                // Tạo một Bitmap mới từ ảnh gốc
                Bitmap inputBitmap = new Bitmap(image);
                // Lưu Bitmap thành tệp JPEG với các tham số nén
                inputBitmap.Save(ms, GetJpegCodecInfo(), encoderParams);
                // Đọc lại ảnh từ MemoryStream và trả về nó
                return Image.FromStream(ms);
            }

        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            Image inputImage = pictureBox1.Image;

            if (inputImage != null)
            {
                int threshold = int.Parse(domainThreshHold.SelectedItem.ToString());
                int blocksize = int.Parse(domainBlockSize.SelectedItem.ToString());
                int qrate = int.Parse(domainQrate.SelectedItem.ToString());

                Image compressImg = CompressBitmapToJpeg(inputImage, threshold, qrate, blocksize);

                Image resizeCompress = ResizeImage(compressImg, pictureBox2.Width, pictureBox2.Height);
                pictureBox2.Image = resizeCompress;
                SaveImageFromPictureBox2();
            }
        }

        private void SaveImageFromPictureBox2()
        {
            Image imageToSave = pictureBox2.Image;

            if (imageToSave != null)
            {
                string outputPath = @"D:\image_output.jpg"; // Đường dẫn và tên tệp đích
                imageToSave.Save(outputPath, ImageFormat.Jpeg);

                MessageBox.Show("Ảnh đã được lưu tại:\n" + outputPath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có ảnh để lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}