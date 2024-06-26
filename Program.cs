﻿/*
int[] candies = { 8, 4, 1, 7 };
 static int GetMissingCandies(int[] candies)
{
    int result = 0;
    if (candies.Length > 1)
    {
        int mostCandies = candies.Max();
        int[] otherKids = candies.Where(candy => candy != mostCandies).ToArray();
        foreach (var kid in otherKids)
        {
            result += mostCandies - kid;

        }
        return result;

    }
    return -1;
}
GetMissingCandies(candies);
*/

// Example : "This is an example!" ==> "sihT si na !elpmaxe"
/*
using System.Text;

static string ReverseWords(string str)
{
    StringBuilder reversed = new StringBuilder("");
    for (int i = 0; i < str.Split(" ").Length; i++)
    {
        string currentWord = str.Split(" ")[i].ToString().Insert(str.Split(" ")[i].Length,"|");
        for (int y = currentWord.Length - 1; y >= 0; y--)
        {
            reversed.Append(currentWord[y]);
        }
    }
    string result = reversed.ToString().Replace("|", " ").Substring(1);
    Console.WriteLine(result);
    return result;
}
ReverseWords("Here is an example!");
*/

// Remove duplicate words
/*
using System.Text;

static string RemoveDuplicateWords(string s)
{
    string filteredString = "";
    string[] strArray = s.Split(" ");
    for(int i = 0; i  < strArray.Length; i++)
    {
        if (!filteredString.Contains(strArray[i])){
        filteredString += strArray[i] + "|";
        }
           filteredString += "";
    }
    Console.WriteLine(filteredString.Replace("|", " ").Remove(filteredString.Length - 1));
    return filteredString.Replace("|", " ").Remove(filteredString.Length - 1);

    // Faster, senior way:
  //  return string.Join(" ", s.Split(' ').Distinct());
}

RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta");
*/

//Your task, is to create N×N multiplication table, of size provided in parameter.
//For example, when given size is 3:
//1 2 3
//2 4 6
//3 6 9

/*
static int[,] MultiplicationTable(int size)
{
    int[,] table = new int[size, size];
        List<int> row = new List<int>();
    for (int i = 1; i <= size; i++)
    {
        row.Add(i);
        table[i - 1, 0] = i;

        for(int y = 2; y < size; y++)
        {
            table[i - 1, y - 1] = row[y - 2] * i;

        }
    }
    Console.WriteLine(row.ToString());
    Console.WriteLine(string.Join(", ", table));
    return table;
    }


MultiplicationTable(3);
*/

//In this Kata, your function receives an array of integers as input. Your task is to determine whether the numbers are in ascending order. An array is said to be in ascending order if there are no two adjacent integers where the left integer exceeds the right integer in value.

/*
 static bool IsAscOrder(int[] arr)
{
    int[] sortedArr = new int[arr.Length];
    Array.Copy(arr, sortedArr, arr.Length);
    Array.Sort(sortedArr);

    // Check if the sorted array is equal to the original array
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != sortedArr[i])
        {
            return false;
        }
    }

    return true;

    // simple solution, senior shit -  return arr.SequenceEqual(arr.OrderBy(x=>x));
}

IsAscOrder(new int[] { 1, 2 });
*/

//Description:
//We want to generate a function that computes the series starting from 0 and ending until the given number.
//Example:
//Input: 6
//Output: 0 + 1 + 2 + 3 + 4 + 5 + 6 = 21
//Input: -15
//Output: -15 < 0

/*
static string ShowSequence(int n)
{
    string sumString = "";
    int sum = 0;
    if (n < 0)
    {
        Console.WriteLine($"{n}<0");
        return $"{n}<0";
    }else if (n == 0)
    {
    return $"{n}=0";
    }
    else
    {
        for (int i = 0; i <= n; i++)
        {   if(i == n)
            {
              sumString += i;
              sum += i;
            }else
            {
            sumString += i + "+";
            sum += i;

            }
        }
        return $"{sumString} = {sum.ToString()}";

    }
}
// Senior solution :D

 public static string ShowSequence(int n)
  {
    if(n < 0) return $"{n}<0";
    if(n == 0) return "0=0";
    
    IEnumerable<int> sequence = Enumerable.Range(0, n+1);
    
    return $"{String.Join("+", sequence)} = {sequence.Sum()}";
  }

ShowSequence(6);
*/

