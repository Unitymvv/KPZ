using ClassLibrary_Task3;

namespace ConsoleApp_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer vector = new VectorRender();
            IRenderer raster = new RasterRender();

            Shape circle = new Circle(raster);
            Shape square = new Square(vector);
            Shape triangle = new Triangle(vector);

            circle.Draw();    
            square.Draw();
            triangle.Draw();
        }
    }
}
