using System;

partial class Program
{
    static void Main(string[] args)
    {
        int vibor = 0;

        // An highlighted block
        Random a = new Random();
        int b = a.Next(0, 101);
        string m;
        for (int j = 3; j > 0; --j)
        {
            Console.WriteLine("Пожалуйста, введите номер:");
            int i = int.Parse(Console.ReadLine());
            if (j > 1)
            {
                if (b > i)
                {
                    Console.WriteLine("Угадайте маленькую, и возможность для {0}!", j - 1);

                }
                else
                if (b < i)
                {
                    Console.WriteLine("Угадай, и есть {0} Время возможности!", j - 1);
                }
                else
                if (b == i)
                {
                    Console.WriteLine("Поздравляю, угадай, правильно !!!");
                    break;
                }
                Console.WriteLine("Вы продолжаете y/n");
                m = Console.ReadLine();
                if (m == "N")
                {
                    break;
                }
            }
            else if (j == 1)
            {
                if (b > i)
                {
                    Console.WriteLine("Угадай, маленький, что такое шанс!");
                }
                else
                if (b < i)
                {
                    Console.WriteLine("Угадай, что такое шанс!");
                }
                else
                if (b == i)
                {
                    Console.WriteLine("Поздравляю, угадай, правильно !");
                }
            }
        }


        Console.WriteLine();
        }
    }

    static void ygadayka()
    {
        Random random = new Random();
        int zagadannoechislo = random.Next(0, 101);
        int guess = -1;
        int attempts = 0;

        Console.WriteLine("Игра \"Угадай число\"");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать!");

        while (guess != zagadannoechislo)
        {
            Console.Write("Введите число: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < zagadannoechislo)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > zagadannoechislo)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine($"Поздравляю! Вы угадали число {zagadannoechislo} за {attempts} попыток.");
            }
        }
    }

    static void tablicaumnojenia()
    {
        Console.WriteLine("Таблица умножения:");

        int[,] mass = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < 5; j++)
            {
                if (i == 0)
                    mass[0, j] = mass[j, 0] = j + 1;
                else
                    mass[i, j] = mass[j, i] = mass[0, j] * mass[i, 0];
            }

        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.Write("\t" + mass[i, j]);
            Console.ReadLine();
        }
      
    }
    static void delitel()
    {
        Console.Write("Введите число: ");
        int i = int.Parse(Console.ReadLine());
        for (int a = 1; a <= i; a++)
        {
            if (i % a == 0) 
                Console.WriteLine(i);
        }
        Console.WriteLine(n);
}