//Напишите программу, которая выводит 
//случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.
//78 ->8
//12->2

int rndNum = new Random().Next(10, 100);
System.Console.WriteLine($"Random number from 10...99 is => {rndNum}");

// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Max number is {rndNum} => {maxDigit}");

// int maxDigit = firstDigit;
// if (secondDigit > maxDigit) maxDigit = secondDigit;
// else if (secondDigit == maxDigit) maxDigit = 0;

// if (maxDigit > 0) Console.WriteLine($"Max number is {rndNum} => {maxDigit}");
// else Console.WriteLine($"цифры числа {rndNum} равны");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit; ;
}

int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Max number is {rndNum} => {maxDigit}");