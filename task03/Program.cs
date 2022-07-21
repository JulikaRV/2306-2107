var rnd = new Random();
int firstDigit = rnd.Next(1, 100);

System.Console.WriteLine($"Random number 1 from 10...99 is => {firstDigit}");

int secondDigit = rnd.Next(1, 100);
// secondDigit.Next(1, 100);

System.Console.WriteLine($"Random number 1 from 10...99 is => {secondDigit}");

int res = firstDigit % secondDigit;

if (res == 0)
    Console.WriteLine($"{secondDigit} кратно {firstDigit}");
else Console.WriteLine($" остаток {res}");



string result = firstDigit % secondDigit == 0 ? $"{secondDigit} кратно {firstDigit}" :
$"{firstDigit % secondDigit}";

Console.WriteLine(result);


// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Max number is {rndNum} => {maxDigit}");

// int maxDigit = firstDigit;
// if (secondDigit > maxDigit) maxDigit = secondDigit;
// else if (secondDigit == maxDigit) maxDigit = 0;

// if (maxDigit > 0) Console.WriteLine($"Max number is {rndNum} => {maxDigit}");
// else Console.WriteLine($"цифры числа {rndNum} равны");