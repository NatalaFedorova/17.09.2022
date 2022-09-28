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



