// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

double DigitsSum(double number)
{
    int i = 1;
    double result = 0;
    int CurrentDigit = 0;
    number = Math.Abs(number); // вдруг какая то зараза "-" поставила?

    //Если число не целое, мы его уцеляем :)
    while (number % 10 != Convert.ToInt32 (number % 10)) 
    {
        number = number * 10;
       // Console.WriteLine(number + "ещё дробное");
    }

    while (number >= 1)
    {
        CurrentDigit = Convert.ToInt16(number % 10);
        result = result + CurrentDigit;
        number = (number - CurrentDigit) / 10;
    }

    return result;
}

double MyNym;
double Res;
Console.WriteLine("Программа считает сумму цифр в числе");
Console.Write("Введите число:");

while (!double.TryParse(Console.ReadLine(), out MyNym))
{
   Console.WriteLine("Ввод неверный. Пожалуйста, введите число");
}

Res = DigitsSum(MyNym);
if (Res < 0)                                         
    Console.WriteLine("Что-то пошло не так... "); // Осталось со времен когда в методе стояла роверка на целое
else
    Console.WriteLine("Ответ:" + Res);
