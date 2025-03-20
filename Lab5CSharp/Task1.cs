namespace Lab5CSharp {
    public class Task1 {
        public void Task() {
            Console.WriteLine(">>> Task1");

            Book book = new Book("Unnamed",100,  "Action");
            Magazine magazine = new Magazine();
            PrintedWork printedWork = new PrintedWork("Abraham", 120);
            SchoolBook schoolBook = new SchoolBook("Cofrie", 214);

            Console.WriteLine(book.Show());
            Console.WriteLine(magazine.Show());
            Console.WriteLine(printedWork.Show());
            Console.WriteLine(schoolBook.Show());
        }
    }
}