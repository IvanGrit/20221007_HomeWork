// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.


using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
int[,] array = GetRandomArray(paramet[0], paramet[1]);
WriteLine("Введите адрес ячейки массива (через пробел): ");
string[] adress = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] coord = ReadString(adress);
int x = FindCell(array, coord[0], coord[1]);


//PrintMatrix(array);










int[] ReadString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}



int[,] GetRandomArray(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next();
        }
    }
    return result;
}


void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}


int FindCell(int[,] matrix, int line, int column)
{
    int result = 0;
    if (line < matrix.GetLength(0) && column < matrix.GetLength(1)) result = (matrix[line, column]);
    else WriteLine("Элемент с таким индексом отсутствует в массиве");
    return result;
}





// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

//using static System.Console;
//Clear();
//WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
//string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int[] paramet = ReadString(parameters);
//double[,] array = GetRandomArray(paramet[0], paramet[1]);
//PrintMatrix(array);










//int[] ReadString(string[] input)
//{
//    int[] result = new int[input.Length];
//    for (int i = 0; i < input.Length; i++)
//    {
//        result[i] = Convert.ToInt32(input[i]);
//    }
//    return result;
//}



//double[,] GetRandomArray(int lines, int columns)
//{
//    double[,] result = new double[lines, columns];
//    for (int i = 0; i < lines; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {
//            result[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
//            //result[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-50, 51), 2);
//        }
//    }
//    return result;
//}


//void PrintMatrix(double[,] inMatrix)
//{
//    for (int i = 0; i < inMatrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < inMatrix.GetLength(1); j++)
//        {
//            Write($"{inMatrix[i, j]}\t");
//        }
//        WriteLine();
//    }
//}




// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.


//using static System.Console;
//Clear();

//WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
//string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int[] paramet = ReadString(parameters);
//int[,] array = GetRandomArray(paramet[0], paramet[1]);
//WriteLine("Введите адрес ячейки массива (через пробел): ");
//string[] adress = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int[] coord = ReadString(adress);
//PrintMatrix(array);
//FindCell(array, coord[0], coord[1]);



////PrintMatrix(array);










//int[] ReadString(string[] input)
//{
//    int[] result = new int[input.Length];
//    for (int i = 0; i < input.Length; i++)
//    {
//        result[i] = Convert.ToInt32(input[i]);
//    }
//    return result;
//}



//int[,] GetRandomArray(int lines, int columns)
//{
//    int[,] result = new int[lines, columns];
//    for (int i = 0; i < lines; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {
//            result[i, j] = new Random().Next(1,100);
//        }
//    }
//    return result;
//}


//void PrintMatrix(int[,] inMatrix)
//{
//    for (int i = 0; i < inMatrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < inMatrix.GetLength(1); j++)
//        {
//            Write($"{inMatrix[i, j]}\t");
//        }
//        WriteLine();
//    }
//}


//void FindCell(int[,] matrix, int line, int column)
//{
//    int result = 0;
//    if (line > matrix.GetLength(0) || column > matrix.GetLength(1)) WriteLine("Элемент с таким индексом отсутствует в массиве");
//    else WriteLine(matrix[line-1, column-1]);
//}



// Задача 52.Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
int[,] array = GetRandomArray(paramet[0], paramet[1]);
PrintMatrix(array);
FindAverage(array);




int[] ReadString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}



int[,] GetRandomArray(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}



void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

void FindAverage(int[,] data)
{

    for (int i = 0; i < data.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < data.GetLength(0); j++)
        {
            average += data[j, i];
        }
        WriteLine($"Среднее арифметическое чисел столбца {i} равно {average / data.GetLength(0)};");
    }
}

