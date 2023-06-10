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
            for(int i = 0; i < 50; i++)
            {
                arr[i] = int.Parse(streamReader.ReadLine());
            }
            ob.Sort(arr, 0, arr.Length - 1);

            StreamWriter streamWriter = new StreamWriter("firstPartResult.txt");
            for(int i = 0; i < arr.Length; i++)
            {
                streamWriter.WriteLine(arr[i]);
            }

            streamWriter.Dispose();

            for(int i = 0; i < 50; i++)
            {
                arr[i] = int.Parse(streamReader.ReadLine()); ;
            }
            ob.Sort(arr, 0, arr.Length - 1);

            streamWriter = new StreamWriter("secondPartResult.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                streamWriter.WriteLine(arr[i]);
            }
            streamWriter.Dispose();

            streamReader.Dispose();
            ob.CreateResultFile(50, 50, "firstPartResult.txt", "secondPartResult.txt", "startFile.txt");
        }
    }
}