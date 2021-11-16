using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        bool gameOver = false;
        
        public void Run()
        {
            string welcome = "Welcome To RPSLS";
            Console.WriteLine(welcome);

            Console.WriteLine("Please Choose Number Of Players");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            
            
        }



        

         
    }
}
