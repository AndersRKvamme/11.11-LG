class Library{
    // Datafields
    List<Book> books;

    public Library() {
        books = new List<Book>();
        Book martian = new Book("Martian", "Jane Doe", new DateTime(2004, 10, 10));
        Book kodehode = new Book("Kodehode", "Kode Hode", new DateTime(2001, 11, 09));
        Book martian2 = new Book("Martian 2", "Jane Doe", new DateTime(2014, 10, 10));
    }
    public Book LendBook (string title) {
        books.Find ((book) => {
            if (book.Title == title){
                return true;
            }
            else
            {
                return false;
            }
        });

        if (book == null) {
            return "Did not find book";
        }
        else 
        {
            return book;
        }
        
    }
}