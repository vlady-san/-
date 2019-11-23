public class Main {
    public  static void main(String[] args)
    {
        IFigure[] figures = {
                new Square(new Point(5,5),100,100),
                new Circle(new Point(30,30),100),
                new Triangle(new Point(0,0),new Point(2,2), new Point(0,2))};

        IVisitor dvisitor = new DrawingVisitor();
        IVisitor avisitor = new GetAreaVisitor();
        IVisitor pvisitor = new GetPerimeterVisitor();
        for (IFigure fig : figures)
        {
            fig.Accept(dvisitor);
            fig.Accept(avisitor);
            fig.Accept(pvisitor);
        }
    }
}
