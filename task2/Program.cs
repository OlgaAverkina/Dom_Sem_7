// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n
int AkkermanFun(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFun(m - 1, 1);
    return AkkermanFun(m - 1, AkkermanFun(m, n-1));
}

int result = 0;
Console.WriteLine("Введите первое неотрицательное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число:");
int n = Convert.ToInt32(Console.ReadLine());
result = AkkermanFun(m, n);
Console.Write("Результат функции Аккермана: ");
Console.WriteLine(result);