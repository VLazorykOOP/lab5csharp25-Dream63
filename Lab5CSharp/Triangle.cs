namespace Lab5CSharp {
    public class Triangle : Figure {
        //perfect triangle
        private int side;

        public Triangle(int side) {
            this.side = side;
        }

        public override double Area() {
            return side * side * Math.Sqrt(3) / 4;
        }
        public override double Perimeter() {
            return side * 3;
        }
        public override void Show() {
            Console.WriteLine($"Equilateral triangle with side length {side}");
        }     
    }
}