
// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

System.Console.Write("Введите X: ");
int NumberX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y: ");
int NumberY = Convert.ToInt32(Console.ReadLine());

if(NumberX > 0 && NumberY > 0)
{
System.Console.WriteLine("Точка в четверти № 1");
}

if(NumberX < 0 && NumberY > 0)
{
System.Console.WriteLine("Точка в четверти № 2");
}

if(NumberX < 0 && NumberY < 0)
{
System.Console.WriteLine("Точка в четверти № 3");
}

if(NumberX > 0 && NumberY < 0)
{
System.Console.WriteLine("Точка в четверти № 4");
}
