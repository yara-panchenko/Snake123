    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Custom
    {
        public string color = "Цвет змейки";
        public string shape = "Символы змейки";

        public int shelf = 1;

        public string option_chosen;

        public int color_order = 1;
        public int shape_order = 1;

        public char char_ = '+';

        public void CustomControl(string key)
        {
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("Цвет змейки");
            switch (color_order)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(38, 12);
                    Console.WriteLine("Зеленый");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(38, 12);
                    Console.WriteLine("Красный");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(38, 12);
                    Console.WriteLine("Синий");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(35, 16);
            Console.WriteLine("Символы змeйки");
            switch (shape_order)
            {
                case 1:
                    Console.SetCursorPosition(38, 18);
                    Console.WriteLine("++++");
                    char_ = '+';
                    break;
                case 2:
                    Console.SetCursorPosition(38, 18);
                    Console.WriteLine("****");
                    char_ = '*';
                    break;
                case 3:
                    Console.SetCursorPosition(38, 18);
                    Console.WriteLine("@@@@");
                    char_ = '@';
                    break;
            }
            Console.SetCursorPosition(38, 20);
            Console.WriteLine("Выход");


            Console.BackgroundColor = ConsoleColor.Red;
            if (key == "up")
            {
                if (shelf != 1)
                {
                    shelf--;
                }
            }
            else if (key == "down")
            {
                if (shelf != 3)
                {
                    shelf++;
                }
            }

            switch (shelf)
            {
                case 1:
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("Цвет змейки");
                    option_chosen = "color";
                    break;
                case 2:
                    Console.SetCursorPosition(35, 16);
                    Console.WriteLine("Символы змейки");
                    option_chosen = "shape";
                    break;
                case 3:
                    Console.SetCursorPosition(38, 20);
                    Console.WriteLine("Выход");
                    option_chosen = "exit";
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
