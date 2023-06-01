// Задайте двумерный массив размером m x n, заполненный случайными
// вещественными числами.
// m = 3, n = 4

/*Console.Write("Введтие количесвто строк массива (m): ");
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
*/

/*Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
*/

using System;
namespace CSharp_Shell
{ public static class Program
{ public static void Main()
{ Int32 k, l, m, n;
Console.Write("m n: ");
var s = Console.ReadLine().Split(" ");
m = Convert.ToInt32(s[0]);
n = Convert.ToInt32(s[1]);
Random rnd = new Random();
double [,] A = new double [m,n];
for (k = 0; k < m; k++)
{ for (l = 0; l < n; l++)
{ A[k,l]=20.0*rnd.Next()/2147483648-10.0;
Console.Write(String.Format("{0,5:f1}",
A[k,l])); } Console.WriteLine(); } } } }