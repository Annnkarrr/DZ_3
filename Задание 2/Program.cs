//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

System.Console.WriteLine("Введите количество элементо в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] array = new int [number];
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

for (int i = 0; i < number; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
    
}
System.Console.WriteLine($"В данном массиве {count} четных чисел " );
