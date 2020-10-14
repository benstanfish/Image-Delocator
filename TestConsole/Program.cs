using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Image_Delocator;
using System.Drawing;
using System.Drawing.Imaging;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestImagePath = @"C:\Users\benst\Documents\Image-Delocator\Images\20200214_090936 - Copy.jpg";

            //var ImageProps = Tools.ReadPropertyItems(TestImagePath);
            //foreach (string thing in ImageProps)
            //{
            //    Console.WriteLine(thing);
            //}

            Image image = new Bitmap(TestImagePath);
            var Lat = Tools.GetLatitude(image);
            var Long = Tools.GetLongitude(image);
            var Alt = Tools.GetAltitude(image);
            var DateTaken = Tools.GetDateTaken(image);
            var Make = Tools.GetCameraMake(image);
            var Model = Tools.GetCameraModel(image);

            Console.WriteLine("Lat: " + Lat[0] + ", " + Lat[1] + ", " + Lat[2]);
            Console.WriteLine("Long: " + Long[0] + ", " + Long[1] + ", " + Long[2]);
            Console.WriteLine("Alt: " + Alt);
            Console.WriteLine("Date: " + DateTaken);
            Console.WriteLine("Make: " + Make );
            Console.WriteLine("Model: " + Model);
            Console.WriteLine(Tools.gpsBits(image));
            Console.ReadLine();
        }
    }
}
