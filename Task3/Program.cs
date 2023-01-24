// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int [,]  ArrayInOut(int[] arr, string ArrayInOut)
{
    int i = 0;
    while(i<=arr.Length)
    {
        if (ArrayInOut == "in")
        {
            Console.Write("Введите " + i + "-й элемент массива");
            while (!Int32.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
            }
        }
        else        
        {
            Console.Write (arr[i] + " ");

        }

    }
if (ArrayInOut=="in") return arr; 

}


int[] arr = new int[2];

int i = 0;
while (i <= 1)
{
    Console.Write("Введите координату x для точки " + DotName[i] + ":");
    while (!Int32.TryParse(Console.ReadLine(), out x[i]))
    {
        Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
    }

    
    i++;
}
Console.WriteLine("Расстояние между точками равно:" + Dist3D(x[0],y[0],z[0],x[1],y[1],z[1]).ToString("#.##"));