[leet]: https://leetcode.com/problems/longest-common-prefix/

# [14 - Longest Common Prefix][leet]

## ```Easy```

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:
```
Input: strs = ["flower","flow","flight"]
Output: "fl"
```

Example 2:
```
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
```

Constraints:
```
0 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
```


## My Solution

```cs
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
```

## Complexity Analysis

- **Time Complexity:** ```O(n)``` - We iterate through the string once, where ```n``` is the length of the string.
- **Space Complexity:** ```O(1)``` - We only use a constant amount of space.

