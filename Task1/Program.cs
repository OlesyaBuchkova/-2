Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("нет");
}
else if (number == -1 || number == -2 || number == -3 || number == -4 || number == -5)
{
    Console.WriteLine("Нет"); 
}
else if (number == 6 || number == 7 || number == -6 || number == -7)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("Нужно было ввести число от 1 до 7");
}

