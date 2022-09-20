// программа для выявления большего числа из 2х 
Console.WriteLine("введите число1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int max;
int min; 
if (userNumber1>userNumber2)
{
    max= userNumber1;
    min= userNumber2;
}
else
{
    max= userNumber2;
    min= userNumber1;
}
Console.WriteLine("Максимальное число: ");
Console.WriteLine(max);
Console.WriteLine("Минимальное число: ");
Console.WriteLine(min);