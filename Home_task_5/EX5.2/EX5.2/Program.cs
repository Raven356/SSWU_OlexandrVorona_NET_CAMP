namespace EX5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperMarketGenerator superMarketGenerator = new SuperMarketGenerator();
            SuperMarket superMarket = superMarketGenerator.Generate();
            List<string> goodsNames = superMarketGenerator.GoodsNames;
            Wrapper wrapper = new Wrapper();
            wrapper.Wrap(superMarket);
            Console.WriteLine("Goods names:");
            foreach (var x in goodsNames)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Enter goods which you want to find:");
            string answer = Console.ReadLine();
            PathFinder pathFinder = new PathFinder();
            Console.WriteLine(pathFinder.FindPath(wrapper.Box, answer, wrapper.Box.Size));
            Console.WriteLine();
        }
    }
}