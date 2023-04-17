using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Menu
    {
        public void StartMenu()
        {
            Console.WriteLine("Do you want to enter number of subdivisions? y/n");
            SuperMarketGenerator superMarketGenerator = new SuperMarketGenerator();
            SuperMarket superMarket;
            int number = 11;
            bool userInserted = false;
            string answer = "";
            do
            {
                try
                {
                    answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "y":
                            Console.WriteLine("Enter number of subdimensions:");
                            number = int.Parse(Console.ReadLine());
                            userInserted = true;
                            break;
                        case "n":
                            break;
                        default:
                            Console.WriteLine("Try again:");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }while (!answer.Equals("y") && !answer.Equals("n"));
            superMarket = superMarketGenerator.Generate(number - 1, userInserted);
            List<string> goodsNames = superMarketGenerator.GoodsNames;
            Wrapper wrapper = new Wrapper();
            wrapper.Wrap(superMarket);
            Console.WriteLine("Goods names:");
            foreach (var x in goodsNames)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Enter goods which you want to find:");
            answer = Console.ReadLine();
            PathFinder pathFinder = new PathFinder();
            string path = pathFinder.FindPath(wrapper.Box, answer);
            if (path != null)
                Console.WriteLine("\n" + path);
            else
                Console.WriteLine("\nGoods not found!");
        }
    }
}
