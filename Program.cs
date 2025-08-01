using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

/*
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

/*static string ToUnderscore(object str)
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
}*/

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
 public static string ToUnderscore(int str) => str.ToString();
 public static string ToUnderscore(string str) => Regex.Replace(str, "(\\B[A-Z]\\B)", "_$1").ToLower();

ToUnderscore("ThisIsBeautifulDay");*/

/*static int RomanDecodeSolution(string roman){
    string[] romanNumerals =  { "I","V","X", "L", "C", "D", "M" };

    int[] values = { 1, 5, 19, 50, 100, 500, 1000 };
    return 0;
}
RomanDecodeSolution("M");*/

// N-th Fibonacci

/*I love Fibonacci numbers in general, but I must admit I love some more than others.
I would like for you to write me a function that, when given a number n (n >= 1 ), returns the nth number in the Fibonacci Sequence.
For example:
NthFib(4) == 2
Because 2 is the 4th number in the Fibonacci Sequence.
For reference, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.*/

/*static int NthFib(int n)
{
     List<int> GenerateFibonacci(int n)
    {
        List<int> sequence = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (i > 1)
            {
                int sum = sequence[i - 1] + sequence[i - 2];
                sequence.Add(sum);
            }
            else
            {
                sequence.Add(i);
            }
        }
        return sequence;
    }

    List<int> fibonacciSequence = GenerateFibonacci(n);

    return fibonacciSequence[n - 1];

    // Senior solution: 
    static int NthFib(int n)
    {
        if (n == 1) return 0;
        if (n == 2) return 1;
        return NthFib(n - 2) + NthFib(n - 1);
    }
}

Console.WriteLine(NthFib(4));*/

/*using System.ComponentModel.Design;
For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.
The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.
The following are some examples of how this class is used:

var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
helper.PageCount; // should == 2
helper.ItemCount; // should == 6
helper.PageItemCount(0); // should == 4
helper.PageItemCount(1); // last page - should == 2
helper.PageItemCount(2); // should == -1 since the page is invalid

// pageIndex takes an item index and returns the page that it belongs on
helper.PageIndex(5); // should == 1 (zero based index)
helper.PageIndex(2); // should == 0
helper.PageIndex(20); // should == -1
helper.PageIndex(-10); // should == -1*/

/*public class PaginationHelper<T>
{
    // TODO: Complete this class
    private readonly IList<T> _collection;
    public int _itemsPerPage;

    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PaginationHelper(IList<T> collection, int itemsPerPage)
    {
        _collection = collection;
        _itemsPerPage = itemsPerPage;
    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount
    {
        get
        {
            return _collection.Count() >= 0 ? _collection.Count() : -1;
        }
    }

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount
    {
        get
        {
            return (int)Math.Ceiling((double)_collection.Count() / _itemsPerPage);
        }
    }

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        if (pageIndex >= PageCount || pageIndex <= -1)
        {
            return -1;
        }
        if (pageIndex == PageCount - 1)
        {
            return ItemCount % _itemsPerPage == 0 ? ItemCount / PageCount : ItemCount % _itemsPerPage;
        }
        return _itemsPerPage;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        return itemIndex + 1 <= ItemCount && itemIndex > -1 ? (int)Math.Floor((decimal)itemIndex / _itemsPerPage) : -1;
    }
}*/

/*Given an array arr of strings, complete the function by calculating the total perimeter of all the islands.
Each piece of land will be marked with 'X' while the water fields are represented as 'O'. Consider each tile being a perfect 1 x 1 piece of land. Some examples for better visualization:

['XOOXO',
 'XOOXO',
 'OOOXO',
 'XXOXO',
 'OXOOO']*/

/*static string Calculate(string[] map)
{
    int total = 0;
    var squarePositions = new List<int[]>();

    for (var row = 0; row < map.Length; row++)
    {
        var matrixRow = map[row];

        var rowLinesCount = matrixRow.Where(ch => ch.ToString() == "X").Count();

        List<int> squaresPerRow = new List<int>();

        int rowLength = matrixRow.Length;

        if (rowLength == 1)
        {
            return $"Total land perimeter: {rowLinesCount * 4}";
        }
        for (int i = 0; i < rowLength; i++)
        {
            if (matrixRow[i].ToString() == "X")
            {
                total += 4;
                squaresPerRow.Add(i);
            }
        }

        squarePositions.Add(squaresPerRow.ToArray());
    }
    if (squarePositions.ToList().Count() >= 1)
    {
        for (int row = 0; row < squarePositions.ToArray().Length; row++)
        {
            var squarePositionsRow = squarePositions[row];

            var squaresPerRow = squarePositionsRow.Length;

            var matrixRow = map[row];

            if (row < squarePositions.ToArray().Length - 1)
            {
                int numOfNextMatches = squarePositionsRow.Where(p => squarePositions[row + 1].Contains(p)).Count();

                if (numOfNextMatches > 0)
                {
                    total -= numOfNextMatches * 2;
                }
            }
            for (int i = matrixRow.ToArray().Length - 1; i > 0; i--)
            {
                if (matrixRow[i].ToString() == "X")
                {
                    if (matrixRow[i].ToString() == matrixRow[i - 1].ToString())
                    {
                        total -= 2;
                    }
                }
            }
        }
    }
    return $"Total land perimeter: {total}";
}*/
// Senior solution:

