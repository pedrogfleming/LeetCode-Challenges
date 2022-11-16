namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Solution().solution([2, 5, 2, 7, 4]);
        }
    }
    class Solution
    {
        public int solution(int[] A)
        {
            HashSet<int> ints = new ();
            for (int i = 0; i < A.Length; i++)
            {
                int result = Math.Abs(A[i] - A[i+1]);
                ints.Add(result);
            }
            return ints.Count;
        }
    }
}