

// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.Write("insert number:  ");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine($" {num} number square is {square}");
// double x = Math.Pow(num, 8);
// Console.WriteLine(x);

var rnd = new Random();

int firstDigit = rnd.Next(1, 1000);
System.Console.WriteLine($"Random number 1 from 1...999 is => {firstDigit}");
int secondDigit = rnd.Next(1, 1000);
System.Console.WriteLine($"Random number 1 from 1...999 is => {secondDigit}");

int square1 = firstDigit * firstDigit;
int square2 = secondDigit * secondDigit;

if (square1 == secondDigit || square2 == firstDigit)
    Console.WriteLine($"одно число является квадратом другого.");
else Console.WriteLine("no");
