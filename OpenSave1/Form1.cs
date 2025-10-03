using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//System.Windows.Media.Imaging.GifB

namespace OpenSave1
{
    public partial class Form1 : Form
    {
        public String myPath = @"..\..\";
        public Form1()
        {
            InitializeComponent();
        }

        //OPEN

        private void button1_Click(object sender, EventArgs e)
        {
            String fillpath = myPath + "logo.jpg";
            Image myImg = Image.FromFile(fillpath);


            pictureBox1.Image = myImg;


            textBox1.Text= fillpath;
            textBox2.Text = Convert.ToString(myImg.Width);
            textBox3.Text = Convert.ToString(myImg.Height);
            textBox4.Text = Convert.ToString(myImg.VerticalResolution);
            textBox5.Text = Convert.ToString(myImg.HorizontalResolution);

        }

        //SAVE

        private void button2_Click(object sender, EventArgs e)
        {
           

            pictureBox1.Image.Save(myPath + "test.gif", System.Drawing.Imaging.ImageFormat.Gif);
            pictureBox1.Image.Save(myPath + "test.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
            pictureBox1.Image.Save(myPath + "test.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //if (openFileDialog1.ShowDialog)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //NEW OPEN

        private void button3_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png|Tiff Image|*.tiff";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                Image myImg = Image.FromFile(filePath);

                pictureBox1.Image = myImg;


                textBox1.Text = filePath;
                textBox2.Text = Convert.ToString(myImg.Width);
                textBox3.Text = Convert.ToString(myImg.Height);
                textBox4.Text = Convert.ToString(myImg.VerticalResolution);
                textBox5.Text = Convert.ToString(myImg.HorizontalResolution);
            }

        }

        // SAVE ASE

        private void button4_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png|Tiff Image|*.tiff";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.

            if (saveFileDialog1.FileName != "")
            {
                string fileExtension = Path.GetExtension(saveFileDialog1.FileName);
                //Image saveImg = pictureBox1.Image;
              //  if (pictureBox2 != null)
               // {
               //     saveImg = pictureBox2.Image;
              //  }
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:

                        pictureBox1.Image.Save(Path.ChangeExtension(saveFileDialog1.FileName, ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox1.Image.Save(Path.ChangeExtension(saveFileDialog1.FileName, ".bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pictureBox1.Image.Save(Path.ChangeExtension(saveFileDialog1.FileName, ".gif"), System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        pictureBox1.Image.Save(Path.ChangeExtension(saveFileDialog1.FileName, ".png"), System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 5:
                        pictureBox1.Image.Save(Path.ChangeExtension(saveFileDialog1.FileName, ".tiff"), System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                }
            }

        }

        private void Compression_Click(object sender, EventArgs e)
        {

            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;
            Image originImg = pictureBox1.Image;
            
            Image compressionImg = originImg;
            pictureBox1.Image = compressionImg;
            pictureBox2.Image = originImg;

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo jpegCodec = null;

            // Find JPEG codec
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == "image/jpeg")
                {
                    jpegCodec = codec;
                    break;
                }
            }

            if (jpegCodec != null)
            {
                // Set compression level
                int x = 0;
                Int32.TryParse(textBox6.Text, out x);

                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, x);
                myEncoderParameters.Param[0] = myEncoderParameter;

                // Compress image
                using (MemoryStream ms = new MemoryStream())
                {
                    compressionImg.Save(ms, jpegCodec, myEncoderParameters);
                    pictureBox2.Image = Image.FromStream(ms);
                    SaveImageFromPictureBox2();
                }
              //  SaveImageFromPictureBox2();
            }
            else
            {
                // JPEG codec not found
                MessageBox.Show("JPEG codec not found.");
            }
            // Compress image

        }

        private void SaveImageFromPictureBox2()
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to pictureBox2.
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog2.Title = "Save an Image File";
            saveFileDialog2.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog2.FileName != "")
            {
                // Determine the selected file extension
                string fileExtension = Path.GetExtension(saveFileDialog2.FileName);

                // Determine the ImageFormat based on file extension
                ImageFormat imageFormat = null;
                switch (fileExtension.ToLower())
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        imageFormat = ImageFormat.Gif;
                        break;
                        // Add cases for other formats if needed
                }

