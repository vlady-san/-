public interface IVisitor {
    void Visit(Triangle triangle);
    void Visit(Square square);
    void Visit(Circle circle);
}
