// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while(number > 999)
    {
        number /= 10; // number = number / 10
    }
    System.Console.WriteLine(number % 10);

}
else
{
    System.Console.WriteLine("В числе отсутствует третья цифра!");
}
