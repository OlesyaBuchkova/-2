Console.WriteLine ("Введи любое число");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 || number < 1000)
{
   number = number % 10;

    Console.WriteLine(number);
}

else if (number < 100)
{
    Console.WriteLine("Третьей цифры нет"); 
}
else (number >= 1000);
{
     Console.WriteLine("пока хз"); 
}