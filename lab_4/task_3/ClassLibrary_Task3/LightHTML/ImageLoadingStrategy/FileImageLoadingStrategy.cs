using System;

namespace ClassLibrary_Task3.LightHTML.ImageLoadingStrategy
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public void Load(string source)
        {
            Console.WriteLine($"Loading image from file system: {source}");
        }
    }
}
