// Суперсдвиг!

System.Console.WriteLine("Введите колличество чисел массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int[] newArr = array;
System.Console.WriteLine("Введите числа массива: ");
for (int i = 0; i < N; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("Введите число на которое нужно сделать сдвиг: ");
int K = Convert.ToInt32(Console.ReadLine());
if (K > 0)
    while (K > 0)
    {
        int temporary = array[N - 1];
        for (int i = N - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                array[0] = temporary;
            }
            else
            {
                array[i] = array[i - 1];
            }
        }

        K--;
    }
else if (K < 0)
{
    while (K < 0)
    {
        int temporary = array[0];
        for (int i = 0; i <= N - 1; i++)
        {
            if (i == N - 1)
            {
                array[N - 1] = temporary;
            }
            else
            {
                array[i] = array[i + 1];
            }
        }

        K++;
    }
}
System.Console.WriteLine($"[{string.Join(", ", array)}]");


