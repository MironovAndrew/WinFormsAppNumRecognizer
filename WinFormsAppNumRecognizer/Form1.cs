using NeurolNetworkConsoleApp;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WinFormsAppNumRecognizer
{
    public partial class FormMain : Form
    { 
        public FormMain()
        {
            InitializeComponent();

          //  DoubleBuffered = true;

            Bitmap bitmap = new Bitmap(DrawingArea.Width, DrawingArea.Height);

            Graphics graphics = DrawingArea.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            DrawingArea.Image = bitmap;


            Pen pen = new Pen(Color.Black, 20);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            int pointX = -1;
            int pointY = -1;

            bool moving = false;



            string serializatedNeurolNetworkPath = @"S:\Desktop\Dataset\neurol_network_serializetion.json";
            buttonPredict.Click += (s, e) =>
            {
                NeurolNetwork neurolNetwork = new Serialization(serializatedNeurolNetworkPath).Read();


                Bitmap btm = bitmap.Clone(new Rectangle(0, 0, DrawingArea.Width, DrawingArea.Height), bitmap.PixelFormat);
                

                List<double> result = neurolNetwork.Predict(GetPixels(btm, 30, 30)).ToList();
                double max = result.Max();
                int index = result.IndexOf(max);

                label1.Text = index.ToString(); 

                graphics.Clear(Color.White);
                DrawingArea.Image = bitmap;
            };



            DrawingArea.MouseMove += (s, e) =>
            {
                if (moving && pointX != -1 && pointY != -1)
                {
                    graphics.DrawLine(pen, new Point(pointX, pointY), e.Location);

                    pointX = e.X;
                    pointY = e.Y;
                }

                DrawingArea.Refresh();

            };

            DrawingArea.MouseDown += (s, e) =>
            {
                moving = true;
                pointX = e.X;
                pointY = e.Y;
            };

            DrawingArea.MouseUp += (s, e) =>
            {
                moving = false;
                pointX = -1;
                pointY = -1;
            };
        }



        static int[] GetPixels(Image image, int width, int height)
        {
            Bitmap picture = new Bitmap(image, width, height);


            int[] pixels = new int[width * height];

            int array_index = 0;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = picture.GetPixel(x, y);

                    pixels[array_index++] = ((pixelColor.R + pixelColor.G + pixelColor.B) / 3 >= 200 ? 0 : 1);
                }
            }

            return pixels;
        }


    }


}
