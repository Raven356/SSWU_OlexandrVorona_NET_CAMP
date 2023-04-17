using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class SuperMarketGenerator
    {
        private List<string> _goodsNames = new List<string>();
        public List<string> GoodsNames { get { return _goodsNames; } }
        public SuperMarket Generate()
        {
            Random rnd = new Random();
            SuperMarket superMarket = new SuperMarket(GenerateDivisions(rnd.Next(1, 10)), "supermarket_" + (rnd.Next(1, 1000) + rnd.Next(1, 1000)));
            return superMarket;
        }

        private List<Division> GenerateDivisions(int amount, int count = 0)
        {
            List<Division> result = new List<Division>();
            Random rand = new Random();
            for(int i = 0; i < amount; i++)
            {
                int choice = rand.Next(1, 3);
                Division division = new Division();
                if(choice == 1 && count <= 10)
                {
                    division = new Division(GenerateDivisions(rand.Next(1, 5), count + 1), "division_" + (rand.Next(1, 100) + rand.Next(1, 100)));
                }
                else if(choice == 2 || count > 10)
                {
                    division = new Division(GenerateGoods(rand.Next(1, 5)), "division_" + (rand.Next(1, 100) + rand.Next(1, 100)));
                }
                result.Add(division);
            }
            return result;
        }

        private List<Goods> GenerateGoods(int amount)
        {
            List <Goods> result = new List<Goods>();
            Random rand = new Random();
            for(int i = 0; i < amount; i++)
            {
                Goods goods = new Goods(rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 10), "goods_" + (rand.Next(1, 1000) + rand.Next(1, 1000)));
                _goodsNames.Add(goods.Name);
                result.Add(goods);
            }
            return result;
        }
    }
}
