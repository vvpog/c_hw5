// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void SummNechetMassive()
{
Console.WriteLine("введите число элементов в массиве, целое положительное число " );
int N= Convert.ToInt32(Console.ReadLine());
int[] array=new int [N];

for (int i=0; i<N; i++)
 {
    array[i]=new Random().Next(0, 10); 
    Console.Write($"{array[i]} ");
 };
Console.WriteLine(" ");

double summ = 0 ;
    for (int i=0; i<N; i++)
    {
        if (i%2==0) {summ = summ + array[i];}
    }
 Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {summ} ");

return;
}
SummNechetMassive();