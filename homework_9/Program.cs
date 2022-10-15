// Задача 64: Задайте значения M и N. 
// Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Task64()
{
int m = InputNomber("Введите натуральное число M");
int n = InputNomber("Введите натуральное число N");
if (m > n)
{
    (m, n) = (n, m);
}
Console.WriteLine($"M = {m}, N = {n}");
Console.Write("Натуральные числа, кратные 3 => ");
FindNumbersDividingTree(m, n);
Console.WriteLine(); 
}

int InputNomber(string input = "Введите число")
{
    Console.WriteLine(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindNumbersDividingTree(int m, int n, int count = 0)
{
    if (m >= n)
    {
        if (count == 0)
        {
            Console.Write("нет чисел, кратных 3");
        }
        return;
    }  
    if (m % 3 == 0)
    {
        Console.Write($"{m} ");
        count++;  
    }
    m++;
    FindNumbersDividingTree(m, n, count);
}

void Task66()
{
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = InputNomber("Введите натуральное число M");
int n = InputNomber("Введите натуральное число N");
if (m > n)
{
    (m, n) = (n, m);
}
Console.Write($"Сумма натуральных чисел от {m} до {n} = ");
SumNumbers(m, n);
Console.WriteLine();
}
void SumNumbers(int m, int n, int sum = 0)
{
sum = sum + m;   
if (m >= n)
{
    Console.Write(sum);
    return;
}
m++;
SumNumbers(m, n, sum);
}

void Task68()
{
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int n = InputNomber("Введите неотрицательное число M");
int m = InputNomber("Введите неотрицательное число N");
int a = AkkermanFunction (n, m);
Console.WriteLine($"A({n}, {m}) = {a}");
}

int AkkermanFunction(int n, int m)
{
if (n == 0) 
{
    return m + 1;
}
else if ((n > 0) && (m == 0)) 
{
    return AkkermanFunction(n - 1, 1);
}
else 
{
    return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}
}


// Task64();
// Task66();
// Task68();