//Given a string indicating a range of letters, return a string which includes all the letters in that range, including the last letter.
//Note that if the range is given in capital letters, return the string in capitals also!
/*Examples
"a-z" ➞ "abcdefghijklmnopqrstuvwxyz"
"h-o" ➞ "hijklmno"
"Q-Z" ➞ "QRSTUVWXYZ"
"J-J" ➞ "J"*/
/* static string GimmeTheLetters(string sp)
{
    int rangeStart = (int)sp[0];
    int rangeEnd = (int)sp[2];
    
    return string.Concat(Enumerable.Range(rangeStart, rangeEnd).Select(x => (char)x).Where(x => x <= rangeEnd));
}
GimmeTheLetters("a-b");*/

/*Complete the method which returns the number which is most frequent in the given input array. If there is a tie for most frequent number, return the largest number among them.
Note: no empty arrays will be given.
Examples
[12, 10, 8, 12, 7, 6, 4, 10, 12] --> 12
[12, 10, 8, 12, 7, 6, 4, 10, 12, 10]-- > 12
[12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10]-- > 3*/

/*static int HighestRank(int[] arr)
{
    *//*for (int i = 0; i < arr.Length; i++)
    {
        return 0;s
    }*//*
    var intList = arr.ToList();
    intList.Sort();
    var consecutivePairs = intList.Zip(intList.Skip(1), (current, next) => current == next);
    Console.WriteLine(string.Join(", ", consecutivePairs));
    return 9;
}
var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
HighestRank(arr);*/

/*The first input array is the key to the correct answers to an exam, like["a", "a", "b", "d"]. The second one contains a student's submitted answers.

The two arrays are not empty and are the same length. Return the score for this array of answers, giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer, represented as an empty string (in C the space character is used).

If the score < 0, return 0.
For example:
checkExam(["a", "a", "b", "b"], ["a", "c", "b", "d"]) → 6
checkExam(["a", "a", "c", "b"], ["a", "a", "b",  ""]) → 7
checkExam(["a", "a", "b", "c"], ["a", "a", "b", "c"]) → 16
checkExam(["b", "c", "b", "a"],["",  "a", "a", "c"]) → 0*/


/*  static int CheckExam(string[] arr1, string[] arr2)
    {
*//*    int result = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] == arr2[i])
        {
            result += 4;
        }
        if (arr1[i] != arr2[i] && arr2[i] != "")
        {
            result -= 1;
        }
        else if (arr1[i] != arr2[i] && arr2[i] == "")
        {
            result += 0;
        }
    }
    return result < 0 ? result * 0 : result;*//*
    int result = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        result = arr2[i] == "" ? result + 0 : arr1[i] == arr2[i] ? result + 4 : result - 1;
    }
    return result < 0 ? 0 : result;
}*/

/*Write a function that when given a number >= 0, returns an Array of ascending length subarrays.
pyramid(0) => [ ]
pyramid(1) => [ [1] ]
pyramid(2) => [ [1], [1, 1] ]
pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]
Note: the subarrays should be filled with 1s*/
/*static int[][] Pyramid(int n)
{
    int[][] pyramid = new int[n][];
    for (int i = 0; i < n; i++)
    {
        int[] array = new int [i + 1];
        pyramid[i] = array.Select(item => item + 1).ToArray();
    }
    return pyramid;
}
// static int[][] Pyramid(int n) => Enumerable.Range(1, n).Select(x => Enumerable.Repeat(1, x).ToArray()).ToArray();
Pyramid(7);*/

/*Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. 
You don't need to validate the form of the Roman numeral.*/

/*Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false*/
/*static bool XO(string input)
{
    int oCount = 0;
    int xCount = 0;

    if (input == "")
    {
        return true;
    }

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].ToString().ToLower() == "o") oCount += 1;
        if (input[i].ToString().ToLower() == "x") xCount += 1;
    }
    return (xCount > 0 && oCount > 0) ? oCount == xCount : false;

    // easy senior one-liner :D
    // return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
}
XO("xoXm");*/

