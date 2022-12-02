// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.


System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = num % 10;
while (num / 10 > 9)
{
    num = num / 10;
    sum += num % 10;
}
sum += num / 10;
System.Console.WriteLine(sum);