namespace Lab5CSharp {
    public class Rectangle : Figure {
        private int a, b;

        public Rectangle(int x, int y) {
            a = x;
            b = y;
        }

        public override double Area() {
            return a * b;
        }
        public override double Perimeter() {
            return (a + b) * 2;
        }
        public override void Show() {
            Console.WriteLine($"Rectangle with side lengths {a} and {b}");
        }     
    }
}