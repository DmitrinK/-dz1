// программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;
int countM= 0;
int[] answer = new int[userNumber/2];
while (userNumber > count)
{
    if (count % 2 == 0)
    {
        answer[countM] = count;
        count ++;
        countM ++;
    }
    else
    {
        count ++;
    }
}
foreach(var a in answer)
{
    Console.Write(a.ToString() + ",");
}