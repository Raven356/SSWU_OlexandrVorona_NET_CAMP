namespace EX1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter dimension of tensor and size of that dimensions:");
                    string data = Console.ReadLine();
                    Console.WriteLine();
                    string[] splitData = data.Split(" ");
                    int dimension = int.Parse(splitData[0]);
                    int[] dataArr = new int[splitData.Length - 1];
                    for (int i = 1; i < splitData.Length; i++)
                    {
                        dataArr[i - 1] = int.Parse(splitData[i]);
                    }
                    Tensor tensor = new Tensor();
                    tensor.InitTensor(dimension, dataArr);
                    tensor.FillTensor(0, new List<int>());
                    tensor.PrintTensor(0, new List<int>());
                    Console.WriteLine();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
        }
    }
}