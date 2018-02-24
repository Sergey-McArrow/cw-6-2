using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int curX = Console.WindowWidth / 2;
            int curY = Console.WindowHeight / 2;
            Console.SetCursorPosition(curX, curY);

            while (true) 
            {
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(curX, curY-=1);
                }
                else if (consoleKey.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(curX, curY+=1);
                }
                else if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(curX+=1, curY);
                }
                else if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(curX-=1, curY);
                }
                Console.WriteLine('*');
            }
        }
    }
}
