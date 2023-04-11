namespace EX3._2
{
    internal class Program
    {// користувач бере воду з вежі. Він використовує її. А це означає, що має біти стрілка...
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.StartMenu();
            Console.WriteLine(menu.Answer is null ? "null" : menu.Answer);
        }
    }
}
