int rndNum = new Random().Next(100, 1000);
System.Console.WriteLine($"Random number from 100...990 is => {rndNum}");

int newNum = rndNum / 100 * 10 + rndNum % 10;
System.Console.WriteLine($"Task number is {newNum}");


int firstDigit = rndNum / 100;
int secondDigit = rndNum % 10;

// System.Console.WriteLine($"Task number is " + firstDigit + secondDigit);

// int MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     if (firstDigit == secondDigit) return 0;
//     return firstDigit > secondDigit ? firstDigit : secondDigit; ;
// }

// int maxDigit = MaxDigit(rndNum);
// string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
// Console.WriteLine($"Max number is {rndNum} => {maxDigit}");


string result = firstDigit.ToString() + secondDigit.ToString();
System.Console.WriteLine($"Task number is {result}");

int newNum2(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}
int res = newNum2(rndNum);
System.Console.WriteLine($"Task number is {res}");