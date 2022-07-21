

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

// int sum = 0;

// for (int i = 0; i <= num; i++)
// {
//     sum += i;
// }

// System.Console.WriteLine($"Cумма чисел от 1 до {num} = {sum}");

int Sum(int number)
{
    int sum = 0;
    for (int i = 0; i < number; i++)
    {
        sum += i;
    }
    return sum;
}

int result = Sum(num);
System.Console.WriteLine($"Cумма чисел от 1 до {num} = {result}");