/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int []createArray(int numbers)
{
    int []array = new int[numbers];
   

    for (int i = 0; i < numbers; i++)
    {
        array[i] = new Random().Next(-100,101);
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

int FindSum(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i= i+2)
    {
        sum = sum +array[i];
    }


    return sum;

}


int[]array = createArray(11);
Printarray(array);
int result = FindSum(array);
Console.WriteLine();
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях равна:{result}");