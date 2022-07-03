// Console.Write("insert number:  ");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine($" {num} number square is {square}");
// double x = Math.Pow(num, 8);
// Console.WriteLine(x);

// if (num > 5)
// {
//     Console.WriteLine("Ok");
// }

// else Console.WriteLine("Error");

// double d = 5.55;
// int i = (int)d;


// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("insert 1 numbers:  ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("insert 2 numbers:  ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2)
// {
//     Console.WriteLine("Ok");
// }
// else Console.WriteLine("Error");
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Insert number from 1 till 7 ");

// int youDay = Convert.ToInt32(Console.ReadLine());

// if (youDay == 1)
// {
//     Console.WriteLine("Monday");
// }
// else if (youDay == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if (youDay == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// else if (youDay == 4)
// {
//     Console.WriteLine("Thursday");
// }
// else if (youDay == 5)
// {
//     Console.WriteLine("Friday");
// }
// else if (youDay == 6)
// {
//     Console.WriteLine("Saturday");
// }
// else if (youDay == 7)
// {
//     Console.WriteLine("Sunday");
// }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Нет такого дня недели"); break;
}