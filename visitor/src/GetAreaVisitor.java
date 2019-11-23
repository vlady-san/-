public class GetAreaVisitor implements IVisitor {
    @Override
    public void Visit(Triangle triangle) {
        double res = Math.abs(0.5*(triangle.points.get(1).x-triangle.points.get(0).x)*
                (triangle.points.get(2).y-triangle.points.get(0).y)-
                (triangle.points.get(2).x-triangle.points.get(0).x)*(triangle.points.get(1).y-triangle.points.get(0).y));
        System.out.println(res);
    }

    @Override
    public void Visit(Square square) {
        System.out.println(square.height*square.width);
    }

    @Override
    public void Visit(Circle circle) {
        System.out.println(Math.PI*circle.radius*circle.radius);
    }
}
