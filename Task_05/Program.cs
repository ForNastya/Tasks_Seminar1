//Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    int N = 2;
    while (N <= number)
    {
        Console.Write(N);
        Console.Write(", ");
        N = N + 2;
    }
}
if (number < 0)
{
    int N = -2;
    while (N >= number)
    {
        Console.Write(N);
        Console.Write(", ");
        N = N - 2;
    }
}