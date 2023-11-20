// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();
int UserInput(string msg)
{
    System.Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEvenNumbers(int start, int end)
{
    if (start > end)
    {
        return;
    }
    if (start % 2 != 0)
    {
        start++;
    }
    System.Console.Write($"{start}, ");
    PrintEvenNumbers(start + 2, end);
}

int userFirst = UserInput("Введите первое число:");
int userSecond = UserInput("Введите второе число:");
System.Console.Write($"M = {userFirst}; N = {userSecond} -> ");
PrintEvenNumbers(userFirst, userSecond);