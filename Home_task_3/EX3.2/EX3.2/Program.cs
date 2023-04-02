namespace EX3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.StartMenu();
            Console.WriteLine(menu.Answer is null ? "null" : menu.Answer);
        }
    }
}