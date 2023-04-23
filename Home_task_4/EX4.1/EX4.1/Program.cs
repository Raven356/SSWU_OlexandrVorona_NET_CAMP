namespace EX4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextSpliter spliter = new TextSpliter();
            List<string> text = spliter.SplitText("djksdjfhjakshjkadasdsad.\nasdaalsjdasa ask(ldjs)a dsakld\n" +
                "lsadas! asda lasdlassda\n? kasokdl [asdkasd wlelq;we] lq\nkasdkasdk!\nasdas asdasd ( askdaskd ) asdasld!\nkasdasdlas \nsakasd {sadlasld} lasda?");
            StatementFinder statementFinder = new StatementFinder();
            // ви задачу об'єднання кусків винесли на клієнта, а це не добре.
            var result = statementFinder.FindStatements(text);
            foreach (var x in result)
            {
                foreach (var y in x)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }
    }
}
