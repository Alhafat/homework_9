// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string getNumbers(int n)
{
    if (n != 1) return n.ToString() + " " + getNumbers(n - 1);
    else return "1";
}

void main()
{
    System.Console.WriteLine("Введите число n: ");
    int n = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine($"{n} ====> " + getNumbers(n));
}

main();