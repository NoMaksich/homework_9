// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Main();
void Main()
{
    int m = PromptM();
    int n = PromptN();
    int sum=0;
    if (m > n)
    {
        sum=Natural(n, m);
        Console.Write($"Сумма чисел от {n} до {m}: {sum}");
        Natural(n, m);
    }
    else if (m == n)
    {
        Console.Write($"Числа от {n} до {m}: {m}");
    }
    else
    {
        sum=Natural(m, n);
       Console.Write($"Сумма чисел от {m} до {n}: {sum}");
    }
}

int PromptM()
{
    Console.Write("Введите число M: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}

int PromptN()
{
    Console.Write("Введите число N: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}

int Natural(int m, int n)
{
    int summa=0;
    if (m <= n)
    {
        return m+Natural(m+1,n);
    }
    else
    {
        return 0;
    }
}