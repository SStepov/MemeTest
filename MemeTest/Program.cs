using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MemeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменные:
            bool isOpen = true;
            string command;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Это меме-тест, в нем нет никакого смысла :)\n");

            while (isOpen)
            {
                WhiteColor();
                Console.WriteLine("Вы сейчас находитесь в меню!");
                MenuColor();
                Console.WriteLine("╔ Выберите действие:");
                Console.Write("╠ 1 - ");
                WhiteColor();
                Console.WriteLine("Начать тест");
                MenuColor();
                Console.Write("╠ 2 - ");
                WhiteColor();
                Console.WriteLine("Информация");
                MenuColor();
                Console.Write("╠ 3 - ");
                WhiteColor();
                Console.WriteLine("Выйти из игры");
                MenuColor();
                Console.Write("╚ Ваша цифра: ");
                Console.ForegroundColor = ConsoleColor.Red;

                command = Console.ReadLine();
                
                switch(command)
                {
                    case "1":
                        {
                            Game();
                        }
                        break;
                    case "2":
                        {
                            Information();
                        }
                        break;
                    case "3":
                        {
                            Exit();
                        }
                        break;
                    default:
                        
                        Error();

                        break;
                }    
            }
        }
        static void Game()
        {
            int score = 0;
            string answer;
            bool isOpen = true;
            bool isOpenLevel = true;
            bool isOpenResult = true;

            while (isOpen)
            {
                Console.Clear();
                MenuColor();
                Console.WriteLine("Вы находитесь в самой игре!");
                while (isOpenLevel)
                {
                    MenuColor();
                    Console.Write("Первый вопрос: ");
                    WhiteColor();
                    Console.WriteLine("Кто проживает на дне океана?");
                    MenuColor();
                    Console.WriteLine("╔ Варианты ответов:");
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Губка Боб");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Никто");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Рыбы");
                    MenuColor();
                    Console.Write("╚ Ваш ответ: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = Console.ReadLine().ToLower();

                    switch (answer)
                    {
                        case "губка боб":

                            score = Correctly(answer, score, ref isOpenLevel);

                            break;

                        case "никто":

                            isOpenLevel = NoCorrecly("губка боб", isOpenLevel);

                            break;

                        case "песок":

                            isOpenLevel = NoCorrecly("губка боб", isOpenLevel);

                            break;

                        default:

                            Error();

                            break;
                    }
                } // 1 лвл
                isOpenLevel = true;
                while (isOpenLevel)
                {
                    Console.Clear();
                    MenuColor();
                    Console.Write("Второй вопрос: ");
                    WhiteColor();
                    Console.WriteLine("Какого цвета зеркало?");
                    MenuColor();
                    Console.WriteLine("╔ Варианты ответов:");
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Прозрачного");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Зеркального");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Белого");
                    MenuColor();
                    Console.Write("╚ Ваш ответ: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = Console.ReadLine().ToLower();

                    switch (answer)
                    {
                        case "зеркального":

                            score = Correctly(answer, score, ref isOpenLevel);

                            break;

                        case "белого":

                            isOpenLevel = NoCorrecly("зеркального", isOpenLevel);

                            break;

                        case "прозрачного":

                            isOpenLevel = NoCorrecly("зеркального", isOpenLevel);

                            break;

                        default:

                            Error();

                            break;
                    }
                } // 2 лвл
                isOpenLevel = true;
                while (isOpenLevel)
                {
                    Console.Clear();
                    MenuColor();
                    Console.Write("Третий вопрос: ");
                    WhiteColor();
                    Console.WriteLine("Что тяжелее: 1 кг железа или 1 кг ваты?");
                    MenuColor();
                    Console.WriteLine("╔ Варианты ответов:");
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Железо");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Они равны");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Вата");
                    MenuColor();
                    Console.Write("╚ Ваш ответ: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = Console.ReadLine().ToLower();

                    switch (answer)
                    {
                        case "они равны":

                            score = Correctly(answer, score, ref isOpenLevel);

                            break;

                        case "железо":

                            isOpenLevel = NoCorrecly("они равны", isOpenLevel);

                            break;

                        case "вата":

                            isOpenLevel = NoCorrecly("они равны", isOpenLevel);

                            break;

                        default:

                            Error();

                            break;
                    }
                } // 3 лвл
                isOpenLevel = true;
                while (isOpenLevel)
                {
                    Console.Clear();
                    MenuColor();
                    Console.Write("Четвертый вопрос: ");
                    WhiteColor();
                    Console.WriteLine("Почему снег белый?");
                    MenuColor();
                    Console.WriteLine("╔ Варианты ответов:");
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Потому что зима");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Дед мороз захотел");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Потому что");
                    MenuColor();
                    Console.Write("╚ Ваш ответ: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = Console.ReadLine().ToLower();

                    switch (answer)
                    {
                        case "дед мороз захотел":

                            score = Correctly(answer, score, ref isOpenLevel);

                            break;

                        case "потому что зима":

                            isOpenLevel = NoCorrecly("дед мороз захотел", isOpenLevel);

                            break;

                        case "потому что":

                            isOpenLevel = NoCorrecly("дед мороз захотел", isOpenLevel);

                            break;

                        default:

                            Error();

                            break;
                    }
                } // 4 лвл
                isOpenLevel = true;
                while (isOpenLevel)
                {
                    Console.Clear();
                    MenuColor();
                    Console.Write("Пятый вопрос: ");
                    WhiteColor();
                    Console.WriteLine("Почему пчела летает?");
                    MenuColor();
                    Console.WriteLine("╔ Варианты ответов:");
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Физика позволила");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Крылья есть");
                    MenuColor();
                    Console.Write("╠ ");
                    WhiteColor();
                    Console.WriteLine("Летать умеет");
                    MenuColor();
                    Console.Write("╚ Ваш ответ: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = Console.ReadLine().ToLower();

                    switch (answer)
                    {
                        case "летать умеет":

                            score = Correctly(answer, score, ref isOpenLevel);

                            break;

                        case "крылья есть":

                            isOpenLevel = NoCorrecly("летать умеет", isOpenLevel);

                            break;

                        case "физика позволила":

                            isOpenLevel = NoCorrecly("летать умеет", isOpenLevel);

                            break;

                        default:

                            Error();

                            break;
                    }
                } // 5 лвл

                isOpenLevel = false;
                while (isOpenResult)
                {
                    MenuColor();
                    Console.Clear();
                    Console.WriteLine("Готовы узнать результат?");
                    Console.Write("Ваш ответ: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "да":

                            Result(score);

                            break;

                        case "нет":

                            Exit();

                            break;

                        default:

                            Error();

                            break;
                    }
                }
            }
        }
        // Новые классы
        static void Exit()
        {
            Console.Clear();
            MenuColor();
            Console.WriteLine("Рады были вас видеть!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Разработчик SStepov");
            MenuColor();
            Console.WriteLine(", очень для вас старался!\n" +
                              "Надеюсь вы к нам вернетесь!");
            Console.ResetColor();
            Environment.Exit(0);
            WhiteColor();
        }
        static void Result(int score)
        {
            if (score <= 2)
            {
                MenuColor();
                Console.Write("[Поздравляем!] ");
                WhiteColor();
                Console.WriteLine($"Вы набрали целых - {score}, ВЫ ОЧЕНЬ СЛАБЫ!!!");

                MenuColor();
                Console.Write("[Информация] ");
                WhiteColor();
                Console.WriteLine("Нажмите любую клавишу для выхода из приложения.");
                Console.ReadKey();
                Exit();

            }
            else if (score <= 4)
            {
                MenuColor();
                Console.Write("[Поздравляем!] ");
                WhiteColor();
                Console.WriteLine($"Вы набрали целых - {score}, ВЫ НЕ СИЛЬНЫ!!!");

                MenuColor();
                Console.Write("[Информация] ");
                WhiteColor();
                Console.WriteLine("Нажмите любую клавишу для выхода из приложения.");
                Console.ReadKey();
                Exit();
            }
            else if (score == 5)
            {
                MenuColor();
                Console.Write("[Поздравляем!] ");
                WhiteColor();
                Console.WriteLine($"Вы набрали целых - {score}, ВЫ МАШИНА!!!");

                MenuColor();
                Console.Write("[Информация] ");
                WhiteColor();
                Console.WriteLine("Нажмите любую клавишу для выхода из приложения.");
                Console.ReadKey();
                Exit();
            }
        }
        static int Correctly(string answer, int score, ref bool isOpenLevel)
        {
            Console.Clear();
            MenuColor();
            Console.Write("[Поздравляем!] ");
            WhiteColor();
            Console.WriteLine($"Вы правильно отгадали, это было - {answer}\n" +
                $"Нажмите любую клавишу для продолжения!");
            Console.ReadKey();
            isOpenLevel = false;
            return score += 1;
        }
        static bool NoCorrecly(string answer, bool isOpenLevel)
        {
            Console.Clear();
            MenuColor();
            Console.Write("[Увы...] ");
            WhiteColor();
            Console.WriteLine($"Вы не правильно отгадали, это было - {answer}");
            Console.ReadKey();
            return isOpenLevel = false;
        }
        static void Information()
        {
            Console.Clear();
            MenuColor();
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║          ИНФОРМАЦИЯ О ТЕСТЕ             ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ResetColor();

            WhiteColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nО ТЕСТЕ:");
            WhiteColor();
            Console.WriteLine("MemeTest - это веселый тест с несерьезными вопросами");
            Console.WriteLine("и забавными вариантами ответов. Особенности:");
            Console.WriteLine("- 5 уровней с мемными вопросами");
            Console.WriteLine("- Неочевидные, но логичные ответы");
            Console.WriteLine("- Юмористическая подача");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПРАВИЛА ТЕСТА:");
            WhiteColor();
            Console.WriteLine("1. Вам будет предложено 5 вопросов");
            Console.WriteLine("2. К каждому вопросу даны 3 варианта ответа");
            Console.WriteLine("3. Выбирайте ответ, вводя его с клавиатуры");
            Console.WriteLine("4. За каждый правильный ответ вы получаете 1 очко");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nУПРАВЛЕНИЕ:");
            WhiteColor();
            Console.WriteLine("- Все команды вводятся с клавиатуры");
            Console.WriteLine("- Можно вводить ответы как с заглавной буквы,");
            Console.WriteLine("  так и в нижнем регистре");
            Console.WriteLine("- Для выхода в любой момент используйте команду '3'");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nАВТОР:");
            WhiteColor();
            Console.WriteLine("Разработчик: SStepov");
            Console.WriteLine("Версия: 1.0");
            Console.WriteLine("Год создания: 2025");

            MenuColor();
            Console.Write("\n[Информация] ");
            WhiteColor();
            Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
            Console.Clear();
        }
        static void Error()
        {
            Console.Clear();
            MenuColor();
            Console.Write("[Ошибка] ");
            WhiteColor();
            Console.WriteLine("Извините я вас не понимаю, проверьте ваш ввод!");
            MenuColor();
            Console.Write("[Ошибка] ");
            WhiteColor();
            Console.WriteLine("Для продолжения, нажмите любую клавишу!");
            Console.ReadKey();
            Console.Clear();
            WhiteColor();
        }
        static void WhiteColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void MenuColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}