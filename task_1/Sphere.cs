namespace lab_3;

public class Sphere : IFigure
{
    public double Radius { get; private set; }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
