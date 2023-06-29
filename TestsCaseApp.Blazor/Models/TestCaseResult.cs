namespace TestsCaseApp.Blazor.Models;

public class TestCaseResult : DbEntity
{
    public TestCase TestCase { get; set; }
    public string TestCaseId { get; set; }
    public bool Success { get; set; }
    public string Comment { get; set; }
}