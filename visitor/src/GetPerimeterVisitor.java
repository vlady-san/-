public class GetPerimeterVisitor implements IVisitor {
    @Override
    public void Visit(Triangle triangle) {
        double AB=Math.sqrt(Math.pow(triangle.points.get(1).x-triangle.points.get(0).x,2) +
                Math.pow(triangle.points.get(1).y-triangle.points.get(0).y,2));
        double BC=Math.sqrt(Math.pow(triangle.points.get(2).x-triangle.points.get(1).x,2) +
                Math.pow(triangle.points.get(2).y-triangle.points.get(1).y,2));
        double AC=Math.sqrt(Math.pow(triangle.points.get(2).x-triangle.points.get(0).x,2) +
                Math.pow(triangle.points.get(2).y-triangle.points.get(0).y,2));
        System.out.println(AB+BC+AC);
    }

    @Override
    public void Visit(Square square) {
        System.out.println(2*(square.height+square.width));
    }

    @Override
    public void Visit(Circle circle) {
        System.out.println(2*Math.PI*circle.radius);
    }
}
