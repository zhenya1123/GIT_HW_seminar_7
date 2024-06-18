// Задача 2: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckermannFunction(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

Console.WriteLine("Введите натуральное число M");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натурально число N");
int b = Convert.ToInt32(Console.ReadLine());

if (a > 0 && b > 0)
{
    int res = AckermannFunction(b, a);
    Console.WriteLine(res);
}
else 
{
    Console.Write("Ошибка ввода!");
}