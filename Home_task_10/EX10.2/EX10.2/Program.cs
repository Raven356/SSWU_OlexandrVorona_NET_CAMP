namespace EX10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoodsVisitor visitor = new GoodsVisitor();
            List<Goods> goods = new List<Goods>
            {
                new Product("Tomato", 12, 5, new DateTime(2023, 6, 5)),
                new Product("Tomato2", 16, 3, new DateTime(2023, 6, 15)),
                new Cloths("T-shirt", 20, 12),
                new Electronics("Usb", 20, 12),
                new Electronics("Usb2", 30, 20)
            };

            foreach(Goods good in goods)
            {
                good.Accept(visitor);
                Console.WriteLine(good);
            }
        }
    }
}