// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int getSummNumbers(int m, int n)
{
    if (m == n) return m;
    else return getSummNumbers(m + 1, n) + m;
}


void main()
{
    System.Console.Write("Введите число m = ");
    int m = int.Parse(Console.ReadLine()!);

    System.Console.Write("Введите число n = ");
    int n = int.Parse(Console.ReadLine()!);

    if (n < m) System.Console.WriteLine("Введите n > m");
    else System.Console.WriteLine("Сумма элементов между введенными значениями равна " + getSummNumbers(m, n));
}

main();