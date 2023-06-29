namespace TestsCaseApp.Blazor.Models;

public class TestCaseStep : DbEntity
{
    public TestCase TestCase { get; set; }
    public int Number { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; } = false;
}