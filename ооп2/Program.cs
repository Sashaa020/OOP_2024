// Task 1
/*
Console.WriteLine("Введіть число:");
double number = Convert.ToDouble(Console.ReadLine());
if (number > 0)
 {
    Console.WriteLine("Число додатнє");
 }
else if (number < 0)
 {
    Console.WriteLine("Число від'ємне");
 }
else
 {
    Console.WriteLine("Число = 0");
 }
*/
// Task 2
/*
Console.WriteLine("Введіть рік");
int year = Convert.ToInt32(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
{
    Console.WriteLine($"{year} рік високосний");
}
else
{
    Console.WriteLine($"{year} рік не є високосним.");
}
*/
//Task 3
/*
Console.WriteLine("Ваш річний дохід");
double income = Convert.ToDouble(Console.ReadLine());
double tax = 0;
if (income <= 10000)
{
    tax = income * 0.05;
}
else if (income <= 50000)
{
    tax = 10000 * 0.05 + (income - 10000) * 0.1;
}
else
{
    tax = 10000 * 0.05 + 40000 * 0.1 + (income - 50000) * 0.2;
}
Console.WriteLine($"Ваш податок на дохід: {tax} грн");
*/
//Task 4
/*
Console.WriteLine("Введіть символ");
char input = Convert.ToChar(Console.ReadLine().ToUpper());
if (char.IsLetter(input))
{
    if ("AEIOU".Contains(input))
    {
        Console.WriteLine($"{input} голосна");
    }
    else
    {
        Console.WriteLine($"{input} приголосна");
    }
}
else
{
    Console.WriteLine("Символ не є літерою");
}
*/
//Task 5
/*
Console.WriteLine("Введіть три числа");
Console.WriteLine("Число 1");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число 2");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число 3");
double num3  = Convert.ToDouble(Console.ReadLine());
double max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max=num3;
}
Console.WriteLine($"Найбільше число: {max}");
*/
//Task 6
/*
Console.WriteLine("Введіть роки");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 12 &&  age <=18)
{
    Console.WriteLine("Це підлітковий вік");
}
else
{
    Console.WriteLine("Це НЕ є підлітковий вік");
}
*/
//Task 7
/*
Console.WriteLine("Введіть число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num} парне число");
}
else
{
    Console.WriteLine($"{num} НЕ парне  число");
}
if (num % 3 == 0)
{
    Console.WriteLine($"{num} ділиться на 3");
}
else
{
    Console.WriteLine($"{num} НЕ ділиться на 3");
}
*/
//Task 8
/*
Console.WriteLine("Введіть довжити 3х сторін");
Console.WriteLine("Сторона А:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сторона В:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сторона С:");
double c = Convert.ToDouble(Console.ReadLine());
double longest = a;
string longestSide = "a";
if (b > longest)
{
    longest = b;
    longestSide = "b";
}
if (c > longest)
{
    longest = c;
    longestSide = "c";
}
Console.WriteLine($"Найдовша сторона : {longestSide}, довжина : {longest}");
*/
