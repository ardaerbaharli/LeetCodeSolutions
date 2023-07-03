namespace Solutions._0013___Roman_to_Integer;

class TestParameter
{
    public int answer;
    public string input;

    public TestParameter(int answer, string input)
    {
        this.answer = answer;
        this.input = input;
    }
}

public class RomanToIntegerSolution : Solution
{
    public bool Test()
    {
        var testCases = new List<TestParameter>()
        {
            new(3, "III"),
            new(4, "IV"),
            new(9, "IX"),
            new(58, "LVIII"),
            new(1994, "MCMXCIV"),
        };

        var testPassed = true;
        foreach (var c in testCases)
        {
            var result = RomanToInt(c.input);
            if (c.answer.Equals(result))
            {
                Console.WriteLine("Test Passed");
                continue;
            }

            Console.WriteLine("Test Failed");
            testPassed = false;
        }

        
        return testPassed;
    }

    private Dictionary<char, int> dict = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    public int RomanToInt(string s)
    {
        if (s.Length == 0) return 0;

        var sum = dict[s.Last()];
        for (var i = s.Length - 2; i >= 0; i--)
        {
            var previousChar = s[i + 1];
            var previousValue = dict[previousChar];
            var currentChar = s[i];
            var currentValue = dict[currentChar];
            if (previousValue > currentValue)
                sum -= currentValue;
            else sum += currentValue;
        }
        

        return sum;
    }
}