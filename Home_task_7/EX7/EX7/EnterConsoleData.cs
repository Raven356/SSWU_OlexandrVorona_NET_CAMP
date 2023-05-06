using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    internal class EnterConsoleData : IEnterData
    {
        private ITextWorker _worker;

        public EnterConsoleData(ITextWorker worker)
        {
            _worker = worker;
        }
        public List<TrafficLight> EnterData()
        {
            List<TrafficLight> trafficLights = new List<TrafficLight>();
            while (true)
            {
                try
                {
                    _worker.PrintLine("Enter color of traffic lights in format: north: \"Color\"; east: \"Color\" without \" symbol\n" +
                        "Accepteble colors: red yellow green redyellow");

                    string answer = _worker.Read().ToString();

                    if (!answer.ToLower().Contains("north") || !answer.ToLower().Contains("east")
                        || !answer.ToLower().Contains("west") || !answer.ToLower().Contains("east"))
                    {
                        throw new ArgumentException("Entered data was wrong! Try again");
                    }

                    string[] lights = answer.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                    foreach (string light in lights)
                    {
                        string[] parts = light.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                        Color color;
                        switch (parts[1].ToLower())
                        {
                            case "red":
                                color = Color.Red;
                                break;
                            case "yellow":
                                color = Color.Green;
                                break;
                            case "redyellow":
                                color = Color.RedYellow; 
                                break;
                            case "green":
                                color = Color.Green;
                                break;
                            default:
                                throw new ArgumentException("Entered color was wrong!");
                        }
                        trafficLights.Add(new TrafficLight(color, parts[0]));
                    }
                    return trafficLights;
                }
                catch(Exception ex)
                {
                    _worker.PrintLine(ex.Message);
                }
            }

        }

        public int EnterTime(string text)
        {
            while(true) {
                try
                {
                    _worker.PrintLine($"Enter {text}:");
                    return int.Parse(_worker.Read().ToString()) * 1000;
                }
                catch (Exception ex)
                {
                    _worker.PrintLine(ex.Message);
                }
            }
        }
    }
}
