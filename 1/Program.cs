
// Решение в группах задач:
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int N = getVar();
System.Console.Write($"[{String.Join(",", genArr(N))}]\n");

// --- FUNC --- //
int[] genArr(int N){
    int[] arrNum = new int[N];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) {}

    return arrNum;
}

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}














// void GetArray(int[] arr, n)
// {
//     int i=0;
//     int j
//     Random rnd = new Random();
//     while(i<=n)
//     {
//         arr[i]= rnd.Next(0,1);
//         i++;
//     }
// }

// int [] array;






// int ProizvOt1DoN(int n)

// {
//     int i = 1;
//     int result = 1;
//     if (n <= 0 ||) return -1;
//         while (i <= n)
//         {
//             result = result * i;
//             i++;
//         }

//     return result;
// }

// int number = 0;
// Console.Write("Введите число:");
// while (!int.TryParse(Console.ReadLine(), out number))
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }
// Console.WriteLine(ProizvOt1DoN(number));



// адача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int number;

// int DigitsCount(int n)
// {
//     int i=1;
//     n=Math.Abs(n);

//     while (n / Math.Pow(10, i)>1)
//     {

//         i++;
//     }
//     return i;
// }


// Console.Write("Введите число:");
// while (!int.TryParse(Console.ReadLine(), out number))
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }
// Console.WriteLine(DigitsCount(number));

