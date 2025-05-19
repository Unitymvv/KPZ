using ClassLibrary_Task3.LightHTML.ImageLoadingStrategy;
using System;

namespace ClassLibrary_Task3.LightHTML
{
    public class LightImageElement : LightNode
    {
        public string Src { get; }
        private IImageLoadingStrategy _loadingStrategy;

        public LightImageElement(string src)
        {
            Src = src;

            if (Uri.IsWellFormedUriString(src, UriKind.Absolute))
            {
                _loadingStrategy = new NetworkImageLoadingStrategy();
            }
            else
            {
                _loadingStrategy = new FileImageLoadingStrategy();
            }

            _loadingStrategy.Load(Src);
        }

        public override string InnerHTML => "";

        public override string OuterHTML => $"<img src=\"{Src}\" />";
    }
}
