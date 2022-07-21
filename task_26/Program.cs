// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

// int sum = 1;
// for (int i = 0; i < num; i++)
// {
//     num /= 10;
//     sum = sum + 1;

// }
// System.Console.WriteLine(sum);

// int i = 0;
// while (num > 0)
// {
//     i++;
//     num /= 10;
// }
// System.Console.WriteLine("... : {0}", i);

int Numb(int num)
{
    int i = 0;
    while (num > 0)
    {
        i++;
        num /= 10;
    }
    return i;
}

int result = Numb(num);
System.Console.WriteLine(result);