namespace TestsCaseApp.Blazor.Models;

public class DbEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
}