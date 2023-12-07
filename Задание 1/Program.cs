// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

System.Console.WriteLine("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int [number];
Random r = new Random();

int count = 0;

for ( int i = 0; i < number; i++)
{
    array[i]= r.Next(100);
}
System.Console.WriteLine("Сгенерироваемый массив:");
for ( int i = 0; i < number; i++)
{
    System.Console.Write(array[i] + " ");
}
for ( int i = 0; i < number; i++)
{
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}
System.Console.WriteLine($" В данном массиве количество элементов в диапозоне [20; 90] = {count}");