namespace Ex10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.AddCard("# American Express # card_number = \"378282246310005\"");
            Controller.AddCard("# MasterCard # card_number = \"5555555555554444\"");
            Controller.AddCard("# Visa # card_number = \"4111111111111111\"");
            Controller.AddCard("# Visa # card_number = \"4128954009213630\"");
            Controller.AddCard("# Visa # card_number = \"5128954009213\"");
            Controller.CheckCardsNumbers();
            foreach(var result in Controller.Results)
            {
                Console.WriteLine(result);
            }
        }
    }
}