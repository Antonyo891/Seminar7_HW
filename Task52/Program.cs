/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
using System;
using static System.Console;
int[] SizeArray() //возвращает размер двумерного массива число строк и число столбцов
{
    System.Console.WriteLine("Введите количество строк и столбцов двумерного массива");
    string line = Console.ReadLine();
    string[] ArrayString = line.Split(" ");
    while (ArrayString.Length < 2 || ArrayString.Length > 2) // проверяет правильное количество введеннх чисел
    {
        System.Console.WriteLine($"Вы ввели неправильное количество чисел. Введите количество строк и столбцов двумерного массива");
        line = Console.ReadLine();
        ArrayString = line.Split(" ");
    }
    int[] result = new int[ArrayString.Length];
    for (int i = 0; i < 2; i++) result[i] = int.Parse(ArrayString[i]);
    return result;
}
int[,] GetArray(int[] size) // создает двумерный массив с рандомными элементами
{
    int[,] result = new int[size[0], size[1]];
    for (int i = 0; i < size[0]; i++)
    {
        for (int j = 0; j < size[1]; j++) result[i, j] = new Random().Next(10);
    }
    return result;
}
double[] ArithmeticMean(int[,] array) //среднее арифметическое столбцов массива
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++) result[j] += array[i, j];
        result[j] /= array.GetLength(0);
    }
    return result;
}
void PrintArray(int[,] array) // вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Write($" {array[i, j]}");
        WriteLine();
    }
}
Clear();
int[] size = SizeArray();
int[,] array = GetArray(size);
PrintArray(array);
WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", ArithmeticMean(array)):f2}");