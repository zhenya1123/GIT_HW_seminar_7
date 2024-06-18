// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, 
// не использовать циклы.

void NaturalNumbersFromMToN(int a, int b)
{
    if (a == b) 
    {
        Console.Write($"{a} ");
        return;
    }
    else if (a > b)
    {
        Console.Write($"{a} ");
        NaturalNumbersFromMToN(a - 1, b);
    
    }
    else
    {
        Console.Write($"{a} ");
        NaturalNumbersFromMToN(a + 1, b);
    }
}

Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натурально число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0 && m > 0)
{
    NaturalNumbersFromMToN(m, n);
}
else 
{
    Console.Write("Ошибка ввода!");
}