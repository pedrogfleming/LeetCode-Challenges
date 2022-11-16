using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Solution
    {
        public int solutionRegxFail(string S)
        {
            string charsToRemove = "BANANA";
            string filtered = S;
            int moves = 0;

            bool any = false;
            foreach (char c in charsToRemove)
            {
                if (!c.Contains(S))
                {
                    any = false;
                    break;
                }

            }

            while(charsToRemove.All(c => S.Contains(charsToRemove)))
            {
                filtered = S.FilterRegex(charsToRemove.ToCharArray().ToList());
                moves++;
            }
            return moves;
        }
        public int solutionRegxFail(string S)
        {
            List<char> charsToRemove = new List<char>() { 'B', 'A', 'N', 'A', 'N', 'A' };            
            string prevFilter;
            string filter2;
            do
            {
                prevFilter = S.FilterRegex(charsToRemove);
                filter2 = prevFilter;
            }
            while (prevFilter != filter2);
        }
        public int solutionFail(string S)
        {
            List<char> charsToRemove = new List<char>() { 'B', 'A', 'N', 'A', 'N', 'A' };
            string prevFilter;
            string filter2;
            do
            {
                prevFilter = S.Filter(charsToRemove);
                filter2 = prevFilter;
            }
            while (prevFilter != filter2);
        }       

    }
    public static class Extension
    {
        public static string Filter(this string str, List<char> charsToRemove)
        {
            charsToRemove.ForEach(c =>
            {
                str = str.Replace(c.ToString(), String.Empty);
            });
            return str;
        }

        public static string FilterRegex(this string str, List<char> charsToRemove)
        {
            String chars = "[" + String.Concat(charsToRemove) + "]";
            return Regex.Replace(str, chars, String.Empty);
        }
    }
}