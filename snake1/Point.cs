using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor Color { get; set; }


        public Point()
        {
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;  
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public Point(int _x, int _y, char _sym, ConsoleColor color)
        {
            x = _x;
            y = _y;
            sym = _sym;
            Color = color;
            Color = color;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            Color = p.Color;
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = Color;
            Console.Write(sym);
            Console.ResetColor();
        }
    }
}