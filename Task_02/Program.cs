//По заданному номеру дня недели вывести его название
Console.WriteLine("Введите число от 1 до 7");
int numberWeek = int.Parse(Console.ReadLine());
if (numberWeek == 1)
{
    Console.WriteLine("Понедельник");
} 
if (numberWeek == 2)
{
     Console.WriteLine("Вторник");
}
if (numberWeek == 3)
{
    Console.WriteLine("Среда");
}
if (numberWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (numberWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberWeek == 7)
{
    Console.WriteLine("Воскресенье");
}