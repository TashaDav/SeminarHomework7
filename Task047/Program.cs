// Задайте двумерный массив размером m x n, заполненный случайными
// вещественными числами.
// m = 3, n = 4

Console.WriteLine("Задайте количество строк массива(m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива(n): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array = new double[m, n];
Random rnd = new Random();

void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
    { for (int j = 0; j < n; j++)
        { 
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
    { for (int i = 0; i < m; i++)
        { for (int j = 0; j < n; j++)
            { 
                matr[i,j] = Convert.ToDouble(rnd.Next(-10, 10)/10.0);
            }
        }
    }
FillArray(Array);
Console.WriteLine();
PrintArray(Array);