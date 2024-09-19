﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            Players players = new Players(@"..\..\..\text.txt");

            Console.WriteLine("sinu nimi: ");
            string playerName = Console.ReadLine();

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*', ConsoleColor.Green);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '¤', '?');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score();
            score.Display();

            int speed = 100;
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food, score, ref speed)) 
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.Display();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            try
            {
                players.AddPlayer(playerName, score.GetScore());
            }
            catch (Exception)
            {
                Console.WriteLine("viga");
            }

            GameOverDisplay gameOverDisplay = new GameOverDisplay(players);
            gameOverDisplay.ShowGameOver();

            Console.ReadLine();
        }
    }
}
