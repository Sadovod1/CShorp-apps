using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моя_Практика
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            All_Tasks tasks = new All_Tasks();
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Input any string: ");
                        string str = Console.ReadLine();
                        char[] ch = str.ToCharArray();
                        Array.Reverse(ch);

                        string reverse_str = new string(ch);
                        if (str == reverse_str)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Введенная строка являеться Палиндромом!!!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Введенная строка HE являеться Палиндромом...");
                            Console.ResetColor();
                        }
                        break;
                      case 2:
                          Console.Clear();
                          tasks.Task_2();
                          break;
                      case 3:
                          Console.Clear();
                          tasks.Task_3();
                          break;
                      case 4:
                          Console.Clear();
                          tasks.Task_4();
                          break;
                      case 5:
                          Console.Clear();
                          tasks.Task_5();
                          break;
                     case 6:
                         Console.Clear();
                         tasks.Task_6();
                         break;
                    /* case 7:
                         Console.Clear();
                         tasks.Task_7();
                         break;
                     case 8:
                         Console.Clear();
                         tasks.Task_8();
                         break;
                     case 9:
                         Console.Clear();
                         tasks.Task_9();
                         break;
                     case 10:
                         Console.Clear();
                         tasks.Task_10();
                         break;
                     case 11:
                         Console.Clear();
                         tasks.Task_11();
                         break;
                     case 12:
                         Console.Clear();
                         tasks.Task_12();
                         break;
                     case 13:
                         Console.Clear();
                         tasks.Task_13();
                         break;
                     case 14:
                         Console.Clear();
                         tasks.Task_14();
                         break;
                     case 15:
                         Console.Clear();
                         tasks.Task_15();
                         break;
                     case 16:
                         Console.Clear();
                         tasks.Task_16();
                         break;
                     case 17:
                         Console.Clear();
                         tasks.Task_17();
                         break;
                     case 18:
                         Console.Clear();
                         tasks.Task_18();
                         break;
                     case 19:
                         Console.Clear();
                         tasks.Task_19();
                         break;
                     case 20:
                         Console.Clear();
                         tasks.Task_20();
                         break;
                     case 21:
                         Console.Clear();
                         tasks.Task_21();
                         break;
                     case 22:
                         Console.Clear();
                         tasks.Task_22();
                         break;
                     case 23:
                         Console.Clear();
                         tasks.Task_23();
                         break;
                     case 24:
                         Console.Clear();
                         tasks.Task_24();
                         break;
                     case 25:
                         Console.Clear();
                         tasks.Task_25();
                         break;
                     case 26:
                         Console.Clear();
                         tasks.Task_26();
                         break;
                     case 27:
                         Console.Clear();
                         tasks.Task_27();
                         break;
                     case 28:
                         Console.Clear();
                         tasks.Task_28();
                         break; */
                    case 0: break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This case doesn't exist..Try choice one of 1 - 20");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t     Нажмите любую клавишу, что бы продолжить..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                }
            }
            while (choice != 0);

        }
        static int Menu()
        {
        Start:
            int choice = 0;
            Console.Clear();
            Console.WriteLine("1 - Задача 1");
            Console.WriteLine("2 - Задача 2");
            Console.WriteLine("3 - Задача 3");
            Console.WriteLine("4 - Задача 4");
            Console.WriteLine("5 - Задача 5");
            Console.WriteLine("6 - Задача 6");
            Console.WriteLine("7 - Задача 7");
            Console.WriteLine("8 - Задача 8");
            Console.WriteLine("9 - Задача 9");
            Console.WriteLine("10 - Задача 10");
            Console.WriteLine("11 - Задача 11");
            Console.WriteLine("12 - Задача 12");
            Console.WriteLine("13 - Задача 13");
            Console.WriteLine("14 - Задача 14");
            Console.WriteLine("15 - Задача 15");
            Console.WriteLine("16 - Задача 16");
            Console.WriteLine("17 - Задача 17");
            Console.WriteLine("18 - Задача 18");
            Console.WriteLine("19 - Задача 19");
            Console.WriteLine("20 - Задача 20");
            Console.WriteLine("21 - Задача 21");
            Console.WriteLine("22 - Задача 22");
            Console.WriteLine("23 - Задача 23");
            Console.WriteLine("24 - Задача 24");
            Console.WriteLine("25 - Задача 25");
            Console.WriteLine("26 - Задача 26");
            Console.WriteLine("27 - Задача 27");
            Console.WriteLine("0 - Выход");
            Console.Write("Please make your choice..");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\t     Нажмите любую клавишу, что бы продолжить..");
                Console.ReadKey();
                Console.ResetColor();
                goto Start;
            }
            return choice;
        }
    }
}
    

        // Static c# ... Кроме модификатора доступа, перед названием поля, метода или свойства можно написать ключевое слово 
        //"static". "Static" означает, что данное поле, метод или свойство будет принадлежать не каждому объекту класса, а всем им вместе.


