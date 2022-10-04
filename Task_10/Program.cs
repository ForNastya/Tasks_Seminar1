// Найти третью цифру числа с конца или сообщить, что ее нет
int number = 123;
if (number > 99)
{
    Console.WriteLine((number / 100)  % 10);
}    
else
{
  Console.WriteLine("Такого числа нет");  
}

