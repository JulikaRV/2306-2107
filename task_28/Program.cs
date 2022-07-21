// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

decimal res = 1;
for (int i = 1; i <= num; i++)
{
    try
    {
        checked
        {
            res = res * i;
        }
    }
    catch (System.Exception)
    {

        System.Console.WriteLine("Переполнение типа!");
        break;
    }
}
System.Console.WriteLine($" произведение чисел от 1 до {num} = {res}");

// void Fact(int number)
// {
//     int res = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         res = res * i;
//     }
//     Console.WriteLine(res);
// }

// Fact(num);