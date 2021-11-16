using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Player
    {
        string name = "";
        int score = 0;
        List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public Player(string nameThatWasPassedIn)
        {
            Console.WriteLine("Please Assign Player Name");
            name = nameThatWasPassedIn;
            Console.WriteLine(name);
        }

        public void Gestures()
        {
          
        }
    }
}
