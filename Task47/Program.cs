/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
using System;
using static System.Console;
double [,] GetArrayDouble (int line, int column) // создает двумерный массив с рандомными элементами
{
    double[,] result = new double [line,column];
    for (int i=0;i<line;i++)
    {
        for (int j=0; j<column; j++) result[i,j] = new Random().NextDouble() * new Random().Next(100);
    }
    return result;
}
int Enter(string text) // запрос на ввод целого числа
{
    WriteLine(text);
    int result = int.Parse(ReadLine());
    return result;
}
void PrintArray (double [,] array)
{ for (int i = 0; i< array.GetLength(0); i++)
{
    for (int j =0; j<array.GetLength(1);j++) Write($" {array[i,j]:f1}");
    WriteLine();
}
}
Clear();
int line = Enter("Введите количество строк");
int column = Enter("Введите количество стлбцов");
double [,] array = GetArrayDouble(line,column);
PrintArray(array);



