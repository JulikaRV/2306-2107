// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// Console.Write("Введите цифру: ");
// int number = Convert.ToInt32(Console.ReadLine());
// switch (number)
// {
//     case 1: Console.WriteLine("Понедельник - это рабочий день"); break;
//     case 2: Console.WriteLine("Вторник - это рабочий день"); break;
//     case 3: Console.WriteLine("Среда - это рабочий день"); break;
//     case 4: Console.WriteLine("Четверг - это рабочий день"); break;
//     case 5: Console.WriteLine("Пятница - это рабочий день"); break;
//     case 6: Console.WriteLine("Суббота - это выходной день"); break;
//     case 7: Console.WriteLine("Воскресенье - это выходной день"); break;
//     default: Console.WriteLine("Нет такого дня недели"); break;
// }

Console.Clear();
Console.WriteLine("Введите номер четверти 1-4");
System.Console.Write("Номер: ");
int q = Convert.ToInt32(Console.ReadLine());

switch (q)
{
    case 1: Console.WriteLine("Первая четверть - это x > 0 и y > 0"); break;
    case 2: Console.WriteLine("Вторая четверть - это x < 0 и y > 0"); break;
    case 3: Console.WriteLine("Третья четверть - это x < 0 и y < 0"); break;
    case 4: Console.WriteLine("Четвертая четверть - это x > 0 и y < 0"); break;
    default: Console.WriteLine("Неверное число"); break;
}

string Quarter(int number)
{
    if (number == 1) return "Первая четверть - это x > 0 и y > 0";
    if (number == 2) return "Вторая четверть - это x < 0 и y > 0";
    if (number == 3) return "Третья четверть - это x < 0 и y < 0";
    if (number == 4) return "Четвертая четверть - это x > 0 и y < 0";
    return "Неверное число";


}



string result = Quarter(q);
System.Console.WriteLine(result);