/*Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"
Your task is to process a string with "#" symbols.
Examples
"abc#d##c"      ==>  "ac"
"abc##d######"  ==>  ""
"#######"       ==>  ""
""              ==>  ""*/

/*static string CleanString(string s)
  {
    char[] chars = s.ToCharArray();
    int count = 0;

    foreach (char c in chars)
    {
        if (c == '#')
        {
            if (count > 0)
            {
                chars[count - 1] = '\0';
                count--;
            }
        }
        else
        {
            chars[count++] = c;
        }
    }

    string cleanedString = new string(chars, 0, count);

    return cleanedString;
}

CleanString("abc####d##c#");*/

/*Implement a function that accepts 3 integer values a, b, c. 
The function should return true if a triangle can be built with the sides of given length and false in any other case.
static bool IsTriangle(int a, int b, int c)
{
    return a > 0 && a + b > c && b + c > a && a + c > b;
}*/

/*Winter is coming, you must prepare your ski holidays. The objective of this kata is to determine the number of pair of gloves you can constitute from the gloves you have in your drawer.
Given an array describing the color of each glove, return the number of pairs you can constitute, assuming that only gloves of the same color can form pairs.
Examples:
input = ["red", "green", "red", "blue", "blue"]
result = 2(1 red pair + 1 blue pair)

input = ["red", "red", "red", "red", "red", "red"]
result = 3(3 red pairs)*/

/*static int NumberOfPairs(string[] gloves)
{
    static Dictionary<string, int> CountPairs(string[] gloves)
    {
        var pairs = gloves.GroupBy(g => g).ToDictionary(g => g.Key, g => g.Count());
        return pairs;
    }

    Dictionary<string, int> pairs = CountPairs(gloves);

    int result = pairs.Values.Select(v => v / 2).Sum();

    return result;

    // other solutions:
    //return gloves.GroupBy(p => p).Select(q => q.Count() / 2).Sum();
   *//* int result = 0;
    string[] sortedAr = gloves;
    Array.Sort(sortedAr);
    for (int i = 0; i < sortedAr.Length - 1; i++)
    {
        if (sortedAr[i] == sortedAr[i + 1])
        {
            i++;
            result++;
        }
    }
    return result;*//*
}

NumberOfPairs(new string[] { "Blue", "Purple", "Blue", "Grey", "Lime", "Black" });*/

/*Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation. Lowercase characters can be numbers. If the method gets a number as input, it should return a string.
Examples
"TestController"  -->  "test_controller"
"MoviesAndBooks"  -->  "movies_and_books"
"App7Test"        -->  "app7_test"
1                 -->  "1"*/

static string ToUnderscore(object str)
{
    if (str is int)
    {
        return str.ToString();
    }
    else if (str is string)
    {
        string lowerCaseString = str.ToString().ToLower();
        string snake_case = "";
        for (int i = 0; i < str.ToString().Length; i++)
        {
            if (str.ToString()[i] == lowerCaseString[i])
            {
                snake_case += lowerCaseString[i];
            }
            else
            {
                snake_case += "_" + lowerCaseString[i];
            }
        }
        return snake_case.Substring(1);
    }
    return "";
}

// other solution

/*using System.Text;

public static string ToUnderscore(int str)
{
    return ToUnderscore(str.ToString());
}

public static string ToUnderscore(string str)
{
    StringBuilder sb = new StringBuilder();
    foreach (var ch in str)
    {
        if (Char.IsUpper(ch))
        {
            sb.Append('_');
        }
        sb.Append(Char.ToLower(ch));
    }
    return sb.ToString().TrimStart('_');
}


ToUnderscore("ThisIsBeautifulDay");*/

/*static int RomanDecodeSolution(string roman){
    string[] romanNumerals =  { "I","V","X", "L", "C", "D", "M" };

    int[] values = { 1, 5, 19, 50, 100, 500, 1000 };
    return 0;
}
RomanDecodeSolution("M");*/