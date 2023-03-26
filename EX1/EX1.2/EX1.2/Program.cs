namespace EX1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            LongestColor longestColor = new LongestColor(random.Next(3, 8), random.Next(3,8));
            longestColor.GenerateArray();
            Console.WriteLine(longestColor.FindLongest());
        }
    }
}