namespace Практическая_работа__2_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите номер программы: \n" +
                "1. Угадай число \n" +
                "2. Таблица Умножения \n" +
                "3. вывод делетилей числа\n" +
                "4. закрыть программу \n : ");
            string A;
            A = Console.ReadLine();
            int a = Convert.ToInt32(A);

            while (a != 4)
            {
                if (a == 1)
                {
                    Chislo();
                }
                if (a == 2)
                {
                    table();
                }
                if (a == 3)
                {
                    del();
                }





                static void Chislo()
                {
                    Random rand = new Random();
                    int A = rand.Next(100);

                    Console.WriteLine("угадайте число от 1 до 100, или для выхода в меню введите 0");

                    int vvod = Convert.ToInt32(Console.ReadLine());
                    if (vvod > 100)

                    {
                        Console.WriteLine("Введите число МЕНЬШЕ 100");
                        return;
                    };
                    
                    while (A != vvod)
                    {
                        if (vvod == 0)
                        {
                            Main();
                        };
                        if (A > vvod)
                        {
                            Console.WriteLine("Загаданное число больше введенного");
                            vvod = Convert.ToInt32(Console.ReadLine());

                        }
                        if (A < vvod)
                        {
                            Console.WriteLine("Загаданное число меньше введенного");
                            vvod = Convert.ToInt32(Console.ReadLine());
                        }



                    }
                    Console.WriteLine("Поздравляю Вы выиграли");
                    Main();
                }

                static void table()
                {

                    var table = new int[11, 11];
                    for (int i = 0; i < 11; ++i)
                    {
                        for (int j = 0; j < 11; ++j)
                        {
                            table[i, j] = i * j;
                        }
                    }
                    for (int i = 0; i < 11; ++i)
                    {
                        for (int j = 0; j < 11; ++j)
                        {
                            Console.Write("{0, 3}", table[i, j]);
                        }
                        Console.WriteLine();

                    }
                    Main();
                }
                static void del()
                {
                    Console.Write("Введите число: ");
                    int A = Convert.ToInt32(Console.ReadLine());
                    for (int a = 1; a <= A; a++)
                    {
                        if (A % a == 0) Console.WriteLine("{0} ", a);
                    }
                    Main();
                }
                
            }
            Console.WriteLine("Программа заверешена");
            
        } 
    }
}           
    
