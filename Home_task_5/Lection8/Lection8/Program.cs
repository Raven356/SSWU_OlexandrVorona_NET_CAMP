namespace Lection8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISet<int> set = new HashSet<int>() {1, 2, 3, 4, 2, 4, 4, 2, 2 };

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
            SortedSet<Test> set2 = new SortedSet<Test>(new TestComparer()) { new Test(12, "s"), new Test(13, "sa"), new Test(14, "sad")};

            foreach(Test test in set2)
            {
                Console.WriteLine(test);
            }

            List<Test> list = set2.ToList();

            foreach(var x in list)
            {
                Console.WriteLine(x);
            }

            var enumerator = list.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}