namespace lab_3;

public interface IFigure
{
    void CalculateVolume();
    void Accept(IVisitor visitor);
}
