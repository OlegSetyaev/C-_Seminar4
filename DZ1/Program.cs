// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число А: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int deg = Convert.ToInt32(Console.ReadLine());
int result = num;
while (deg > 1)
{
    result *= num;
    deg--;
}
System.Console.WriteLine(result);