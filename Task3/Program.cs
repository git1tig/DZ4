// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void ArrayInOut(int[] arr, string ArrayInOut) // работает и на ввод и на вывод в зависимости от араметра  ArrayInOut
{
    int i = 0;
    while (i < arr.Length)
    {
        if (ArrayInOut == "edit")
        {
            Console.Write("Введите " + i + "-й элемент массива: ");
            while (!Int32.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
            }
        }
        else
        {
            Console.Write(arr[i] + " ");

        }
        i++;
    }
}

int n;
Console.Write("Введите размерность массива: ");
while (!Int32.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

int[] Array = new int[n];

ArrayInOut(Array, "edit");
Console.WriteLine("Вот ваш массив:  ");
ArrayInOut(Array, "print");

