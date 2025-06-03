namespace lab_3;

public class Parallelepiped : IFigure
{
    public int Lenght { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Parallelepiped(int lenght, int width, int height)
    {
        Lenght = lenght;
        Width = width;
        Height = height;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
