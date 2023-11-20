// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int UserInput(string msg)
{
    System.Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int userM = UserInput("Введите число m:");
while (userM < 0)
{
    userM = UserInput ("Вы ввели число меньше нуля. Пожалуйста, введите неотрицательное число: ");
}

int userN = UserInput("Введите второе n:");
while (userN < 0)
{
    userN = UserInput ("Вы ввели число меньше нуля. Пожалуйста, введите неотрицательное число: ");
}
int anker = Ackermann(userM, userN);
Console.Clear();
System.Console.WriteLine($"m = {userM}; n = {userN} - A(m,n) = {anker}");