Main();
void Main()
{
    int m = PromptM();
    int n = PromptN();
    
    if (m > n)
    {
        Console.Write($"Числа от {n} до {m}: ");
        Natural(n, m);
    }
    else if (m == n)
    {
        Console.Write($"Числа от {n} до {m}: {m}");
    }
    else
    {
    Console.Write($"Числа от {m} до {n}: ");
       Natural(m, n);
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

void Natural(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        Natural(m + 1, n);
    }
}