namespace EX7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleTextWorker worker = new ConsoleTextWorker();
            EnterConsoleData enterConsoleData = new EnterConsoleData(worker);
            Crossroad crossroad = new Crossroad(enterConsoleData.EnterTime("timelapse(s)"), enterConsoleData.EnterTime("end time(s)")
                , new PrintAnswer(), enterConsoleData.EnterData(), worker);
            while (crossroad.IsTimerEnabled)
            {
                
            }

        }
    }
}