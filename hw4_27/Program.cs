// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;
    for (int i = 0; i < number; i++)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

int result = Sum(num);
System.Console.WriteLine($"сумма цифр в числе {num} = {result}");

// int sum = 0;
// int i = 0;
// while (num > 0)
// {
//     i++;
//     sum = sum + num % 10;
//     num /= 10;
// }
// System.Console.WriteLine($"сумма цифр в числе {num} = {sum}");