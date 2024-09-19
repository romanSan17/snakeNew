using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Score
    {
        public int score;

        public Score()
        {
            score = 0;
        }

        // Suurendab skoori
        public void AddPoint()
        {
            score++;
            Display();
        }

        // Vähendab skoori
        public void minusPoint()
        {
            score--;
            Display();
        }

        // Määrab konkreetse loendusväärtuse, конкретный счет
        public void overScore(int newScore)
        {
            score = newScore; 
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