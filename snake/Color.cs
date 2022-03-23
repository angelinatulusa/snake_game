using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Color
    {
        public string color;
        public Color()
        { }
        public void ColorOfWals()
        {
            Console.WriteLine("Для начала давай выберем цвет полей");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("синий");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("зеленый");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("желтый");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Какой хочешь?");
            color = Console.ReadLine();          
        }
        public void Coloor()
        {            
            if (color== "синий")
            {
                 Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == "зеленый")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "желтый")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}
