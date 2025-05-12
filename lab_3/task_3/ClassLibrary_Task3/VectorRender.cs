using System;

namespace ClassLibrary_Task3
{
    public class VectorRender : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine("Drawing " + shapeName + " as vectors");
        }
    }
}
