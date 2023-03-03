/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


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

void Sum(int a,int b)
{
    Console.Write(SumMN(a-1, b));
}

int SumMN(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumMN(m, n);
        return sum;
    }
}

int m = GetNumber("Введите первое целое положительное число");
int n = GetNumber("Введите второе целое положительное число");
Sum(m,n);