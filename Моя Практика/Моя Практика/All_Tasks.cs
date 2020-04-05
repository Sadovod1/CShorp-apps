using System;
using Моя_Практика.Классы;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моя_Практика
{
    class All_Tasks

    {
        void Pause()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\t\tНажмите любую клавишу, что бы продолжить..");
            Console.ReadKey();
            Console.ResetColor();
        }

        //2.	Пользователь вводит строку.Удалить все цифри из строки.
        public void Task_2()
        {
            string s = Console.ReadLine();
            string str = " ";
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    str += s[i];
                }
            }
            Console.WriteLine(str);
            Pause();
        }

        public void Task_1()
        {
            /*
    1.	Пользователь вводит строку.
    Проверить, является ли эта строка палиндромом. 
    Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
    */
            Console.WriteLine("Input any string for check current string is Palindrom: ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Reverse(ch); Console.WriteLine("\n");
            string newStr = new string(ch);
            if (str == newStr) Console.WriteLine("\nString is Palindrom!!!\n");
            else if (!(str == newStr)) Console.WriteLine("\nString is not Palindrom.");
            Pause();
        }

        public void Task_3()
        {
            /* 
             3.	Создать метод, принимающий введенную пользователем 
             строку и выводящий на экран статистику по этой строке.
             Статистика должна включать общее количество символов,
             количество букв(сколько в верхнем регистре и сколько в нижнем), 
             количество цифр и количество пробельных символов.
             */
            Console.Write("Input any string: ");
            string a = Console.ReadLine();
            int Upper = 0, Lower = 0, Numb = 0, Spaces = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsUpper(a[i]))
                    Upper++;
                if (char.IsLower(a[i]))
                    Lower++;
                if (char.IsDigit(a[i]))
                    Numb++;
                if (char.IsWhiteSpace(a[i]))
                    Spaces++;
            }
            Console.WriteLine($"Upper = {Upper}, \nLower = {Lower}, \nNumbers = {Numb}, \nSpaces = {Spaces}");
            Pause();
        }

        public void Task_4()
        {
            //4.Пользователь вводит строку и символ.
            //  В строке найти все вхождения этого символа и перевести его в верхний регистр, а также удалить часть строки, 
            //  начиная с последнего вхождения этого символа и до конца.
            Console.Write("Input any string: ");
            string a = Console.ReadLine();
            Console.Write("Input any symbol: ");
            char symb = char.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == symb) count++;
            }
            if (count > 0)
            {
                Console.WriteLine($"\nSymbol - {symb} had been found {count} times");
                string str = a.Replace(symb, Convert.ToChar(Convert.ToInt32(symb) - 32));
                Console.WriteLine($"Changed string: {str}");
            }
        }
        public void Task_5()
        {
            //   5.Ввести строку с клавиатуры и реализовать интерфейс для работы со строкой. Возможности интерфейса: 
            //•	Отображение текста на экран.
            //•	Количество символов в тексте.
            //•	Поиск заданного слова - по итогам показывать статистику(сколько раз встречается и на каких позициях).
            //•	Замена слова на новое слово.
            //•	Удаление слова.
            int ch = 0;
            Console.Write("Введите любой текст:");
            string str = Console.ReadLine();
            do
            {
                Console.WriteLine(new string('-', 80));
                Console.WriteLine("1 - Отображение текста на экран\n2 - Количество символов в тексте\n" +
                    "3 - Поиск заданного слова - по итогам показывать статистику(сколько раз встречается и на каких позициях)\n4 - Замена слова на новое слово\n" +
                    "5 - Удаление словa\n0 - Выход");
                Console.Write("Сделайте свой вибор...");
                Console.WriteLine("\n\n" + new string('-', 80));
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"текущая строка - {str}");
                        Pause();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"кол символов: {str.Length}");
                        Pause();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("ВВедите слово: ");
                        string word = Console.ReadLine();
                        if (str.Contains(word))
                        {
                            Console.WriteLine($"слово {word} есть в тексте {str}");
                        }
                        else Console.WriteLine($"слово {word} нет в тексте {str}");
                        int i = 0, y = -1, z = -1;
                        while (i != -1)
                        {
                            i = str.IndexOf(word, y + 1);
                            y = i;
                            z++;
                            if (y != -1)
                            {
                                Console.WriteLine($"положение ищущего слова {y}");
                            }
                        }
                        Console.WriteLine($"слово - {word} встречаеться {z} раз в текущей строке {str}");
                        Pause();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("ВВедите слово: ");
                        string word1 = Console.ReadLine();
                        Console.Write("Введите слово, что бы заменить: ");
                        string new_word = Console.ReadLine();
                        if (str.Contains(word1))
                        {
                            Console.WriteLine($"слово {word1} есть в тексте {str}");
                            string changed_str = str.Replace(word1, new_word);
                            Console.WriteLine($"Измененный текст: {changed_str}");
                        }
                        else Console.WriteLine($"слово {word1} нет в тексте {str}");
                        Pause();
                        break;
                    case 5:
                        Console.Write("Введите слово, что бы удалить: ");
                        string del_word = Console.ReadLine();
                        if (str.Contains(del_word))
                        {
                            Console.WriteLine($"слово {del_word} есть в тексте {str}");
                            string changed_str = str.Replace(del_word, "");
                            Console.WriteLine($"Измененный текст: {changed_str}");
                        }
                        else Console.WriteLine($"слово {del_word} нет в тексте {str}");
                        Pause();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect inputting.. Try again!");
                        Pause();
                        break;
                }
            }
            while (ch != 0);
        }

        public void Task_6()
        {
            SysBlock s1 = new SysBlock("X22", "ahhs1", "HP", 700, 4, 1200);
            SysBlock s2 = new SysBlock();
            Monitor m1 = new Monitor("Samsung", "720/1024", " '15,6", 990);

            s1.Print();
            m1.Print();

            s2.Set_Brend("Dell");


            Pause();
        }
    }
}
