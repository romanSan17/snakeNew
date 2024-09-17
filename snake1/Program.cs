using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Snake
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(); 
            score.Display();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.AddPoint();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Game Over");
            Console.WriteLine($"Final Score: {score.GetScore()}");
        }
    }
}

//HorizontalLine upline = new HorizontalLine(0, 78, 0, '%');
//HorizontalLine downline = new HorizontalLine(0, 78, 24, '%');
//VerticalLine leftLine = new VerticalLine(0, 24, 0, '%');
//VerticalLine rightLine = new VerticalLine(0, 24, 78, '%');

//upline.Draw();
//downline.Draw();
//leftLine.Draw();
//rightLine.Draw();

//Point p = new Point(4, 5, '*');
//Snake snake = new Snake(p, 4, Direction.RIGHT);
//snake.Draw();

//FoodCreator foodCreator = new FoodCreator(80, 25, '¤');
//Point food = foodCreator.CreateFood();
//food.Draw();

//while (true)
//{
//    if (snake.Eat(food))
//    {
//        food = foodCreator.CreateFood();
//        food.Draw();
//    }
//    else
//    {
//        snake.Move();
//    }

//    Thread.Sleep(100);

//    if (Console.KeyAvailable)
//    {
//        ConsoleKeyInfo key = Console.ReadKey();
//        snake.HandleKey(key.Key);
//    }
//}
