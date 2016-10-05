using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snakee
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter=0;
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80, 25);
            Wall wall = new Wall(80, 25);
            wall.Draw();
            Point p = new Point(8, 8, '+');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            FoodCreator FoodCreate = new FoodCreator(78,24,'O');
            Point food = FoodCreate.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (wall.IsHit(snake)||snake.IsTailHit())
                {
                    Mess(counter);
                    break;
                }
                if (snake.Eat(food))
                {
                    counter++;
                    food = FoodCreate.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);
                }
            }
            Console.ReadLine();
         }
        static void Mess(int con)
        {
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("Game Over");
            Console.SetCursorPosition(33, 11);
            Console.WriteLine("Your score:" + con);
        }
    }

}
