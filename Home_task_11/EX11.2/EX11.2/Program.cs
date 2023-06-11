namespace EX11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateElements generateElements = new GenerateElements();
            generateElements.Generate();

            MergeSort ob = new MergeSort();

            using StreamReader streamReader = new StreamReader("startFile.txt");

            int[] arr = new int[50];

            FileWorker.ReadPartFromFile(streamReader, arr);

            ob.Sort(arr, 0, arr.Length - 1);

            FileWorker.WritePartInFile("firstPartResult.txt", arr);

            FileWorker.ReadPartFromFile(streamReader, arr);

            ob.Sort(arr, 0, arr.Length - 1);

            FileWorker.WritePartInFile("secondPartResult.txt", arr);

            streamReader.Dispose();

            ob.CreateResultFile(50, 50, "firstPartResult.txt", "secondPartResult.txt", "startFile.txt");
        }
    }
}