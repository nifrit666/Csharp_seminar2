// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

System.Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number % 7 == 0 && Number % 23 == 0)
{
    System.Console.WriteLine("Введёное число кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Введённое число не кратно 7 и 23");
}
