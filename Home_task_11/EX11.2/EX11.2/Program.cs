namespace EX11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateElements generateElements = new GenerateElements();
            generateElements.Generate();

            MergeSort ob = new MergeSort();

            ob.Sort100Array("startFile.txt");
        }
    }
}