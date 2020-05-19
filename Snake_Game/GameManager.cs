using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Snake
{
    class GameManager
    {
        int width;
        int height;
        string new_game = "Начать игру";
        string option = "Настройки";
        string customisation = "Кастомизация";
        string exit = "Выход";
        static int shelf = 1;
        public string option_chosen;
        string name;
        public GameManager(int _width, int _height)
        {
            width = _width;
            height = _height;
        }
        public void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            MenuControl("");
        }
        public void MenuControl(string key)
        {
            Console.SetCursorPosition(32, 18);
            Console.WriteLine(new_game);
            Console.SetCursorPosition(32, 20);
            Console.WriteLine(option);
            Console.SetCursorPosition(32, 22);
            Console.WriteLine(customisation);
            Console.SetCursorPosition(32, 24);
            Console.WriteLine(exit);
            Console.BackgroundColor = ConsoleColor.Blue;

            if (key == "up")
            {
                if (shelf != 1)
                {
                    shelf--;
                }
            } else if (key == "down")
            {
                if (shelf != 5)
                {
                    shelf++;
                }
            }

            switch (shelf)
            {
                case 1:
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine(new_game);
                    option_chosen = "game";
                    break;
                case 2:
                    Console.SetCursorPosition(32, 20);
                    Console.WriteLine(option);
                    option_chosen = "options";
                    break;
                case 3:
                    Console.SetCursorPosition(32, 22);
                    Console.WriteLine(customisation);
                    option_chosen = "custom";
                    break;
                case 4:
                    Console.SetCursorPosition(32, 24);
                    Console.WriteLine(exit);
                    option_chosen = "exit";
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Name_asker()
        {
            Console.Clear();

            Console.WriteLine("Напишите ваше имя: ");

            try
            {
                name = Console.ReadLine();

                Console.WriteLine("Вы ввели: " + name);

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Введите правильно!");
            }
        }

        public void Name_writter(int score)
        {
            Console.Clear();
            StreamWriter to_file = new StreamWriter("Результаты.txt", true);
            to_file.WriteLine(name + " - " + score);
            to_file.Close();
        }

        public void GameOver()
        {
            Sound sound = new Sound();
            sound.Play(@"C:\Users\Yarik\source\repos\Snake-master\Snake_Game\lose.wav");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(38, 16);
            Console.WriteLine("Игра окончена");
            Thread.Sleep(1000);
        }
    }
}
