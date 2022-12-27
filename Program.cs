//Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Примеры:
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// ["Russia", "Denmark", "Kazan"] → []

void ThreeDigitSymbol(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] arr1;
Console.WriteLine("Введите слова/символы через пробел:");
string stroka = Console.ReadLine();
arr1 = stroka.Split(' ');
string[] arr2 = new string[arr1.Length];
ThreeDigitSymbol(arr1, arr2);
PrintArray(arr2);



















// //Задача: Написать программу, которая из имеющегося массива строк формирует
// // новый массив из строк, длина которых меньше, либо равна 3 символам.
// // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// // Примеры:
// // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// // ["Russia", "Denmark", "Kazan"] → []


// string[] numbers = {"1234", "1567", "-2", "computer science"};
// // string[] numbers = {“Hello”, “2”, “world”, “:-)”}
// // string[] numbers = {"Russia", “Denmark”, “Kazan”}
// string[] result = new string[numbers.Length];
// void Array(string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//     if(array1[i].Length <= 3)
//         {
//         array2[count] = array1[i];
//         count++;
//         }
//     }
// }
// void PrintData(string[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         Console.Write(mas[i]+" ");
//     }
//     Console.WriteLine();
// }
// Array(numbers, result);
// PrintData(numbers);
// Console.WriteLine();
// PrintData(result);