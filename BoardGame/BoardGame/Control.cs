using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class control
    {
        private Board game;
        private player p1, p2;

        public control()
        {
            p1 = new player("Vinh");
            p2 = new player("DepTrai");
            game = new Board(3, 5, 7);
        }
        public void PlayGame()
        {
            // logic di : print game -> p1 : pick -> check -> print -> p2 : pick -> check -> print (loop)
            while (true)
            {
                game.PrintGame();
                Console.WriteLine("{0} Turn",p1.GetName());
                p1.PickBalls(game);                
                if (game.GameOver())
                {
                    Console.WriteLine("{0} lose",p1.GetName());
                    Console.WriteLine("{0} win", p2.GetName());
                    break;
                }
                game.PrintGame();
                p2.PickBalls(game);
                if (game.GameOver())
                {
                    Console.WriteLine("{0} win",p1.GetName());
                    Console.WriteLine("{0} lose", p2.GetName());
                    break;                
                }
            }
        }
    }
}

