import java.util.ArrayList;
import java.util.List;

public class Triangle implements IFigure{
    public List<Point> points =new ArrayList<Point>();
    public double area;

    public Triangle(Point point1, Point point2, Point point3){
        area=0;

       points.add(point1);
       points.add(point2);
       points.add(point3);
    }

    @Override
    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}


