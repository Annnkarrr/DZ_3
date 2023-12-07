// // Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

/*Random rand = new Random();
double d = Math.Round(rand.Next(10) + rand.NextDouble(), 2);
Console.WriteLine(d);*/

System.Console.Write("Введите количество элеменетов в данном массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

double max = -1000;
double min = 1000;

double[] array = new double[number];
Random rand = new Random();

for (int i = 0; i < number; i++)
{
    array[i] = Math.Round(rand.Next(10) + rand.NextDouble(), 2);
    Console.WriteLine(array[i] + " ");
}

for ( int i = 0; i < number; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else
    {
        min = array[i];
    }
}
System.Console.WriteLine($" Минимальное = {min} и максимальное = {max}");

double summa = max - min;
System.Console.WriteLine($" Разница между максимальным и минимальным числом = {summa}");


