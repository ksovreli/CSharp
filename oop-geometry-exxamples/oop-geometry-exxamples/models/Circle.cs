namespace TenthConsoleApp.models
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
