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

task27();

