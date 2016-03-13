using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            double money = (double.Parse(Console.ReadLine()))*1.94;
            string input = Console.ReadLine();
            //string[] inputArray = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int points = 0;
            int currentValue = 0;
            Dictionary<string, int> teams = new Dictionary<string, int>();
            teams.Add("Arsenal", currentValue);
            teams.Add("Chelsea", currentValue);
            teams.Add("Everton", currentValue);
            teams.Add("Liverpool", currentValue);
            teams.Add("Manchester City", currentValue);
            teams.Add("Manchester United", currentValue);
            teams.Add("Southampton", currentValue);
            teams.Add("Tottenham", currentValue);

            List<string> teamWins = new List<string>();
            
            int matchNumber = 0;
            
            

            while (input !="End of the league.")
            {
                string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (inputArray[1].Equals("1"))
                {
                    switch (inputArray[0])
                    {
                        case "Arsenal": teams["Arsenal"] += 3; break;
                        case "Chelsea": teams["Chelsea"] += 3; break;
                        case "Everton": teams["Everton"] += 3; break;
                        case "Liverpool": teams["Liverpool"] += 3; break;
                        case "ManchesterCity": teams["Manchester City"] += 3; break;
                        case "ManchesterUnited": teams["Manchester United"] += 3; break;
                        case "Southampton": teams["Southampton"] += 3; break;
                        case "Tottenham": teams["Tottenham"] += 3; break;

                        default:
                            break;
                    }
                        
                }
                if (inputArray[1].Equals("2"))
                {
                    switch (inputArray[2])
                    {
                        case "Arsenal": teams["Arsenal"] += 3; break;
                        case "Chelsea": teams["Chelsea"] += 3; break;
                        case "Everton": teams["Everton"] += 3; break;
                        case "Liverpool": teams["Liverpool"] += 3; break;
                        case "ManchesterCity": teams["Manchester City"] += 3; break;
                        case "ManchesterUnited": teams["Manchester United"] += 3; break;
                        case "Southampton": teams["Southampton"] += 3; break;
                        case "Tottenham": teams["Tottenham"] += 3; break;

                        default:
                            break;
                    }
                }
                if (inputArray[1].Equals("X"))
                {
                    switch (inputArray[2])
                    {
                        case "Arsenal": teams["Arsenal"] += 1; break;
                        case "Chelsea": teams["Chelsea"] += 1; break;
                        case "Everton": teams["Everton"] += 1; break;
                        case "Liverpool": teams["Liverpool"] += 1; break;
                        case "ManchesterCity": teams["Manchester City"] += 1; break;
                        case "ManchesterUnited": teams["Manchester United"] += 1; break;
                        case "Southampton": teams["Southampton"] += 1; break;
                        case "Tottenham": teams["Tottenham"] += 1; break;

                        default:
                            break;
                    }
                    switch (inputArray[0])
                    {
                        case "Arsenal": teams["Arsenal"] += 1; break;
                        case "Chelsea": teams["Chelsea"] += 1; break;
                        case "Everton": teams["Everton"] += 1; break;
                        case "Liverpool": teams["Liverpool"] += 1; break;
                        case "ManchesterCity": teams["Manchester City"] += 1; break;
                        case "ManchesterUnited": teams["Manchester United"] += 1; break;
                        case "Southampton": teams["Southampton"] += 1; break;
                        case "Tottenham": teams["Tottenham"] += 1; break;

                        default:
                            break;
                    }
                }

                matchNumber++;

                input = Console.ReadLine();
            }

            Console.WriteLine("{0:f2}lv.",(money*matchNumber));
            foreach (var pair in teams)
            {
                Console.WriteLine("{0} - {1} points.",
                pair.Key,
                pair.Value);
            }
        }
    }
}
