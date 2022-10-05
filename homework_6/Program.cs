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
