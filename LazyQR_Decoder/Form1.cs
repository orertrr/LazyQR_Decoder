using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZXing.QrCode;
using ZXing.Common;

namespace LazyQR_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_excute_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage())
            {
                MessageBox.Show("You must clip the image first.");
                return;
            }

            Image image = Clipboard.GetImage();
            Clipboard.SetImage(image);
            Bitmap bitmap = new Bitmap(image);
            // bitmap = NoiseReduction(bitmap);

            ZXing.LuminanceSource source = new ZXing.BitmapLuminanceSource(bitmap);
            HybridBinarizer binarizer = new HybridBinarizer(source);
            ZXing.BinaryBitmap ZXbitmap = new ZXing.BinaryBitmap(binarizer);
            
            QRCodeReader reader = new QRCodeReader();
            ZXing.Result result = reader.decode(ZXbitmap);

            if (result == null)
            {
                MessageBox.Show("Decode fail.");
                return;
            }

            txt_information.Text = result.Text;
        }

        //private Bitmap NoiseReduction(Bitmap origin)
        //{
        //    Bitmap result = new Bitmap(origin.Width, origin.Height);
        //    Color[] gray_pixels = new Color[origin.Width * origin.Height];
        //    Color[] median_pixels = new Color[origin.Height * origin.Width];

        //    // GrayScale
        //    for (int i = 0; i < origin.Height; i++)
        //    {
        //        for (int j = 0; j < origin.Width; j++)
        //        {
        //            Color pixel = origin.GetPixel(j, i);
        //            int gray = pixel.R / 3 + pixel.G / 3 + pixel.B / 3;

        //            if (gray > 150)
        //                gray = 255;
        //            else
        //                gray = 0;

        //            gray_pixels[i * origin.Width + j] = Color.FromArgb(gray, gray, gray);
        //            result.SetPixel(j, i, gray_pixels[i * origin.Width + j]);
        //        }
        //    }

        //    const int filterSize = 9;

        //    //Median Fileter
        //    //for (int i = 0; i < origin.Height; i++)
        //    //{
        //    //    for (int j = 0; j < origin.Width; j++)
        //    //    {
        //    //        byte[] mask = new byte[filterSize * filterSize];

        //    //        for (int filter_i = 0; filter_i < filterSize; filter_i++)
        //    //        {
        //    //            for (int filter_j = 0; filter_j < filterSize; filter_j++)
        //    //            {
        //    //                int location_i = i - filterSize / 2;
        //    //                int location_j = j - filterSize / 2;
        //    //                if (location_i < 0)
        //    //                    location_i = 0 + (0 - location_i);
        //    //                else if (location_i >= origin.Height)
        //    //                    location_i = origin.Height - 1 + (origin.Height - 1 - location_i);
        //    //                if (location_j < 0)
        //    //                    location_j = 0 + (0 - location_j);
        //    //                else if (location_j >= origin.Width)
        //    //                    location_j = origin.Width - 1 + (origin.Width - 1 - location_j);

        //    //                mask[filter_i * filterSize + filter_j] = gray_pixels[location_i * origin.Width + location_j].R;
        //    //            }
        //    //        }

        //    //        Array.Sort(mask);
        //    //        Color result_color = Color.FromArgb(mask[(filterSize * filterSize) / 2], mask[(filterSize * filterSize) / 2], mask[(filterSize * filterSize) / 2]);
        //    //        result.SetPixel(j, i, result_color);
        //    //    }
        //    //}

        //    return result;
        //}
    }
}
