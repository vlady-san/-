public class Circle implements IFigure{
    public Point center;
    public int radius;
    public Circle(Point point, int radius )
    {
        center=point;
        this.radius=radius;
    }

    @Override
    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
