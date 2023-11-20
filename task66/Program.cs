// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int UserInput(string msg)
{
    System.Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + SumNumbers(start + 1, end);
}

int userFirst = UserInput("Введите первое число:");
int userSecond = UserInput("Введите второе число:");
int sum = SumNumbers(userFirst, userSecond);
Console.Clear();
System.Console.Write($"M = {userFirst}; N = {userSecond} -> {sum}");