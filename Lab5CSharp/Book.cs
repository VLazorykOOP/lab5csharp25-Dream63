namespace Lab5CSharp
{
    public class Book : PrintedWork {
        private string genre;

        public Book(String Author, int NumOfPages, String Genre) : base(Author, NumOfPages) {
            genre = Genre;
        }
        public Book(String Author, int NumOfPages) : base(Author, NumOfPages) {
            genre = "unknowm";
        }
        public Book(String Author) : base(Author) {
            genre = "unknowm";
        }        
        public Book(int NumOfPages) : base(NumOfPages) {
            genre = "unknowm";
        } 
        public Book() : base() {
            genre = "unknowm";
        }


        ~Book() {
            Console.WriteLine("Book object destroyed");
        }

        
        public new string Show() {
            return "Book --- Genre: " + genre + " | " + base.Show(); 
        }
    }
}