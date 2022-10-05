// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void Task41()
{
Console.WriteLine("Сколько чисел вы хотите проверить?");
int allNumbers = Convert.ToInt32(Console.ReadLine());
int countPositiveNumber = 0;
for (int i= 0; i < allNumbers; i++)
{
    Console.WriteLine("Ведите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) countPositiveNumber++;
}
Console.WriteLine($"{countPositiveNumber} чисел больше нуля");
}
// Task41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Task43()
{
Console.WriteLine("Введите параметры уравнений b1, k1, b2, k2");
float b1 = EnterDate();
float k1 = EnterDate();
float b2 = EnterDate();
float k2 = EnterDate();
Console.WriteLine($"Прямые заданы уравнениями y = {k1}x + {b1},  y = {k2}x + {b2}");
CrossPoint(b1, k1, b2, k2);
}

// Task43();

int EnterDate()
{
    Console.WriteLine("Ведите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CrossPoint(float b1, float k1, float b2, float k2)
{
    if (k1 == k2)
    {
       Console.WriteLine($"Это параллельные прямые. Они не имеют точки пересечения."); 
    }
    else
    {
        float x = (b2 - b1) / (k1 - k2);
        float y = k1 * x + b1;
        Console.WriteLine($"Они пересекаются в точка А({x}; {y}).");
    }
    
}