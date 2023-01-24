// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double SuperPow(double a, int b)
{
    int i = 1;
    double result = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
    }
    return result;
}

double number;
int power;
Console.WriteLine("Программа принимает числа a и b и возводит a  в степень b");
Console.Write("Введите число для возведения в любую степень:");
while (!double.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

Console.Write("Введите степень(целое число):");
while (!Int32.TryParse(Console.ReadLine(), out power))
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

Console.WriteLine(number + " в степени " + power + " будет " + SuperPow(number, power));