#region Problem
/*
Convert a non-negative integer num to its English words representation.

Example 1:
Input: num = 123
Output: "One Hundred Twenty Three"

Example 2:
Input: num = 12345
Output: "Twelve Thousand Three Hundred Forty Five"

Example 3:
Input: num = 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"

LeetCode link: https://leetcode.com/problems/integer-to-english-words/
*/
#endregion

#region Solution

Console.WriteLine(NumberToWords(1234567891));
static string NumberToWords(int num)
{
    if (num == 0) return "Zero";

    string words = "";

    if ((num / 1000000000) > 0)
    {
        words += NumberToWords(num / 1000000000) + " Billion ";
        num %= 1000000000;
    }

    if ((num / 1000000) > 0)
    {
        words += NumberToWords(num / 1000000) + " Million ";
        num %= 1000000;
    }

    if ((num / 1000) > 0)
    {
        words += NumberToWords(num / 1000) + " Thousand ";
        num %= 1000;
    }

    if ((num / 100) > 0)
    {
        words += NumberToWords(num / 100) + " Hundred ";
        num %= 100;
    }

    if (num > 0)
    {
        var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        if (num < 20)
            words += unitsMap[num];
        else
        {
            words += tensMap[num / 10];
            if ((num % 10) > 0)
                words += " " + unitsMap[num % 10];
        }
    }

    return words.TrimEnd(' ');
}

#endregion