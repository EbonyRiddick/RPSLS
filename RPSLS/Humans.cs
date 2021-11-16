using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Humans
    {
        public string name;
        public int health;


        public Humans(string nameThatWasPassedIn, int health)
        {
            name = nameThatWasPassedIn;
            this.health = health;
        }

        public Gestures(int[] number, string gesture)
        {

        }
    }
}