                // Save the Image in the appropriate ImageFormat
                if (imageFormat != null)
                {
                    pictureBox2.Image.Save(saveFileDialog2.FileName, imageFormat);
                }
                else
                {
                    MessageBox.Show("Unsupported file format.");
                }
            }
        }

        private void rotationX_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
            Image rotImg = originImg;
            rotImg.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox2.Image = rotImg;

        }

        private void rotationy_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
            Image rotImg = originImg;
            rotImg.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox2.Image = rotImg;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int angle = trackBar1.Value;
            Image originImg = pictureBox1.Image;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap bmp2 =RotateImage(bmp1, angle);
            Image newImg = (Image)bmp2;
            pictureBox2.Image = newImg;
            // button5.PerformClick();
        }

        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        static public Bitmap contrast(Image inImg)
        {
            // if (inImg != null) {
            Bitmap bmp1 = (Bitmap)inImg;
            Bitmap clone = bmp1;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int dbl = 2;
                    int r = cPix.R;
                    r *= dbl;
                    if (r > 255) { r = 255; }
                    int b = cPix.B;
                    b *= dbl;
                    if (b > 255) { b = 255; }
                    int g = cPix.G;
                    g *= dbl;
                    if (g*2 > 255) { g = 255; }

                    Color cPix1 = Color.FromArgb(r, g, b);
                    clone.SetPixel(i, j, cPix1);

                }
            }
            return clone;
            //  }
            // return clone;
        }
        static public Bitmap rootata(Image inImg)
        {
            // if (inImg != null) {
            Bitmap bmp1 = (Bitmap)inImg;
            Bitmap clone = bmp1;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);

                    int r = cPix.R;
                    r *= 2;
                    if (r > 255) { r = 255; }
                    int b = cPix.B;
                    b /= 2;
                    if (b < 0) { b = 0; }
                    int g = cPix.B;
                    g /= 2;
                    if (g < 0) { g = 0; }
                    Color cPix1 = Color.FromArgb(r, g, b);
                    clone.SetPixel(i, j, cPix1);
                }
            }
            return clone;

        }

       private int maxMinAdd(int c, int v) {
            int e = c + v;
            if (e >= 255) { e = 255; }
            if (e <= 0) { e = 0; }
            return e;
        }
        private int maxMinMult(int c, int v)
        {
            float factor = (259 * (v + 255)) / (255 * (259 - v));
            float e1 = factor * (c - 128) + c/2 + 64;
            int e = (int)e1;
            if (e > 255) { e = 255; }
            if (e < 0) { e = 0; }

            return e;
        }

 

        private void negative_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
            int v = negatBar.Value;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int r = cPix.R;
                    int g = cPix.G;
                    int b = cPix.B;
                    if ((r + b + g) /3 < v) { r = 255 - r; b = 255 - b; g = 255 - g; }

                    cPix = Color.FromArgb(r, g, b);
                    clone.SetPixel(i, j, cPix);

                }
            }
            pictureBox2.Image = (Image)clone;
        }

        private void vcolor_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
           // int v = 64;
          //  int v1 = 128;
          //  int v2 = 162;
          //  int v3 = 255;

            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;

            using (Graphics g = Graphics.FromImage(clone))
            {
                g.DrawImage(originImg, new Rectangle(0, 0, clone.Width, clone.Height));
            }


            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int r = cPix.R;
                    int g = cPix.G;
                    int b = cPix.B;
                    int r1=1, b1=1, g1=1; 
                    int sum = (int)( (r + b + g) / 3.33);
                    switch (sum) {
                        case int a when sum < 13:
                            r1 = 12; g1 = 7; b1 = 134;
                            break;
                        case int a when sum < 26:
                            r1 = 43; g1 = 5; b1 = 148;
                            break;
                        case int a when sum < 39:
                            r1 = 66; g1 = 2; b1 = 157;
                            break;
                        case int a when sum < 52:
                            r1 = 89; g1 = 1; b1 = 164;
                            break;
                        case int a when sum < 65:
                            r1 = 109; g1 = 0; b1 = 168;
                            break;
                        case int a when sum < 78:
                            r1 = 130; g1 = 4; b1 = 167;
                            break;
                        case int a when sum < 91:
                            r1 = 149; g1 = 16; b1 = 161;
                            break;
                        case int a when sum < 104:
                            r1 = 167; g1 = 33; b1 = 151;
                            break;
                        case int a when sum < 117:
                            r1 = 182; g1 = 47; b1 = 139;
                            break;
                        case int a when sum < 130:
                            r1 = 196; g1 = 63; b1 = 126;
                            break;
                        case int a when sum < 143:
                            r1 = 209; g1 = 78; b1 = 114;
                            break;
                        case int a when sum < 156:
                            r1 = 220; g1 = 94; b1 = 102;
                            break;
                        case int a when sum < 156:
                            r1 = 230; g1 = 109; b1 = 90;
                            break;
                        case int a when sum < 169:
                            r1 = 239; g1 = 126; b1 = 78;
                            break;
                        case int a when sum < 182:
                            r1 = 246; g1 = 143; b1 = 67;
                            break;
                        case int a when sum < 195:
                            r1 = 251; g1 = 163; b1 = 55;
                            break;
                        case int a when sum < 208:
                            r1 = 253; g1 = 182; b1 = 45;
                            break;
                        case int a when sum < 221:
                            r1 = 252; g1 = 204; b1 = 37;
                            break;
                        case int a when sum < 234:
                            r1 = 247; g1 = 226; b1 = 37;
                            break;
                        case int a when sum < 255:
                            r1 = 239; g1 = 248; b1 = 33;
                            break;

                    }

                    /*
                    if (sum < v) { r1 = 30; b1 = 100; g1 = 80; }
                    if (sum < v1 && sum > v) { r1 = 50; b1 = 100; g1 = 162; }
                    if (sum < v2 && sum > v1) { r1 = 140; b1 = 180; g1 = 242; }
                    if (sum < v3 && sum > v2) { r1 = 140; b1 = 180; g1 = 242; }
                    */

                    cPix = Color.FromArgb(r1, g1, b1);
                    clone.SetPixel(i, j, cPix);

                }
            }
            pictureBox2.Image = (Image)clone;

        }

        private void buttonwyostrz_Click(object sender, EventArgs e)
        {
          //  int[,] tab= { { 1, 1, 1 }, { 0, 0, 0 }, { -1,-1,-1} };
            Image originImg = pictureBox1.Image;
            //System.Security.Cryptography.X509Certificates;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;
            for (int i = 1; i < bmp1.Width-1; i++)
            {
                for (int j = 1; j < bmp1.Height-1; j++)
                {
                    int rm=0; int bm = 0; int gm = 0;
                   // int x=0; int y = 0;
                    for (int mx = i - 1; mx <= i + 1; mx++) {
                        for (int my = j - 1; my <= j + 1; my++)
                        {
                            if (mx!=i && my!=j) {
                                rm += bmp1.GetPixel(mx, my).R;
                                gm += bmp1.GetPixel(mx, my).G;
                                bm += bmp1.GetPixel(mx, my).B;
                            }
                        }
                    }

                    Color cPix = bmp1.GetPixel(i, j);
                    int r = cPix.R;
                    int g = cPix.G;
                    int b = cPix.B;
                    r = (r * 8 - rm)/4;
                    if (r > 255){r = 255;}
                    if (r < 0) { r = 0; }
                    b = (b * 8 - bm)/4;
                    if (b > 255){b = 255;}
                    if (b < 0) { b = 0; }
                    g = (g * 8 - gm) / 4;
                    if (g > 255){g = 255;}
                    if (g < 0) { g = 0; }
                    cPix = Color.FromArgb(r, g, b);
                    clone.SetPixel(i, j, cPix);
                }
            }
            pictureBox2.Image = (Image)clone;
        }

        private void buttonrozm_Click(object sender, EventArgs e)
        {
            //  int[,] tab= { { 1, 1, 1 }, { 0, 0, 0 }, { -1,-1,-1} };
            Image originImg = pictureBox1.Image;
            //System.Security.Cryptography.X509Certificates;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;
            for (int i = 1; i < bmp1.Width - 1; i++)
            {
                for (int j = 1; j < bmp1.Height - 1; j++)
                {
                    int rm = 0; int bm = 0; int gm = 0;
                    // int x=0; int y = 0;
                    for (int mx = i - 1; mx <= i + 1; mx++)
                    {
                        for (int my = j - 1; my <= j + 1; my++)
                        {
                            if (mx != i && my != j)
                            {
                                rm += bmp1.GetPixel(mx, my).R;
                                gm += bmp1.GetPixel(mx, my).G;
                                bm += bmp1.GetPixel(mx, my).B;
                            }
                        }
                    }
                    Color cPix = bmp1.GetPixel(i, j);
                    int r = cPix.R;
                    int g = cPix.G;
                    int b = cPix.B;
                    r = (r * 1 + rm) / 5;
                    if (r > 255) { r = 255; }
                    if (r < 0) { r = 0; }
                    b = (b * 1 + bm) / 5;
                    if (b > 255) { b = 255; }
                    if (b < 0) { b = 0; }
                    g = (g * 1 + gm) / 5;
                    if (g > 255) { g = 255; }
                    if (g < 0) { g = 0; }
                    cPix = Color.FromArgb(r, g, b);
                    clone.SetPixel(i, j, cPix);
                }
            }
            pictureBox2.Image = (Image)clone;
        }

        private void buttonsobel_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;

            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int sum = (cPix.R + cPix.G + cPix.B) / 3;
                    if (sum > 255) { sum = 255; }
                    if (sum < 0) { sum = 0; }
                    cPix = Color.FromArgb(sum, sum, sum);
                    clone.SetPixel(i, j, cPix);
                }
            }
            int[][] sobelx = {new int[] {-1, 0, 1},
                          new int[] {-2, 0, 2},
                          new int[] {-1, 0, 1}};

            int[][] sobely = {new int[] {-1, -2, -1},
                          new int[] { 0, 0, 0},
                          new int[] { 1, 2, 1}};

            for (int i = 1; i < bmp1.Width - 1; i++)
            {
                for (int j = 1; j < bmp1.Height - 1; j++)
                {
                    int dx = (clone.GetPixel(i - 1, j - 1).R * sobelx[0][0] + clone.GetPixel(i, j - 1).R * sobelx[0][1] + clone.GetPixel(i + 1, j - 1).R * sobelx[0][2]
                              + clone.GetPixel(i - 1, j).R * sobelx[1][0] + clone.GetPixel(i, j).R * sobelx[1][1] + clone.GetPixel(i + 1, j).R * sobelx[1][2]
                              + clone.GetPixel(i - 1, j + 1).R * sobelx[2][0] + clone.GetPixel(i, j + 1).R * sobelx[2][1] + clone.GetPixel(i + 1, j + 1).R * sobelx[2][2]);

                    int dy = (clone.GetPixel(i - 1, j - 1).R * sobely[0][0] + clone.GetPixel(i, j - 1).R * sobely[0][1] + clone.GetPixel(i + 1, j - 1).R * sobely[0][2]
                           + clone.GetPixel(i - 1, j).R * sobely[1][0] + clone.GetPixel(i, j).R * sobely[1][1] + clone.GetPixel(i + 1, j).R * sobely[1][2]
                           + clone.GetPixel(i - 1, j + 1).R * sobely[2][0] + clone.GetPixel(i, j + 1).R * sobely[2][1] + clone.GetPixel(i + 1, j + 1).R * sobely[2][2]);
                    double derivata = Math.Sqrt((dx * dx) + (dy * dy));

                    if (derivata > 255)
                    {
                        clone.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        clone.SetPixel(i, j, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                    }


                }
            }
            pictureBox2.Image = (Image)clone;

        }

        private void buttonuse_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
            int vb = binarBar.Value;
            int vc = trackBar2.Value;
            int vj = jasnosc.Value;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int r = cPix.R;
                    int g = cPix.G;
                    int b = cPix.B;

                    r = maxMinAdd(r, vj);
                    g = maxMinAdd(g, vj);
                    b = maxMinAdd(b, vj);
                    if (vc != 0) {r = maxMinMult(r, vc);
                    g = maxMinMult(g, vc);
                    b = maxMinMult(b, vc); }

                    if (vb != 128) {  if (r + b + g < vb) { r = 0; b = 0; g = 0; }
                    else { r = 255; b = 255; g = 255; }}
                   
                    cPix = Color.FromArgb(r, g, b);
                    clone.SetPixel(i, j, cPix);
                }
            }
            pictureBox2.Image = (Image)clone;
        }

        private void buttonGrey_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;
           for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int sum = (cPix.R + cPix.G + cPix.B) / 3;
                    if (sum > 255) { sum = 255; }
                    if (sum < 0) { sum = 0; }
                    cPix = Color.FromArgb(sum, sum, sum);
                    clone.SetPixel(i, j, cPix);
                }
            }
            pictureBox2.Image = (Image)clone;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Image originImg = pictureBox1.Image;
            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;

            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color cPix = bmp1.GetPixel(i, j);
                    int sum = (cPix.R + cPix.G + cPix.B) / 3;
                    if (sum > 255) { sum = 255; }
                    if (sum < 0) { sum = 0; }
                    cPix = Color.FromArgb(sum, sum, sum);
                    clone.SetPixel(i, j, cPix);
                }
            }
            int[][] sobelx = {new int[] { int.Parse(textBox7.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text)},
                          new int[] { int.Parse(textBox10.Text), int.Parse(textBox11.Text), int.Parse(textBox12.Text)},
                          new int[] { int.Parse(textBox13.Text), int.Parse(textBox14.Text), int.Parse(textBox15.Text)}};

            int[][] sobely = {new int[] { int.Parse(textBox7.Text), int.Parse(textBox10.Text), int.Parse(textBox13.Text)},
                          new int[] { int.Parse(textBox8.Text), int.Parse(textBox11.Text), int.Parse(textBox14.Text)},
                          new int[] { int.Parse(textBox9.Text), int.Parse(textBox12.Text), int.Parse(textBox15.Text)}};

            for (int i = 1; i < bmp1.Width - 1; i++)
            {
                for (int j = 1; j < bmp1.Height - 1; j++)
                {
                    int dx = (clone.GetPixel(i - 1, j - 1).R * sobelx[0][0] + clone.GetPixel(i, j - 1).R * sobelx[0][1] + clone.GetPixel(i + 1, j - 1).R * sobelx[0][2]
                              + clone.GetPixel(i - 1, j).R * sobelx[1][0] + clone.GetPixel(i, j).R * sobelx[1][1] + clone.GetPixel(i + 1, j).R * sobelx[1][2]
                              + clone.GetPixel(i - 1, j + 1).R * sobelx[2][0] + clone.GetPixel(i, j + 1).R * sobelx[2][1] + clone.GetPixel(i + 1, j + 1).R * sobelx[2][2]);

                    int dy = (clone.GetPixel(i - 1, j - 1).R * sobely[0][0] + clone.GetPixel(i, j - 1).R * sobely[0][1] + clone.GetPixel(i + 1, j - 1).R * sobely[0][2]
                           + clone.GetPixel(i - 1, j).R * sobely[1][0] + clone.GetPixel(i, j).R * sobely[1][1] + clone.GetPixel(i + 1, j).R * sobely[1][2]
                           + clone.GetPixel(i - 1, j + 1).R * sobely[2][0] + clone.GetPixel(i, j + 1).R * sobely[2][1] + clone.GetPixel(i + 1, j + 1).R * sobely[2][2]);
                    int der = (sobelx[0][0] + sobelx[0][1] + sobelx[0][2] + sobelx[1][0] + sobelx[2][0]) + sobelx[1][1] + sobelx[2][2] + sobelx[1][2] + sobelx[2][1];
                    if (der < 0) { der = (int)Math.Sqrt(der*der); }
                    if (der == 0) { der = 1; }
                    double derivata = Math.Sqrt((dx * dx) + (dy * dy))/(der);

                    if (derivata > 255)
                    {
                        clone.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        clone.SetPixel(i, j, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                    }


                }
            }
            pictureBox2.Image = (Image)clone;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image originImg = pictureBox1.Image;

            Bitmap bmp1 = (Bitmap)originImg;
            Bitmap clone = bmp1;
            try
            {
                for (int i = 0; i < bmp1.Width; i++)
                {
                    for (int j = 0; j < bmp1.Height; j++)
                    {
                        Color cPix = bmp1.GetPixel(i, j);
                        int r = cPix.R;
                        int g = cPix.G;
                        int b = cPix.B;
                        int r1 = 1, b1 = 1, g1 = 1;
                        int sum = (int)((r + b + g) / 3.33);
                        switch (sum)
                        {
                            case int a when sum < 15:
                                r1 = 0; g1 = 0; b1 = 191;
                                break;
                            case int a when sum < 30:
                                r1 = 0; g1 = 0; b1 = 255;
                                break;
                            case int a when sum < 45:
                                r1 = 0; g1 = 64; b1 = 255;
                                break;
                            case int a when sum < 60:
                                r1 = 0; g1 = 128; b1 = 255;
                                break;
                            case int a when sum < 75:
                                r1 = 0; g1 = 192; b1 = 255;
                                break;
                            case int a when sum < 90:
                                r1 = 0; g1 = 255; b1 = 255;
                                break;
                            case int a when sum < 105:
                                r1 = 64; g1 = 255; b1 = 191; //7
                                break;
                            case int a when sum < 120:
                                r1 = 128; g1 = 255; b1 = 128;
                                break;
                            case int a when sum < 135:
                                r1 = 191; g1 = 255; b1 = 64; ////
                                break;
                            case int a when sum < 150:
                                r1 = 255; g1 = 255; b1 = 0;
                                break;
                            case int a when sum < 165:
                                r1 = 255; g1 = 191; b1 = 0;  ///
                                break;
                            case int a when sum < 180:
                                r1 = 255; g1 = 128; b1 = 0; ///
                                break;
                            case int a when sum < 195:
                                r1 = 255; g1 = 64; b1 = 0;
                                break;
                            case int a when sum < 210:
                                r1 = 255; g1 = 0; b1 = 0;
                                break;
                            case int a when sum < 225:
                                r1 = 191; g1 = 0; b1 = 0;
                                break;
                            case int a when sum < 255:
                                r1 = 128; g1 = 0; b1 = 0;
                                break;
                        }
                        cPix = Color.FromArgb(r1, g1, b1);
                        clone.SetPixel(i, j, cPix);

                    }
                }
                pictureBox2.Image = (Image)clone;
            }
            catch (Exception err) { Console.WriteLine(err.Message); }
        }
    }
    }
    
    
    
 
    

    

