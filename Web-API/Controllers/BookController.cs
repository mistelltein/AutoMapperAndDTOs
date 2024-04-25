using Microsoft.AspNetCore.Mvc;
using Web_API.DTOs;
using Web_API.Services;

namespace Web_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly BookService _bookService;

    public BookController(BookService bookService)
    {
        this._bookService = bookService;
    }

    [HttpGet("all-books")]
    public ActionResult<List<RequestDTO>> GetBooks() =>
        Ok(_bookService.GetBooks());

    [HttpGet("book/{id}")]
    public ActionResult<ResponseDTO> GetBookById(int id) =>
        Ok(_bookService.GetBookById(id));

    [HttpDelete("book/{id}")]
    public ActionResult DeleteBookById(int id)
    {
        _bookService.DeleteBookById(id);
        
        return Ok("Deleted");
    }

    [HttpPost("book")]
    public ActionResult AddBook(RequestDTO requestDto)
    {
        _bookService.AddBook(requestDto);

        return Ok("Added");
    }
}