// программа, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 2 == 0)
{
    Console.WriteLine("да, число четное");
}
else
{
    Console.WriteLine("нет, число нечетное");
}