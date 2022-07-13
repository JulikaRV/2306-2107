// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

var rnd = new Random();
int digit = rnd.Next(100, 1000);
System.Console.WriteLine($"Random number 1 from 1...999 is => {digit}");

if (digit % 7 == 0 && digit / 23 == 0) Console.WriteLine($"{digit} кратно ");
else Console.WriteLine($"{digit} не кратно");

Console.WriteLine("insert number");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7 == 0) && (num % 23 == 0)) Console.WriteLine($"{num} кратно ");
else Console.WriteLine($"{num} не кратно");







