namespace EX1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter size of cube:");
                    int size = int.Parse(Console.ReadLine());
                    Cube cube = new Cube(size);
                    bool contains = cube.CheckForHole();
                    string endStatement = contains ? $"Start cords: {cube.StartCords}\nEnd cords: {cube.EndCord}"
                        : "No coords because of lack of holes";
                    Console.WriteLine($"Contains a hole: {contains}\n" + endStatement);
                    Console.WriteLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}