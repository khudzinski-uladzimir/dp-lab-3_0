namespace lab_3;

public class Torus : IFigure
{
    public double MajorRadius { get; set; }

    public Torus(double majorRadius)
    {
        MajorRadius = majorRadius;
    }

    public void CalculateVolume()
    {
        Console.WriteLine("Calculating volume of the torus...");
        Console.WriteLine(
            "Volume: " + 2 * Math.PI * Math.PI * MajorRadius * MajorRadius * MajorRadius
        );
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
