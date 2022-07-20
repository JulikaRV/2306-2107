// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();
Console.WriteLine("Введите координаты точки");
System.Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// // if (x > 0 && y > 0) System.Console.WriteLine("Первая четверть");
// // else if (x < 0 && y > 0) System.Console.WriteLine("Вторая четверть");
// // else if (x < 0 && y < 0) System.Console.WriteLine("Третья четверть");
// // else if (x > 0 && y < 0) System.Console.WriteLine("Четвертая четверть");
// // else System.Console.WriteLine("Введены некорректные координаты");

// string Quarter(int xc, int yc)
// {
//     if (xc > 0 && yc > 0) return "Первая четверть";
//     if (xc < 0 && yc > 0) return "Вторая четверть";
//     if (xc < 0 && yc < 0) return "Третья четверть";
//     if (xc > 0 && yc < 0) return "Четвертая четверть";
//     return "Введены некорректные координаты";
// }

// string Quarter2(int x, int y)
// {
//     string res = " ";
//     switch (x, y)
//     {
//         case ( > 0, > 0):
//             res = "Первая четверть";
//             break;
//         case ( < 0, > 0):
//             res = "Первая четверть";
//             break;
//         case ( < 0, < 0):
//             res = "Первая четверть";
//             break;
//         case ( > 0, < 0):
//             res = "Первая четверть";
//             break;
//         default:
//             res = "Введены некорректные координаты";
//             break;
//     }
//     return res;

// }

string Quarter3(int x, int y);
{
    switch ((x, y))
    {
        case ( > 0, > 0): case ( > 0, < 0): return "X>0";
        case ( < 0, < 0): case ( < 0, > 0): return "X<0";
        default: return "Введены некорректные координаты";

    }
}



// string result = Quarter(x, y);
// System.Console.WriteLine(result);
// string res = Quarter2(x, y);
// System.Console.WriteLine(res);
string res = Quarter3(x, y);

