namespace lab_3;

public class Sphere : IFigure
{
    public double Radius { get; private set; }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public void CalculateVolume()
    {
        Console.WriteLine("Calculating volume of the sphere...");
        Console.WriteLine("Volume: " + 4 / 3 * Math.PI * Math.Pow(Radius, 3));
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
