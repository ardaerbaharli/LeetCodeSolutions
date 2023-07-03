[leet]: https://leetcode.com/problems/valid-parentheses/

# [20 - Valid Parentheses][leet]

## ```Easy```

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:

- Open brackets must be closed by the same type of brackets.
- Open brackets must be closed in the correct order.

Example 1:
```
Input: s = "()"
Output: true
```

Example 2:
```
Input: s = "()[]{}"
Output: true
```

Example 3:
```
Input: s = "(]"
Output: false
```

Example 4:
```
Input: s = "([)]"
Output: false
```

Example 5:
```
Input: s = "{[]}"
Output: true
```

Constraints:
```
1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
```

## My Solution

```cs

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
```

## Complexity

Time Complexity: O(n)

Space Complexity: O(n)

