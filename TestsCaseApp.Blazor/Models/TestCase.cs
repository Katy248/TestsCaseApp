namespace TestsCaseApp.Blazor.Models;

public class TestCase : DbEntity
{
    public int Number { get; set; }
    public string Name { get; set; }
    public string Precondition { get; set; }
    public string RequiredResult { get; set; }
    public ICollection<TestCaseStep> Steps { get; set; } = new List<TestCaseStep>();
    public TestCaseResult? Result { get; set; }
}