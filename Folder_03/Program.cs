// Написать программу замену элементов массива на противоположные
// int n = new Random().Next(-100, 101);

int n = 20;

int[] newArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

int[] Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(   );
}

int[] array = newArray(n);
PrintArray( array);
PrintArray(Array(array));