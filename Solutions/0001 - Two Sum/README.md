[leet]: https://leetcode.com/problems/two-sum/

# [1 - Two Sum][leet]

## ```Easy```

- Given an array of integers ```nums``` and an integer ```target```, return indices of the two numbers such that they add up to ```target```.

- You may assume that each input would have **exactly one solution**, and you may not use the same element twice.

- You can return the answer in any order.

### Example 1:

```
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
```

### Example 2:

```
Input: nums = [3,2,4], target = 6
Output: [1,2]
```

### Example 3:
```
Input: nums = [3,3], target = 6
Output: [0,1]
```

### Constraints
- ```2 <= nums.length <= 10^4```
- ```-10^9 <= nums[i] <= 10^9```
- ```-10^9 <= target <= 10^9```
- **Only one valid answer exists.**

<br>

## My Solution

```cs
public int[] TwoSum(int[] nums, int target)
    {
        var pairs = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var number = nums[i];
            var remainder = target - number;

            if (pairs.TryGetValue(remainder, out var pair))
            {
                return new[] {pair, i};
            }

            pairs[number] = i;
        }

        return Array.Empty<int>();
    }

```

## Complexity Analysis

- **Time Complexity:** ```O(n)``` - We iterate through the string once, where ```n``` is the length of the string.
- **Space Complexity:** ```O(1)``` - We only use a constant amount of space.