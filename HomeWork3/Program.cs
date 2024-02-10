System.Console.Write("Введите число двухзначное число (от 10 до 99): ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 9 && number < 100)
{
int firstNumber = number / 10;
int lastNumber = number % 10;

if(firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(lastNumber);
}
	}	
else
{
    System.Console.WriteLine("Вы ввели не двухзначное число!");
	}