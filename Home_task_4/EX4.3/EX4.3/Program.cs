namespace EX4._3
{
    internal class Program
    {// відформатовано добре.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Enter path to file:");
            string path = Console.ReadLine();
            FileWorker fileWorker = new FileWorker(path);
            List<List<string>> list = fileWorker.readFromFile();

            if (list.Count > 0)
            {
                QuarterWorker quarterWorker = new QuarterWorker(list);
                Console.WriteLine($"Information about 3 flat in 1 quarter:\n{quarterWorker.FindFlat(1, 3)}\n");
                Console.WriteLine($"Maximum electricity dept in 1 quarter:\n{quarterWorker.GetSurnameWithMaxDept(1, 12)}\n");
                int flatNumber = quarterWorker.GetFlatNumberWithZero(1);
                string answer = flatNumber != -1 ? flatNumber.ToString() : "Wrong quater!";
                Console.WriteLine($"Flat which wasn't using electricity in first quarter: {answer}\n");
                var x = quarterWorker.GetPaymentSumForFlats(1);
                Console.WriteLine("Payment for flats in first quarter:");
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                var y = quarterWorker.GetAmountOfDaysToNow();
                Console.WriteLine("Days gone till now:");
                foreach (var item in y)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                x = quarterWorker.GetReport(1);
                Console.WriteLine("Report for first quarter:");
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
