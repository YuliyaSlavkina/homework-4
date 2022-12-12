// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Stepen(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result*a;
//     }
//     return result;
// }

// Console.Write("Enter first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = Stepen(a, b);
// Console.WriteLine(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Summ(int num)
// {
//     int result = 0;
//     while (num != 0)
//     {
//         result += num % 10;
//          num = num / 10;
//     }
//     return result;

// }
// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Summ(num);
// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array(int numb)
{
    int [] arr = new int [numb];
    for (int i = 0; i < numb; i++)
    {
        Console.Write("Enter your value: ");
        int value = Convert.ToInt32(Console.ReadLine());
        arr[i] = value;

    }

    return arr;
}
void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(size));