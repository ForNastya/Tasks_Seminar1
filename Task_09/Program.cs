// Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
int newNumber = 0;
int numberDelete()
{
    newNumber = number / 100 * 10 + number % 10;
    return newNumber;
}
numberDelete();
Console.WriteLine();
Console.WriteLine($"Если из числа {number} удалить вторую цифру, получится число {newNumber}");
