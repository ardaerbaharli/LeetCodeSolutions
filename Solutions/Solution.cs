namespace Solutions;

public interface Solution
{
    public SolutionType SolutionType { get; }
    public bool Test(bool printTests = true);
}