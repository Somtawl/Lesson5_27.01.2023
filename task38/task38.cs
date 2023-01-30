var rand = new Random();
int[] NumArray = new int[rand.Next(2,11)];
int DifNumbers = 0;

void FillArray(int[] SomeArray)
{
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] = rand.Next(-1000,1000);
    }
}

void CheckNumbers(int[] SomeArray)
{
    int max = SomeArray[0];
    int min = SomeArray[0];
    for (int i = 1; i < SomeArray.Length; i++)
    {
        if (max < SomeArray[i]) max = SomeArray[i];
        else if (min > SomeArray[i]) min = SomeArray[i];
    }
    DifNumbers = max - min;
}

FillArray(NumArray);
CheckNumbers(NumArray);
Console.WriteLine("Массив {0}", String.Join(" ",NumArray));
Console.WriteLine("Итого разница между максимальным и минимальным значениями в массиве {0}",DifNumbers);
