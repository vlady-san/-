public class Square implements IFigure{
    public Point point;
    public int width;
    public int height;

    public Square(Point point, int width, int height){
        this.point=point;
        this.width=width;
        this.height=height;
    }

    @Override
    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
