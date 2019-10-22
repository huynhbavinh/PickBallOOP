using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGame;
using Player;



namespace Controller
{
    public class control
    {
        private Board game;
        private PlayerChoose p1, p2;

        public void PlayGame()
        {
            // logic di : print game -> p1 : pick -> check -> print -> p2 : pick -> check -> print (loop)
            game.PrintGame();
            p1.PickBalls(game);
            //check ?
            game.PrintGame();
            p2.PickBalls(game);
            //check ?
            game.PrintGame();
        }
    }
}
