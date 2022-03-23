﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8; //чтобы программа принимала русские буквы
			/*Color color = new Color();
			color.ColorOfWals();
			Console.Clear();*/

			Score score = new Score();//переменная со счетом
			Score speed = new Score();//переменная со скоростью

			GameOver over = new GameOver();

			Console.SetBufferSize(250, 80);//установки размера окна

			Walls walls = new Walls(80, 25);
			//смена цвета у полей(не работает)
			Console.ForegroundColor = ConsoleColor.Blue;//меняем цвет рамочки на синий
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*');//создание точки
			Snake snake = new Snake(p, 4, Direction.RIGHT);//создание змейки из 4 точек и направление, куда змейка повернута
			Console.ForegroundColor = ConsoleColor.Green;//меняем цвет хмейки (и еды) на зелений
			snake.Draw();

			//создание еды
			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();
			
			while (true)
			{
				
				if (walls.IsHit(snake) || snake.IsHitTail())//конец игры в случае, если змейка коснулась своего тела или поля
				{
					Console.Clear();
					over.End();
					score.WriteScore();
					break;
				}
				if (snake.Eat(food))//если змейка "съела" еду, то появляется новая еда и змейка становится длинее 
				{
					score.ScoreUp();
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}
				Thread.Sleep(100);//скорость перемещения
				int a = 50;
				while (score == speed)
				{

					Thread.Sleep(100 + a);//увеличение скорости
					a += 50;
					speed.Speed();
				}
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			
			Console.ReadLine();
		}

	}
}
