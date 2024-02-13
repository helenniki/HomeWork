// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите начальную цифру: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечную цифру: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAckermana ( int m, int n)
{
if (m == 0)
{
    return (n+1);
}
else if (n == 0)
{
    return FunctionAckermana(m-1,1);
}
else 
{
    return FunctionAckermana(m-1, FunctionAckermana(m, n-1));
}
}

Console.Write (FunctionAckermana(m, n));