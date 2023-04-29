namespace EX6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniqueWordsFinder uniqueWordsFinder = new UniqueWordsFinder();
            List<string> words = uniqueWordsFinder.FindWithoutDuplicates("cat dog pig askadskj cat, leaf dog!").ToList();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
            words = uniqueWordsFinder.FindUnique("cat dog pig askadskj cat, leaf dog!").ToList();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}