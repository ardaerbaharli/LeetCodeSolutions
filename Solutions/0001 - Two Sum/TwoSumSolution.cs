namespace Solutions._0001___Two_Sum;

class TestParameter
{
    public int[] answer;
    public int[] nums;
    public int target;

    public TestParameter(int[] answer, int[] nums, int target)
    {
        this.answer = answer;
        this.nums = nums;
        this.target = target;
    }
}

public class TwoSumSolution : Solution
{
    public SolutionType SolutionType => SolutionType.TwoSum;

    public bool Test(bool printTests = true)
    {
        var testCases = new List<TestParameter>()
        {
            new(new[] {0, 1}, new[] {2, 7, 11, 15}, 9),
            new(new[] {1, 2}, new[] {3, 2, 4}, 6),
            new(new[] {0, 1}, new[] {3, 3}, 6),
        };

        var testPassed = true;
        foreach (var c in testCases)
        {
            var result = TwoSum(c.nums, c.target);

            if (c.answer.SequenceEqual(result))
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

    public int[] TwoSum(int[] nums, int target)
    {
        var ans = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var n1 = nums[i];
            var remainder = target - n1;

            if (ans.TryGetValue(remainder, out var n1Index))
            {
                return new[] {n1Index, i};
            }

            ans[n1] = i;
        }

        return Array.Empty<int>();
    }
}