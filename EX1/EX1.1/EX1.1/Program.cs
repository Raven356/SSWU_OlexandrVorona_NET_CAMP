namespace EX1._1
{
    internal class Program
    {// Вітаю Вас.
        static void Main(string[] args)
        {
           while (true)
            {
                try
                {
                    Console.WriteLine("Enter dimensions of matrix(reverse works for nXn):");
                    string dimensions = Console.ReadLine();
                    string[] splited = dimensions.Split(" ");
                    SnakeArray snakeArray = new SnakeArray(int.Parse(splited[0]), int.Parse(splited[1]));
                    snakeArray.FillArray();
                    snakeArray.Print();
                    string answer = "";
                    while (answer != "y" || answer != "n")
                    {
                        Console.WriteLine("Do You want to see reverse? y/n");
                        answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            snakeArray.FillReverseArray();
                            snakeArray.Print();
                            break;
                        }
                        else if (answer == "n")
                            break;
                        Console.WriteLine("Try again!\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                break;
            }

        }
    }
}
