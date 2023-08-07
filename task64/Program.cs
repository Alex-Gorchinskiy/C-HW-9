// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Recursia (int N , int count )
{
    if (N <= count) return count.ToString();
    return Recursia(N, count + 1) + ", " + count;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetInput("Введите число N: ");  
int count = 1;  
Console.WriteLine($"{Recursia(N , count )}");