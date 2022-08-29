using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq._1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
           List<string> namesOfGames = new List<string>()

             {"League of Legends", "Thief II",  "Call of Duty", "Minecraft",};

            namesOfGames.OrderBy(games => games.Length).ToList().ForEach(namesOfGames => Console.WriteLine(namesOfGames));

            }

        }
    }

