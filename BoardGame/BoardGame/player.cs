using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class player
    {
        private string name;
        public player(string user)
        {
            this.name = user;
        }
        public void PickBalls(Board game)
        {
            Console.Write("The Group u wanna choose");
            int group = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How many balls u wanna choose");
            int balls = Convert.ToInt32(Console.ReadLine());
            game.PickBall(group, balls);
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
