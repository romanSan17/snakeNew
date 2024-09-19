using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char foodSym; 
        private char speedFoodSym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char foodSym, char speedFoodSym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.foodSym = foodSym; 
            this.speedFoodSym = speedFoodSym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            char sym = foodSym;
            ConsoleColor color = ConsoleColor.DarkYellow;

            if (random.Next(0, 10) > 7) 
            {
                sym = speedFoodSym;
                color = ConsoleColor.Red;
            }

            return new Point(x, y, sym, color);
        }
    }
}