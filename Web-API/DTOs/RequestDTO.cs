namespace Web_API.DTOs;

public class RequestDTO
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Year { get; set; }
    public double Price { get; set; }
}