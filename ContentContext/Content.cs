namespace Fundamentos.ContentContext;

public abstract class Content
{
    public Content()
    {
        // Regra de negócio em um único local
        Id = Guid.NewGuid(); // SPOF - Single Point of Failure
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
}