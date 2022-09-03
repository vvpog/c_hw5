// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

void DiffMaxMin()
{
Console.WriteLine("введите число элементов в массиве, целое положительное число " );
int N= Convert.ToInt32(Console.ReadLine());
double max_i = 0;
double min_i = 0;

double[] array=new double [N];

Random rand = new Random();
for (int i=0; i<N; i++)
 {
    array[i] = rand.NextDouble();
    Console.Write($"{array[i]} ");
 };
Console.WriteLine(" ");

    double max = array[0];
    for (int i=1; i<N; i++)
    {
      if (array[i]>max) { max=array[i]; max_i = i+1;}
    }
     Console.WriteLine($"max = {max}, number = {max_i} ");

double min = array[0];
    for (int i=1; i<N; i++)
    {
      if (array[i]<min) { min=array[i]; min_i = i+1;}
    }
     Console.WriteLine($"min = {min}, number = {min_i}  ");

double diff = max-min;
Console.WriteLine($"разница max-min = {diff} ");
}
DiffMaxMin();    