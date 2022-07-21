// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8] { 5, 4, 8, 9, 10, 88, 9, 14 };

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());


int[] FillArray(int num)

{
    int[] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 5);
        index++;
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 1; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }

}

int[] arr = FillArray(num);
PrintArray(arr);

