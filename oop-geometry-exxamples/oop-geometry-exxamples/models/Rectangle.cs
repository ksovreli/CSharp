namespace TenthConsoleApp.models
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
