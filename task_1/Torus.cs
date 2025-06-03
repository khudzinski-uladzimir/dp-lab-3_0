namespace lab_3;

public class Torus : IFigure
{
    public double MajorRadius { get; set; }

    public Torus(double majorRadius)
    {
        MajorRadius = majorRadius;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
