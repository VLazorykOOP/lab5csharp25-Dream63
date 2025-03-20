namespace Lab5CSharp
    {
    public class PrintedWork {
        string author;
        int numOfPages;

        protected string? destructMessage;

        public PrintedWork(string Author, int NumOfPages) {
            author = Author;
            numOfPages = NumOfPages;
        }
        public PrintedWork(int NumOfPages) {
            author = "Unknown";
            numOfPages = NumOfPages;
        }
        public PrintedWork(string Author) {
            author = Author;
            numOfPages = 1;
        }
        public PrintedWork() {
            author = "Unknown";
            numOfPages = 1;
        }


        ~PrintedWork() {
            Console.WriteLine("PrintedWork object destroyed");
        }


        public String Show() {
            return "Author: " + author + " | number of pages: " + numOfPages; 
        }

        public int GetNumberOfPages() { return numOfPages; }
    }
}