class Library{
    // Datafields
    List<Book> books;

    public Library() {
        books = new List<Book>();
        books martian = new Book("Martian", "Jane Doe", new DateTime(2004, 10, 10));
        books kodehode = new Book("Kodehode", "Kode Hode", new DateTime(2001, 11, 09));
        books martian2 = new Book("Martian 2", "Jane Doe", new DateTime(2014, 10, 10));
    }
    public Book? LendBook (string title) {
        Book? book = books.Find((book) => 
        {
            if (book.Title == title)
            {
                return true;
            }
            else
            {
                return false;
            }
        });

        if (book == null) 
        {
            return null;
        }
        else 
        
        {
            return book;
        }
        
    }
}