namespace Desafio2.Communication.Responses;

public class ResponsesRegisteredUserJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Title { get; internal set; }
}
