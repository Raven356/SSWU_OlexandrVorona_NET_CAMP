namespace EX4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileWorker fileWorker = new FileWorker();
            List<List<string>> list = fileWorker.readFromFile("text.txt");

            if (list.Count > 0)
            {
                QuarterWorker quarterWorker = new QuarterWorker(list);
                Console.WriteLine(quarterWorker.FindFlat(1, 3));
                Console.WriteLine(quarterWorker.GetSurnameWithMaxDept(1, 12));
                Console.WriteLine(quarterWorker.GetFlatNumberWithZero(1));
                var x = quarterWorker.GetPaymentSumForFlats(1);
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
                var y = quarterWorker.GetAmountOfDaysToNow();
                foreach (var item in y)
                {
                    Console.WriteLine(item);
                }
                x = quarterWorker.GetReport(1);
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}