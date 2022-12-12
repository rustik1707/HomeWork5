/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int []createArray(int numbers)
{
    int []array = new int[numbers];
   

    for (int i = 0; i < numbers; i++)
    {
        array[i] = new Random().Next(0,101);
    }

return array;

}
void Printarray(int[]array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( $"{array[i]} ");
    }

}
int MaxMinDifference(int[]array)
{
    int difference = 0;
    int max = array[0];
    int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
            if(array[i]<min)
            {
                min = array[i];
            }

        }
        difference = max-min;
    return difference;

}


int[]array = createArray(5);
Printarray(array);
int result = MaxMinDifference(array);
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным элементом массива равна:{result}");
