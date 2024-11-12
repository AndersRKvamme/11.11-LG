using System.Net;

class Book {
    //  Data fields
        public string Title;

        public string Author;

        public DateTime FirstPublished;

    //  Constructor for the Class, decides how to construct a valid object
    public Book (string title, string author, DateTime firstPublished)
    {
        Author = author;
        Title = title;
        FirstPublished = firstPublished;
    } 
}