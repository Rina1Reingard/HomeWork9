/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number)&& number>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некоректное число. Повторите ввод");
        }
    }
    return number;
}

void Reverse(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        Reverse(n - 1);
    }
}

int number = GetNumber("Введите целое положительное число");
Reverse(number);