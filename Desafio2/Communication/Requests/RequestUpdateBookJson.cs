namespace Desafio2.Communication.Requests;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = string.Empty;

    public string BookGenres { get; set; } = string.Empty;

    public float Price { get; set; }

    public int Quantity { get; set; }
}
