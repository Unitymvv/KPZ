using System;

namespace ClassLibrary_Task3
{
    public class RasterRender : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine("Drawing " + shapeName + " as pixles");
        }
    }
}
