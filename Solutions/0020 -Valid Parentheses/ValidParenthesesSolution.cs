namespace Solutions._0020__Valid_Parentheses;

class TestParameter
{
    public bool answer;
    public string input;

    public TestParameter(bool answer, string input)
    {
        this.answer = answer;
        this.input = input;
    }
}

public class ValidParenthesesSolution : Solution
{
    public SolutionType SolutionType => SolutionType.ValidParentheses;

    public bool Test(bool printTests = true)
    {
        var testCases = new List<TestParameter>()
        {
            new(true, "()"),
            new(true, "()[]{}"),
            new(false, "(]"),
            new(false, "([)]"),
            new(true, "{[]}"),
            new(false, "){"),
            new(false, "( { [ } ] )"),
        };

        var testPassed = true;
        foreach (var c in testCases)
        {
            var result = IsValid(c.input);
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


    public bool IsValid(string s)
    {
        if (s.Length == 0) return false;
        if (s.Length % 2 != 0) return false;

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var top = stack.Pop();
                if (c == ')' && top != '(')
                {
                    return false;
                }

                if (c == ']' && top != '[')
                {
                    return false;
                }

                if (c == '}' && top != '{')
                {
                    return false;
                }
            }
        }

        return stack.Count <= 0;
    }
}