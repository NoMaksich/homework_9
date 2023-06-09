// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Main();
void Main()
{
    int m = PromptM();
    int n = PromptN();
    int result=0;
    if (m > n)
    {
        result=Ackermann(n, m);
        Console.Write($"Сумма чисел от {n} до {m}: {result}");
    }
    else if (m == n)
    {
        Console.Write($"Числа от {n} до {m}: {m}");
    }
    else
    {
        result=Ackermann(m, n);
       Console.Write($"Сумма чисел от {m} до {n}: {result}");
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

int Ackermann(int m, int n)
{   
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}