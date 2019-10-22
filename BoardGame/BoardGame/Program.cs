using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Board
    {
        private int g1, g2, g3;
        public Board(int a , int b, int c)
        {
           this.g1 = a;
           this.g2 = b;
           this.g3 = c;
        }
        public void PickBall(int g, int balls)
        {
          
            if (g == 1)
            {
                g1 -= balls;
            }
            else if (g == 2)
            {
                g2 -= balls;
            }
            else if (g == 3)
            {
                g3 -= balls;
            }
        }
        public void PrintGame()
        {
            Console.Write("Group 1 : ");
            for (int i = 0; i < g1; i++)
            {
                Console.Write(" O ");
            }
            Console.WriteLine();
            Console.Write("Group 2 : ");
            for (int i = 0; i < g2; i++)
            {
                Console.Write(" O ");
            }
            Console.WriteLine();
            Console.Write("Group 3 : ");
            for (int i = 0; i < g3; i++)
            {
                Console.Write(" O ");
            }
            Console.WriteLine();
        }
        public bool GameOver()
        {
            if (g1 == 0 && g2 == 0 && g3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
