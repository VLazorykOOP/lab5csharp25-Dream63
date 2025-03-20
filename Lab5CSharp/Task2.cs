namespace Lab5CSharp {
    public class Task2 {
        public void Task() {
            Console.WriteLine(">>> Task2");

            Book book = new Book(100);
            Magazine magazine = new Magazine();
            SchoolBook schoolBook = new SchoolBook("Cofrie", 124);
            PrintedWork printedWork = new PrintedWork("Abraham");

            Console.WriteLine(book.Show());
            Console.WriteLine(magazine.Show());
            Console.WriteLine(printedWork.Show());
            Console.WriteLine(schoolBook.Show());
            GC.Collect();
        }
    }
}