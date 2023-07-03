namespace Solutions._0014___Longest_Common_Prefix;

class TestParameter
{
    public string answer;
    public string[] input;

    public TestParameter(string answer, string[] input)
    {
        this.answer = answer;
        this.input = input;
    }
}

public class LongestCommonPrefixSolution : Solution
{
    public SolutionType SolutionType => SolutionType.LongestCommonPrefix;
    public bool Test(bool printTests = true)
    {
        var testCases = new List<TestParameter>()
        {
            new("fl", new[] {"flower", "flow", "flight"}),
            new("", new[] {"dog", "racecar", "car"}),
            new("a", new[] {"a"}),
            new("", new[] {"", "b"}),
            new("", new[] {"", ""}),
            new("a", new[] {"a", "a"}),
            new("a", new[] {"aa", "a"}),
            new("a", new[] {"a", "aa"}),
        };

        var testPassed = true;
        foreach (var c in testCases)
        {
            var result = LongestCommonPrefix(c.input);
            if (c.answer.Equals(result))
            {
                if (printTests)
                    Console.WriteLine("Test Passed");
                continue;
            }

            if (printTests)
                Console.WriteLine("Test Failed");
            testPassed = false;
        }


        return testPassed;
    }


    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        var prefix = "";
        var first = strs[0];
        var fLength = first.Length;
        var totalStrs = strs.Length;

        for (var i = 0; i < fLength; i++)
        {
            var c = first[i];

            for (var j = 1; j < totalStrs; j++)
            {
                var str = strs[j];

                if (str.Length == i || str[i] != c)
                    return prefix;
            }

            prefix += c;
        }

        return prefix;
    }
}