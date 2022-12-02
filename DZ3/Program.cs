//Программа, которая задаёт массив из 8 элементов, предоставляет возможность пользователю ввести числа, и выводит их на экран.



int[] array = new int[8];
System.Console.WriteLine("Введите числа: ");
for (int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine($"[{string.Join(", ", array)}]");



