
// // // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// // //  какое число большее, а какое меньшее.

// // // a = 5; b = 7 -> max = 7
// // // a = 2 b = 10 -> max = 10
// // // a = -9 b = -3 -> max = -3

Console.Write("insert number:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 2 number:  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max number is " + a + " and min number is " + b);
}
else Console.WriteLine("max number is " + b + " and min number is " + a);

// // // Задача 4: Напишите программу, которая принимает на вход три числа и 
// // // выдаёт максимальное из этих чисел.

// // // 2, 3, 7 -> 7
// // // 44 5 78 -> 78
// // // 22 3 9 -> 22

Console.Write("insert number:  ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 2-nd number:  ");
int D = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 3-th number:  ");
int E = Convert.ToInt32(Console.ReadLine());
int max = C;

if (C < D)
{
    max = D;
}
else if (D < E)
{
    max = E;
}

Console.WriteLine("Max number is :  " + max);

// // // Задача 6: Напишите программу, которая на вход принимает число и 
// // //выдаёт, является ли число чётным (делится ли оно на два без остатка).

// // // 4 -> да
// // // -3 -> нет
// // // 7 -> нет

Console.WriteLine("insert number:  ");
int X = Convert.ToInt32(Console.ReadLine());

if (X % 2 == 0)
{
    Console.WriteLine(X + " is even number");
}
else
{
    Console.WriteLine(X + " is not even number");
}

// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("insert number:  ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }

    i++;
}
// Задача 5: Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("insert number:  ");
int N1 = Convert.ToInt32(Console.ReadLine());
int N2 = N1 * -1;

while (N2 <= N1)
{
    Console.Write(N2 + " ");
    N2++;
}

// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("insert number three-digit number:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number % 10);