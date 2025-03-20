namespace Lab5CSharp {
    public class Circle : Figure {
        private int radius;

        public Circle(int radius) {
            this.radius = radius;
        }

        public override double Area() {
            return radius * 3.14;
        }
        public override double Perimeter() {
            return 2 * radius * 3.14;
        }
        public override void Show() {
            Console.WriteLine($"Circle with radius {radius}");
        }     
    }
}