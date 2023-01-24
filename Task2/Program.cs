// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

double DigitsSum(int number)
{
    int i = 1;
    double result = 0;
    int CurrentDigit = 0;
    number = Math.Abs(number);

    if (number != Convert.ToInt32(number)) return -1;
    while (number >= 1)
    {
        CurrentDigit = Convert.ToInt16(number % 10);
        result = result + CurrentDigit;
        number = (number - CurrentDigit) / 10;
    }

    return result;
}

int MyNym;
double Res;
Console.WriteLine("Программа считает сумму цифр в числе");
Console.Write("Введите целое число:");
while (!int.TryParse(Console.ReadLine(), out MyNym))
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите целое число");
}
Res = DigitsSum(MyNym);
if(Res<0)
    Console.WriteLine("Что-то пошло не так... ");    
else 
    Console.WriteLine("Ответ:" + Res);
