using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class GameOver
    {
        static void WriteGameOver(string text)
        {
            int a=12;
            Console.SetCursorPosition(17, a);
            Console.WriteLine(text);
        }
        public void End()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.SetCursorPosition(20, 12);
            WriteGameOver("OHH... SINU USS OLI SURNUD!!! proovi veel kord");

        }
    }
}
