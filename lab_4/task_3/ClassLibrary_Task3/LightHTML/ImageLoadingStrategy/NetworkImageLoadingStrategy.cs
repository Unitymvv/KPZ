using System;

namespace ClassLibrary_Task3.LightHTML.ImageLoadingStrategy
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public void Load(string source)
        {
            Console.WriteLine($"Downloading image from URL: {source}");
        }
    }
}
