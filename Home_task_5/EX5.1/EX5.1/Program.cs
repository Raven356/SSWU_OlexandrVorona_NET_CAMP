using System.Drawing;
//Olexandr	Vorona		90	10	15	95	95	98	75	103,1. Вітаю Вас в 2 турі.
{
    internal class Program
    {// Виясніть для себе переваги і недоліки цього алгоритму порівняно з іншими. Алгоритм реалізовано добре.
        static void Main(string[] args)
        {
            FenceCounter fenceCounter = new FenceCounter(new List<Point>() { new Point(3, 4), new Point(4, 3), new Point(3, 2), new Point(4, 1)});
            FenceCounter fenceCounter1 = new FenceCounter(new List<Point>() { new Point(3, 5), new Point(6, 2), new Point(8, 2), new Point(4, 9), new Point(3, 7), new Point(0, 0), new Point(0, 10) });
            FenceCounter fenceCounter2 = new FenceCounter(new List<Point>() { new Point(0, 0), new Point(0, 1) });
            Console.WriteLine(fenceCounter.FindShortestFence());
            Console.WriteLine(fenceCounter1.FindShortestFence());
            Console.WriteLine(fenceCounter2.FindShortestFence());
            Console.WriteLine(fenceCounter > fenceCounter1);
            Console.WriteLine(fenceCounter < fenceCounter1);
            Console.WriteLine(fenceCounter.FindSquare());
            Console.WriteLine(fenceCounter1.FindSquare());
            Console.WriteLine(fenceCounter2.FindSquare());
        }
    }
}
