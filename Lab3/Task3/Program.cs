using System;

class Program
{
    static void Main()
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape circle = new Circle(vector);
        Shape triangle = new Triangle(raster);
        Shape square = new Square(vector);

        circle.Draw();
        triangle.Draw();
        square.Draw();
    }
}
