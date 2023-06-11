/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
using System;
using static System.Console;
int[] StringToInt() //возвращает введенные позиции через пробел в массив с проверкой необходимого количества чисел
{
    System.Console.WriteLine("Введите позицию элемента двумерного массива через пробел");
    string line = Console.ReadLine();
    string[] ArrayString = line.Split(" ");
    while (ArrayString.Length < 2 || ArrayString.Length > 2) // проверяет правильное количество введеннх чисел
    {
        System.Console.WriteLine($"Вы ввели неправильное количество чисел. Введите позицию элемента двумерного массива");
        line = Console.ReadLine();
        ArrayString = line.Split(" ");
    }
    int[] result = new int[ArrayString.Length];
    for (int i = 0; i < 2; i++) result[i] = int.Parse(ArrayString[i]);
    return result;
}
int[,] GetArray() // создает двумерный массив с рандомными элементами и количеством элементов
{
    int line = new Random().Next(1, 6);
    int column = new Random().Next(1, 10);
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++) result[i, j] = new Random().Next(0, 10);
    }
    return result;
}
bool Element(int[,] array, int[] position) //проверяет есть ли такой элемент
{
    return position[0] <= array.GetLength(0) && position[1] <= array.GetLength(1);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Write($" {array[i, j]}");
        WriteLine();
    }
}
Clear();
int[] position = StringToInt();
int[,] array = GetArray();
PrintArray(array);
if (Element(array, position)) WriteLine($"Элемент на позиции {position[0]};{position[1]} ==> {array[position[0], position[1]]}");
else WriteLine("Такого элемента нет");