/*static string Calculate(string[] map)
{
    var sum = 0;
    for (var i = 0; i < map.Length; i++)
    {
        for (var j = 0; j < map[i].Length; j++)
        {
            if (map[i][j] == 'X')
            {
                sum += 4;
                if (i + 1 < map.Length && map[i + 1][j] == 'X')
                {
                    sum -= 2;
                }
                if (j + 1 < map[i].Length && map[i][j + 1] == 'X')
                {
                    sum -= 2;
                }
            }
        }
    }
    return $"Total land perimeter: {sum}";
}
*/
//Calculate(new string[] { "XOOOXOO", "OXOOOOO", "XOXOXOO", "OXOXXOO", "OOOOOXX", "OOOXOXX", "XXXXOXO" });

/*Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.

Note: a and b are not ordered!

Examples (a, b) --> output(explanation)
(1, 0)-- > 1(1 + 0 = 1)
(1, 2)-- > 3(1 + 2 = 3)
(0, 1)-- > 1(0 + 1 = 1)
(1, 1)-- > 1(1 since both are same)
(-1, 0)-- > -1(-1 + 0 = -1)
(-1, 2)-- > 2(-1 + 0 + 1 + 2 = 2)*/
/*static int GetSum(int a, int b)
{
    int sum = 0;

    if (a < b)
    {
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
    }
    if (a > b)
    {
        for (int i = a; i >= b; i--)
        {
            sum += i;
        }
    }
    if(a == b)
    {
        return a;
    }
    return sum;
}
// Senior solution :D
static int GetSum(int a, int b) => (Math.Abs(a - b) + 1) * (a + b) / 2;
GetSum(2, 1);*/

//I'm sure, you know Google's "Did you mean ...?", when you entered a search term and mistyped a word. In this kata we want to implement something similar.
//You'll get an entered term (lowercase string) and an array of known words (also lowercase strings). Your task is to find out, which word from the dictionary is most similar to the entered one. The similarity is described by the minimum number of letters you have to add, remove or replace in order to get from the entered word to one of the dictionary. The lower the number of required changes, the higher the similarity between each two words.
//Same words are obviously the most similar ones. A word that needs one letter to be changed is more similar to another word that needs 2 (or more) letters to be changed. E.g. the mistyped term berr is more similar to beer (1 letter to be replaced) than to barrel (3 letters to be changed in total).
//Extend the dictionary in a way, that it is able to return you the most similar word from the list of known words.
//Code Examples:

//var fruits = new Kata(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
//fruits.FindMostSimilar("strawbery"); // must return "strawberry"
//fruits.FindMostSimilar("berry"); // must return "cherry"

//things = new Dictionary(new List<string> { "stars", "mars", "wars", "codec", "codewars" });
//things.FindMostSimilar("coddwars"); // must return "codewars"

//languages = new Dictionary(new List<string> { "javascript", "java", "ruby", "php", "python", "coffeescript" });
//languages.FindMostSimilar("heaven"); // must return "java"

//var words = new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" };
//string FindMostSimilar(string term)
//{
//    List<int> mathchesPerWord = new List<int>();

//    for (int i = 0; i < words.ToArray().Length; i++)
//    {
//        var charArray = words[i].ToCharArray();

//        int matches = 0;

//        //int maxLengthMismatch = charArray.Length + 2;
//        //int minLengthMismatch = charArray.Length + -2;

//        //if (term.Length <= maxLengthMismatch && term.Length >= minLengthMismatch)
//        //{
//        //    matches++;
//        //}

//        for (int y = 0; y < charArray.Length; y++)
//        {
//            if (term.Contains(charArray[y]))
//            {
//                matches++;
//            }
//        }
//        mathchesPerWord.Add(matches);
//    }
//    for (int i = 0; i < words.ToArray().Length; i++)
//    {
//        if (term.Length < mathchesPerWord[i] && mathchesPerWord[i] == term.Length || mathchesPerWord[i] <= term.Length - 1)
//        {
//            mathchesPerWord[i]++;
//        }
//    }
//    var match = mathchesPerWord.Max();


