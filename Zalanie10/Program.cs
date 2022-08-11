Console.WriteLine("Введите 3х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n > 99) && (n<1000))
{
    Console.WriteLine(n.ToString()[1]);
}
else
{
    System.Console.WriteLine("Вы ввели не 3х значное число!");
}




