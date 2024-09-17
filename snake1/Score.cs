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

        // Увеличиваем счет при поедании еды
        public void AddPoint()
        {
            score++;
            Display();
        }

        // Вывод текущего счета на экран
        public void Display()
        {
            Console.SetCursorPosition(0, 0);  // Устанавливаем курсор в верхнем левом углу
            Console.Write($"Score: {score}");
        }

        // Получение текущего значения счета
        public int GetScore()
        {
            return score;
        }
    }
}