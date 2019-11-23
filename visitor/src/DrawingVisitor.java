
public class DrawingVisitor  implements IVisitor  {

    @Override
    public void Visit(Triangle triangle) {

        System.out.println("Рисуем треугольник по 3м точкам: "+triangle.points.get(0) + " "+
                triangle.points.get(1)+" "+triangle.points.get(2));
    }

    @Override
    public void Visit(Square square) {
        System.out.println("Рисуем квадрат шириной "+square.width+" и высотой "+square.height+
                " верхняя левая точка которого "+square.point);
    }

    @Override
    public void Visit(Circle circle) {
        System.out.println("Рисуем круг радиусом "+circle.radius +
                " центр которого находится в точке"+circle.center);
    }
}
