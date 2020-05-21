using System;

namespace ProxyDesignPattern
{
    public interface IImage
    {
        void DisplayImage();
    }

    public class RealImage : IImage
    {
        private string Filename { get; set; }
        public RealImage(string filename)
        {
            Filename = filename;
            LoadImageFromDisk();
        }
        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + Filename);
        }
        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + Filename);
        }
    }

    public class ProxyImage : IImage
    {
        private RealImage realImage = null;
        private string Filename { get; set; }
        public ProxyImage(string filename)
        {
            Filename = filename;
        }
        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(Filename);
            }
            realImage.DisplayImage();
        }
    }
}
