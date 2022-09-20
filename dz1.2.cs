// программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите число1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число3: ");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = userNumber1;
if (max < userNumber2)
{
    max= userNumber2;
}
if (max<userNumber3)
{
    max= userNumber3;
}
Console.WriteLine("Максимальное число: ");
Console.WriteLine(max);