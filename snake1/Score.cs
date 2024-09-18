using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Score
    {
        private int score;

        public Score()
        {
            score = 0;
        }


        public void AddPoint()
        {
            score++;
            Display();
        }

        public void Display()
        {
            Console.SetCursorPosition(0, 0); 
            Console.Write($"Score: {score}");
        }

        public int GetScore()
        {
            return score;
        }
    }
}