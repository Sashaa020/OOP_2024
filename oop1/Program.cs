
internal class Program
{
    private static void Main(string[] args)
    {
        //Завдання №1 
        int month, day;
        Console.WriteLine("Введiть мiсяць: ");
        month = int.Parse(Console.ReadLine());
        Console.WriteLine("Введiть день: ");
        day = int.Parse(Console.ReadLine());

        if (month >= 1 && month <= 12)

        {
            if (month == 2)
            {
                if (day >= 1 && day <= 28)
                    Console.WriteLine(true);
                else
                {
                    Console.WriteLine(false);
                }
            }
            else if (month == 4 | month == 6 | month == 9 | month == 11)
            {
                if (day >= 1 && day <= 30)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else if (month == 1 | month == 3 | month == 5 | month == 7 | month == 10 | month == 12)
            {
                if (day >= 1 && day <= 31)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
        else
        {
            Console.WriteLine(false);
        }

        // Завдання №2 
        double digit, digit_mult;
        int round_number, round_number_mult, round_digit, numeric, firs_figure, second_figure, result;
        Console.WriteLine("Введіть число: ");
        digit = double.Parse(Console.ReadLine());
        digit_mult = digit * 100;
        round_number = (int)digit;
        round_number_mult = round_number * 100;
        round_digit = (int)digit_mult;
        numeric = round_digit - round_number_mult;
        firs_figure = numeric / 10;
        second_figure = numeric % 10;
        result = firs_figure + second_figure;
        Console.WriteLine(result);

        // Завдання №3
        int time;

        Console.WriteLine("Введiть годину: ");
        time = int.Parse(Console.ReadLine());

        if (time >= 0 && time <= 24)
        {
            if (time >= 0 && time <= 6)
                Console.WriteLine("Доброї ночi!");

            else if (time > 6 && time <= 12)
                Console.WriteLine("Доброго ранку!");
            else if (time > 12 && time <= 18)
                Console.WriteLine("Доброго дня!");
            else if (time > 18 && time <= 23)
                Console.WriteLine("Добрий вечір!");
        }

        // Завдання №4 

        int number_1, number_2, number_3;

        Console.WriteLine("Введiть перше число: ");
        number_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введiть друге число: ");
        number_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введiть третє число: ");
        number_3 = int.Parse(Console.ReadLine());

        int min = Math.Min(number_1, Math.Min(number_2, number_3));
        int max = Math.Max(number_1, Math.Max(number_2, number_3));

        Console.WriteLine($"Мiнiмальне число: {min}");
        Console.WriteLine($"Максимальне число: {max}");





        //Завдання №6 

        int random_number;
        Console.WriteLine("Введiть число: ");
        random_number = int.Parse(Console.ReadLine());
        if (random_number % 2 == 0)
            Console.WriteLine("Число парне");
        else if (random_number %
            2 == 1)
            Console.WriteLine("Число не парне");

        //Завдання №7 

        double Celsius, Fahrenheit;
        Console.WriteLine("Введiть градуси: ");
        Celsius = double.Parse(Console.ReadLine());
        Fahrenheit = Celsius * 9 / 5 + 32;

        Console.WriteLine(Fahrenheit);


        //Завдання №8

        int count = 0, n, number = 0, number_of_plus = 0;
        Console.WriteLine("Введiть n натуральне число: ");
        n = int.Parse(Console.ReadLine());

        while (count != n)
        {
            number_of_plus += 1;
            number += number_of_plus;
            count += 1;
        }

        Console.WriteLine(number);

        static void NewMethod()
        {
            Console.WriteLine("Введiть ширину: ");
        }
    }
}