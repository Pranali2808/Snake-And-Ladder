using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Snake And Ladder Problem ");
            SnakeLadder snakeAndLadder = new SnakeLadder();
            snakeAndLadder.StartGame();
            Console.ReadLine();
        }
        
    }
}
