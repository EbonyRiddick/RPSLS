using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {

        
        public void Run()
        {
            string welcome = "Welcome To RPSLS";
            Console.WriteLine(welcome);

            
        }

        string[] gestures = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        List<string> gesturesRange = new List<string>(gestures);

        public Game(string[] gestures, List<string> gesturesRange)
        {
            this.gestures = gestures;
            this.gesturesRange = gesturesRange;
        }
    }
}
