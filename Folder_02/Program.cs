// Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива

int n = 12;
int min = -9;
int max = 9;

int[] newArray(int n, int min, int max)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] Sums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sums[0] += arr[i];
        else sums[1] += arr[i];
    }
    return sums;
}

void PritArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]} ");
    }
       Console.WriteLine();
}

PritArray(Sums(newArray(n, min, max)));