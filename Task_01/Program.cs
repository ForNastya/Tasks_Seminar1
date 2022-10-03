//По двум заданным числам проверить является ли первое квадратом второго
Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB*numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}