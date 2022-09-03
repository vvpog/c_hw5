// Задать массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void ChetElMassive()
{
Console.WriteLine("введите число элементов в массиве, целое положительное число " );
int N= Convert.ToInt32(Console.ReadLine());
int chet_i = 0;

int[] array = new int [N];

for (int i=0; i<N; i++)
 {
    array[i]=new Random().Next(-999, 1000); 
    Console.Write($"{array[i]} ");
 };
Console.WriteLine(" ");

    for (int i=0; i<N; i++)
    {
      if (array[i]%2==0) { chet_i = chet_i+1;}
    }
     Console.WriteLine($"Количество четных чисел: number = {chet_i} ");
return;
}
ChetElMassive();