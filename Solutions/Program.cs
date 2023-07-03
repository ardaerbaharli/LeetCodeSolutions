using Solutions._0001___Two_Sum;
using Solutions._0013___Roman_to_Integer;
using Solutions._0014___Longest_Common_Prefix;

namespace Solutions;

public class Program
{
    public static SolutionType CurrentSolutionType = SolutionType.LongestCommonPrefix;

    public static void Main(string[] args)
    {
        if (CurrentSolutionType == SolutionType.All)
        {
            _solutions.Values.ToList().ForEach(s => s.Test());
        }
        else
        {
            var currentSolution = _solutions[CurrentSolutionType];
            currentSolution.Test();
        }

        Console.ReadLine();
    }

    private static Dictionary<SolutionType, Solution> _solutions = new Dictionary<SolutionType, Solution>()
    {
        {SolutionType.TwoSum, new TwoSumSolution()},
        {SolutionType.RomanToInteger, new RomanToIntegerSolution()},
        {SolutionType.LongestCommonPrefix, new LongestCommonPrefixSolution()}
        
    };
}