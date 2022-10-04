// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
Console.WriteLine("Вторая цифра = " + int.Parse(Console.ReadLine()) / 10 % 10);