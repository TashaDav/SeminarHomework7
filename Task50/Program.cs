// Написать программу, которая на вход принимает значение
// элемента в двумерном массиве, и возвращает позицию этого
// элемента или же указывает, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого элемента нет

/*
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }
 */

 Console.Write("Введите количесвто строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесвто столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = new double[m,n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void array(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.NextDouble();
            Console.Write($"{randomArray[i,j]:F2} ");
        }
        Console.WriteLine();
    }
}
array(m,n);
if (m2 <= m+1 && n2 <= n+1)
{
    Console.Write($"Значение элемента равно {randomArray[m2-1, n2-1]:F2} ");
}
else 
{
    Console.Write("Такого элемента нет в массиве");
}