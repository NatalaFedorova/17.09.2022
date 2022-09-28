// Задача 25: Используя определение степени числа, напишите цикл, 
// который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void task25()
{
Console.WriteLine("Введите число A");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int secondnumber = Convert.ToInt32(Console.ReadLine());
int power = firstnumber;
for (int i = 2; i <= secondnumber; i++)
{
    power = power * firstnumber;
}
Console.WriteLine($"{firstnumber} в степени {secondnumber} = {power}");
}
// task25();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

void task27()
{
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
int num = number;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine($"Симма цифр числа {num} равна {sum}");
}

// task27();

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.

// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]
void task29()
{
Random random = new Random();
int size = 8;
int[] numbers = new int[size];
void fillarray (int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-99, 100);
        Console.Write(numbers[i] + "  ");
    }
Console.WriteLine();
}
fillarray(numbers);
void sortnumbers()
{
for (int i = 0; i < size; i++)
{
int max = Math.Abs(numbers[i]);
int imax = i;
for (int j = i+1; j < size; j++)
{
    if (Math.Abs(numbers[j]) > max)
    {
        max = Math.Abs(numbers[j]);
        
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }    
}
Console.Write(numbers[i] + "  ");  
}
Console.WriteLine();
}
sortnumbers();
}
task29();