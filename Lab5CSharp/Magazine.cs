namespace Lab5CSharp {
    public class Magazine : PrintedWork {
        private  double price;
    
        public Magazine(string Author, int NumOfPages, double Price) : base(Author, NumOfPages) {
            price = Price;
        }
        public Magazine(string Author, int NumOfPages) : base(Author, NumOfPages) {
            price = 0;
        }
        public Magazine(string Author) : base(Author) {
            price = 0;
        }
        public Magazine(int NumOfPages) : base(NumOfPages) {
            price = 0;
        }
        public Magazine() : base() {
            price = 0;
        }
    
        
        ~Magazine() {
            Console.WriteLine("Magazine object destroyed");
        }
    
    
        public new string Show() {
            return "Magazine --- Price: " + price + " | " + base.Show(); 
        }
    }
}

