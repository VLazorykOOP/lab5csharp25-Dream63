namespace Lab5CSharp {
public class SchoolBook : PrintedWork {
    private string lesson;

    public SchoolBook(string Author, int NumOfPages, String Lesson) : base(Author, NumOfPages) {
        lesson = Lesson;
    }
    public SchoolBook(string Author, int NumOfPages) : base(Author, NumOfPages) {
        lesson = "unknown";
    }
    public SchoolBook(string Author) : base(Author) {
        lesson = "unknown";
    }    
    public SchoolBook(int NumOfPages) : base(NumOfPages) {
        lesson = "unknown";
    }    
    public SchoolBook() : base() {
        lesson = "unknown";
    }

    
    ~SchoolBook() {
        Console.WriteLine("SchoolBook object destroyed");
    }


    public new string Show() {
        return "SchoolBook --- Lesson: " + lesson + " | " + base.Show(); 
    }
}
}

