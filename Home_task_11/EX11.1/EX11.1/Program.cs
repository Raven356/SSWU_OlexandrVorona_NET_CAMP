namespace EX11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestType[] testTypes = new TestType[5];
            testTypes[0] = new TestType(5);
            testTypes[1] = new TestType(1);
            testTypes[2] = new TestType(8);
            testTypes[3] = new TestType(5);
            testTypes[4] = new TestType(10);
            QuickSort<TestType> quickSort = new QuickSort<TestType>();
            quickSort.Sort(testTypes, 0, testTypes.Length - 1, 3);
            foreach (TestType testType in testTypes)
            {
                Console.WriteLine(testType.Element);
            }
        }
    }
}