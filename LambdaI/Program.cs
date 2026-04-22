Book book1 = new("Harry Potter and the Sorcerer Stone", "J.K Rowling", 11.99);
Book book2 = new("To Kill a Mocking Bird", "", 6.99);

Func<Book, double> getPrice = book => book.Price;

// Using the Func Lambda Expression
Console.WriteLine($"{book1.Title} costs {getPrice(book1):C}");
Console.WriteLine($"{book2.Title} costs {getPrice(book2):C}");

// Not Using the Func Lambda Expression - Access Price Property of the Object
// Console.WriteLine($"{book1.Title} costs {book1.Price:C}");

Action<Book> printAuthor = book => Console.WriteLine($"Author: {book.Author}");

printAuthor(book1);
printAuthor(book2);