//    var matchIndex = mathchesPerWord.IndexOf(match);

//    List<string> possibleMatches = new List<string>();
//    foreach (var word in mathchesPerWord)
//    {
//        //if (word == match)
//        //{
//        //    possibleMatches.Add(words[matchIndex]);
//        //}
//        //if (words[matchIndex].Length == term.Length - 1 || words[matchIndex].Length == term.Length + 1 || words[matchIndex].Length == term.Length)
//        //{
//        //    possibleMatches.Add(words[matchIndex]);
//        //}
//    }
//    Console.WriteLine(words[matchIndex]);
//    Console.WriteLine(string.Join(", ", mathchesPerWord));
//    Console.WriteLine(string.Join(", ", possibleMatches));

//    return words[matchIndex];
//}

//FindMostSimilar("berry");



//static string ComputeMD5Hash(string input)
//{
//    byte[] inputBytes = Encoding.UTF8.GetBytes(input);

//    using (MD5 md5 = MD5.Create())
//    {
//        var str = Encoding.UTF8.GetBytes(input);
//        var test = MD5.HashData(str);
//        byte[] hashBytes = md5.ComputeHash(inputBytes);
//        StringBuilder sb = new StringBuilder();
//        foreach (byte b in hashBytes)
//        {
//            sb.Append(b.ToString("x2"));
//        }
//        Console.WriteLine("Hash: " + sb.ToString());
//        return sb.ToString();
//    }
//}
//static string crack(string hash)
//{
//    var pinLength = 5;
//    var hashTest = "00000";
//    var numberOfPenTests = 0;
//    var crackedPinHash = hash == hashTest;
//    var maxNumOfCombination = Math.Pow(10, pinLength);

//    var currentNum = 1;
//    while (!crackedPinHash)
//    {
//        for (int i = 0; i < maxNumOfCombination; i++)
//        {
//            var potentialPin = hashTest.Substring(0, pinLength - i.ToString().Length);
//            potentialPin += i.ToString();
//            numberOfPenTests++;
//            var potentialHash = ComputeMD5Hash(potentialPin);

//            if (hash == potentialHash)
//            {
//                crackedPinHash = true;
//                hashTest = potentialPin;
//                return potentialPin;
//            }
//            else
//            {
//                continue;
//            }
//        }


//        crackedPinHash = true;
//        currentNum++;
//        Console.WriteLine("PIN: " + new string(hashTest));
//    }
//    // C0d3 g03s h3r3
//    string inputString = "92000";
//    string hashValue = ComputeMD5Hash(inputString);
//    Console.WriteLine($"MD5 Hash: {hashValue}");
//    Console.WriteLine($"Result: {hashTest}");
//    ComputeMD5Hash(inputString);
//    Console.WriteLine($"Number of pen tests: {numberOfPenTests}");
//    return hashTest;


//}
////crack("5e8bc9faf28ed52ee7c6142f69a12616");
//crack("827ccb0eea8a706c4c34a16891f84e7b");

//static string crack(string hash)
//{
//    var pinLength = 5;
//    var maxNumOfCombination = Math.Pow(10, pinLength);
//    for (int i = 0; i < maxNumOfCombination; i++)
//    {
//        var potentialPin = i.ToString("D5");
//        var potentialHash = ComputeMD5Hash(potentialPin);

//        if (hash == potentialHash)
//        {
//            Console.WriteLine(potentialPin);
//            return potentialPin;
//        }
//    }
//    return "";
//}

//static string ComputeMD5Hash(string input)
//{
//    using (MD5 md5 = MD5.Create())
//    {
//        byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
//        StringBuilder sb = new StringBuilder();
//        foreach (byte b in hashBytes)
//        {
//            sb.Append(b.ToString("x2"));
//        }
//        return sb.ToString();
//    }
//}

//crack("827ccb0eea8a706c4c34a16891f84e7b");


//The makeLooper() function(or make_looper in your language) takes a string (of non-zero length) as an argument. It returns a function. The function it returns will return successive characters of the string on successive invocations. It will start back at the beginning of the string once it reaches the end.
//For example:
//Func<char> abc = Kata.MakeLooper("abc");
//abc(); // should return 'a' on this first call
//abc(); // should return 'b' on this second call
//abc(); // should return 'c' on this third call
//abc(); // should return 'a' again on this fourth call
//Different loopers should not affect each other, so be wary of unmanaged global state.




//Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

//Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

//If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

//Examples
//"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
//"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
//""  -->  ""

//static string Order(string words)
//{
//    var wordsList = words.Split(' ');

//    var ordered = new string[wordsList.Length + 1];

//    for (int i = 0; i < wordsList.Length; i++)
//    {
//        for (int j = 0; j < wordsList[i].Length; j++)
//        {
//            int idx;
//            int.TryParse(wordsList[i][j].ToString(), out idx);

//            if (idx > 0)
//            {
//                ordered[idx - 1] = wordsList[i].ToString();
//            }

//        }
//    }

//    return string.Join(" ", ordered).Trim();
//}

//// OR:
//static string Order(string words)
//{
//    if (string.IsNullOrEmpty(words)) return words;
//    return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
//}

//Order("is2 Thi1s T4est 3a");





//Complete the solution so that the function will break up camel casing, using a space between words.

//Example
//"camelCasing"  =>  "camel Casing"
//"identifier"   =>  "identifier"
//""             =>  ""

//static string BreakCamelCase(string str)
//{
//    var isCamelCase = str == str.ToLower();

//    if (string.IsNullOrEmpty(str) && !isCamelCase)
//    {
//        return str;
//    }

//    var upperChar = new List<int>();
//    var i = 0;
//    foreach (char c in str)
//    {
//        if (c.ToString() != c.ToString().ToLower())
//        {
//            upperChar.Add(i);
//        }
//        i++;
//    }

//    var result = "";
//    var lastI = 0;
//    foreach (int x in upperChar)
//    {
//        result += str.Substring(lastI, x - lastI) + " ";
//        lastI = x;
//    }

//    result += str.Substring(lastI);

//    Console.WriteLine(string.Join(" ", result));
//    Console.WriteLine(lastI);


//    return result;
//}

//BreakCamelCase("camelCasingCaseCaseeee");

//How can you tell an extrovert from an introvert at NSA?
//Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
//I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it?
//According to Wikipedia, ROT13 is frequently used to obfuscate jokes on USENET.
//For this task you're only supposed to substitute characters. Not spaces, punctuation, numbers, etc.

//Test examples:
//"EBG13 rknzcyr."-> "ROT13 example."
//"This is my first ROT13 excercise!"-> "Guvf vf zl svefg EBG13 rkprepvfr!"

static string Rot13(string input)
{
    var sb = new StringBuilder();

    foreach (char c in input)
    {
        var asciiNum = (int)c;

        if (asciiNum >= 65 && asciiNum <= 90)
        {
            asciiNum += 13;
            if (asciiNum > 90)
            {
                var left = asciiNum - 90;
                asciiNum = 65 + left - 1;
            }
            var ch = (char)asciiNum;
            sb.Append(ch);
            continue;
        }
        if (asciiNum >= 97 && asciiNum <= 122)
        {
            asciiNum += 13;
            if (asciiNum > 122)
            {
                var left = asciiNum - 122;
                asciiNum = 97 + left - 1;
            }
            var ch = (char)asciiNum;
            sb.Append(ch);
            continue;
        }

        sb.Append(c);
    }
    Console.WriteLine(sb.ToString());
    return sb.ToString();

    // better solution
//    return new string(input.Select(x =>
//   char.IsLetter(x) ? (char)((int)x + (char.ToUpper(x) < 'N' ? 13 : -13)) : x).ToArray());
//}
}
Rot13("ROT13 example.");



//Kata f = new();
//Func<char> looper = f.MakeLooper("abc");

//Console.WriteLine(looper); // a
//Console.WriteLine(looper()); // b
//Console.WriteLine(looper()); // c
//Console.WriteLine(looper()); // a (loops back)



//public class Kata
//{
//    public static int currentIndex { get; set; } = 0;
//    public static char c { get; set; }
//    public static bool stopSignal { get; set; } = false;
//    public static int strLength { get; set; } = 0;
//    public static string input { get; set; }

//    public Func<char> MakeLooper(string str)
//    {
//        strLength = str.Length;
//        input = str;
//        c = str[currentIndex];
//        Console.WriteLine($"Current index: {currentIndex}");
//        return ReturnChar(c);
//    }

//    public static Func<char> ReturnChar(char c)
//    {
//        currentIndex++;
//        if (currentIndex == strLength)
//        {
//            currentIndex = 0;
//        }
//        c = input[currentIndex];
//        stopSignal = true;
//        Console.WriteLine($"Current index: {currentIndex}");
//        Console.WriteLine($"Current char: {c}");
//        return ReturnChar(c);
//    }
//}


