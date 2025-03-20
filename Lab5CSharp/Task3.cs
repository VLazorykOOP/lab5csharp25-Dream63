namespace Lab5CSharp {
    public class Task3 {
        public void Task() {
            
            Console.WriteLine(">>> Task3");

            Figure[] figures = {new Rectangle(1,2), new Triangle(4), new Circle(5)};

            foreach (Figure f in figures) 
                f.Show();
        }
    }
}