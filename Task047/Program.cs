// Задайте двумерный массив размером m x n, заполненный случайными
// вещественными числами.
// m = 3, n = 4

Console.Write("Введтие количесвто строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
    {
    Console.WriteLine();
    for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.NextDouble();
            Console.Write($"{randomArray[i, j]:F2}");
        }

    }

}

mas(m,n);