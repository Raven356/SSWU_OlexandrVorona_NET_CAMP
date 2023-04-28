namespace EX6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedArray array = new SortedArray();
            int[] answer = array.SortArrays(new int[] { 1, 10, 3 }, new int[] {4, 9, 7}).ToArray();
            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            answer = array.SortArrays2(new int[] { 1, 10, 3 }, new int[] { 4, 3, 9, 7 }).ToArray();
            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}