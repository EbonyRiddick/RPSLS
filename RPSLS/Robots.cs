using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Robots
    {
        public string name;
        public int health;


        public Robots(string nameThatWasPassedIn, int health)
        {
            name= nameThatWasPassedIn;
            this.health = health;
        }
    }
}
