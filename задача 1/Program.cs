/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int []createArray(int numbers)
{
    int []array = new int[numbers];
   

    for (int i = 0; i < numbers; i++)
    {
        array[i] = new Random().Next(99,1000);
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

int Evennumbers (int[]array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) result = result +1;  
    }

    return result;

}

int[]array = createArray(6);
Printarray(array);
int count = Evennumbers(array);
Console.WriteLine();
Console.WriteLine($"количество четных чисел в массиве:{count}");
