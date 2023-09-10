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
    }
}
