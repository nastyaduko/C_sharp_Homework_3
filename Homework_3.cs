//Задача 1. Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом

System.Console.WriteLine("Введите пятизначное число: ");
string text = Console.ReadLine()!;
if(text.Length == 5)
{
    if(text[0]==text[4]&&text[1]==text[3])
    {
    System.Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
    System.Console.WriteLine("Введеннное число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введеннное число не является пятизначным");
}

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве

System.Console.WriteLine("Введите координату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round((Math.Sqrt(Math.Pow((x1-x2), 2)+Math.Pow((y1-y2), 2)+Math.Pow((z1-z2),2))),2);
System.Console.WriteLine($"Расстояние между точками A и B равно {result}");

// Задача 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= N; i++)
{
    System.Console.Write(Math.Pow(i, 3)+" ");
}

