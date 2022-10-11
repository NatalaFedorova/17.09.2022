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
    for (int j = 0; j < column; j++)
    {
    int max = numbers[0, j];
    int indexMax = 0;
    for (int k = j +1; k < column; k++)
    {
        if (numbers[0, k] > max)
        {
        max = numbers[0, k];
        indexMax = k;
        (numbers[0, j], numbers[0, k]) = (numbers[0, k], numbers[0, j]);
        }
    }
    }
    PrintTableInt(numbers);

}


void sortnumbers(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
int max = Math.Abs(numbers[i]);
int imax = i;
for (int j = i+1; j < numbers.Length; j++)
{
    if (Math.Abs(numbers[j]) > max)
    {
        max = Math.Abs(numbers[j]);
        
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }    
}
}
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

void Printarray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    { 
        Console.Write(numbers[i] + "  ");
    }
Console.WriteLine();
}

Task54();
