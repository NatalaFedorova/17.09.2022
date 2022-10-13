// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Task54()
{
    int row = 4;
    int column = 5;
    int[,] numbers = new int[row, column];
    FillTableInt(numbers);
    PrintTableInt(numbers);
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        int indexMax = i;
        for (int j = 0; j < column; j++)
        {
            int max = numbers[i, j];
            for (int k = j +1; k < column; k++)
            {
                if (numbers[i, k] > max)
                {
                    max = numbers[i, k];
                    indexMax = k;
                    (numbers[i, j], numbers[i, k]) = (numbers[i, k], numbers[i, j]);
                }
            }
        }
    }
    PrintTableInt(numbers);
}

void FillTableInt(int[,] tableNumbers, int minnumber = 0, int maxnumber = 10)
{
    maxnumber++;
    Random random = new Random();
    for(int i = 0; i < tableNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < tableNumbers.GetLength(1); j++)
        {
            tableNumbers[i,j] = random.Next(minnumber, maxnumber);
        }
    }
}

void PrintTableInt(int[,] tableNumbers)
{
    for(int i = 0; i < tableNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < tableNumbers.GetLength(1); j++)
        {
            Console.Write(tableNumbers[i, j] + "\t");
        }
    Console.WriteLine();
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void Task56()
{
    int row = 4;
    int column = 5;
    int[,] numbers = new int[row, column];
    FillTableInt(numbers);
    PrintTableInt(numbers);
    Console.WriteLine();

    int [] sumRows = new int[row];
    for(int i = 0; i < row; i++)
    {
        int sum = 0;
        for(int j = 0; j < column; j++)
        {
            sum += numbers[i, j]; 
        }
        sumRows[i] = sum;
    }
    FindnumbersMin(sumRows);
}

void FindnumbersMin(int[] numbers)
{
    int indexMin = 0;
    int min = numbers[indexMin];
    for (int i = 0; i < numbers.Length; i++)
    {
            if (numbers[i] < min)
            {
                min = numbers[i];
                indexMin = i;
            }    
    }
    Console.WriteLine($"Наименьшая сумма элементов в {indexMin + 1} строке. Она равна {min}");
}

// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Task58()
{
    int row = 4;
    int column = row;
    int[,] numbers = new int[row, column];
    for(int k = 1; k < row; k++)
    {
        numbers[0, k - 1] = 0*(row - 1) + k;
        numbers[k - 1, row - 1] = 1*(row - 1) + k;
        numbers[row - 1, row - k] = 2*(row - 1)+ k;
        numbers[row - k, 0] = 3*(row - 1) + k;
    }   
    for (int k = 1; k < row - 2; k++)
    {
        numbers[1, k] = 4*(row - 1) + k;
        numbers[k, (row - 1) - 1] = 4*(row - 1) + (row-2 - 1) + k;
        numbers[(row - 1) - 1, (row - 1) - k] = 4*(row - 1) + 2*(row-2 - 1) + k;
        numbers[(row - 1) - k, 1] = 4*(row - 1) + 3*(row-2 - 1) + k;
    }  
    PrintTableInt(numbers); 
}


// Task54();
// Task56();
//  Task58();
