using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGame;

namespace Player
{
    public class PlayerChoose
    {
        private string name;
        public PlayerChoose(string user)
        {
            this.name = user;
        }
        public void PickBalls(Board game)
        {
            Console.Write("The Group u wanna choose");
            int group = Convert.ToInt32(Console.Read());
            Console.WriteLine();
            Console.Write("How many balls u wanna choose");
            int balls = Convert.ToInt32(Console.Read());
            game.PickBall(group, balls);
        }
    }
}
