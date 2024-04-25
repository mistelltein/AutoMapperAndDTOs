using AutoMapper;
using Web_API.DTOs;
using Web_API.Models;

namespace Web_API.Services;

public class BookService
{
    private readonly IMapper _mapper;
    
    public BookService(IMapper mapper)
    {
        this._mapper = mapper;
    }

    public List<RequestDTO> GetBooks()
    {
        var mapBooks = _mapper.Map<List<RequestDTO>>(_books);
        return mapBooks;
    }

    public void AddBook(RequestDTO requestDto)
    {
        var book = _mapper.Map<Book>(requestDto);
        book.Id = _books.Count + 1;
        _books.Add(book);
    }

    public ResponseDTO GetBookById(int id)
    {
        var book = _books.FirstOrDefault(x => x.Id == id);
        var mapBook = _mapper.Map<ResponseDTO>(book);

        return mapBook;
    }
    public void DeleteBookById(int id) => _books.Remove(_books.FirstOrDefault(x => x.Id == id)!);

    private readonly List<Book> _books = new()
    {
        new Book {Id = 0, Title = "An empty box and a zero Maria", Author = "Eiji Mikage", Year = 2009, Price = 12.50},
        new Book {Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Price = 10.99},
        new Book {Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Price = 9.99},
        new Book {Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, Price = 11.25},
        new Book {Id = 4, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, Price = 8.75},
        new Book {Id = 5, Title = "Animal Farm", Author = "George Orwell", Year = 1945, Price = 7.99},
        new Book {Id = 6, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932, Price = 10.50},
        new Book {Id = 7, Title = "Lord of the Flies", Author = "William Golding", Year = 1954, Price = 9.25},
        new Book {Id = 8, Title = "The Grapes of Wrath", Author = "John Steinbeck", Year = 1939, Price = 10.75},
        new Book {Id = 9, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, Price = 8.99},
        new Book {Id = 10, Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937, Price = 11.99},
        new Book {Id = 11, Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", Year = 1967, Price = 13.25},
        new Book {Id = 12, Title = "The Da Vinci Code", Author = "Dan Brown", Year = 2003, Price = 9.50},
        new Book {Id = 13, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Year = 1954, Price = 15.99},
        new Book {Id = 14, Title = "Moby-Dick", Author = "Herman Melville", Year = 1851, Price = 12.99},
        new Book {Id = 15, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866, Price = 11.50}
    };
}