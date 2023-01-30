var rand = new Random();
int[] NumArray = new int[rand.Next(2,11)];
int SumNumbers = 0;

void FillArray(int[] SomeArray)
{
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] = rand.Next(-1000,1000);
    }
}

void CheckNumbers(int[] SomeArray)
{
    for (int i = 1; i < SomeArray.Length; i = i + 2)
    {
        SumNumbers = SumNumbers + SomeArray[i];
    }
}

FillArray(NumArray);
CheckNumbers(NumArray);
Console.WriteLine("Массив {0}", String.Join(" ",NumArray));
Console.WriteLine("Итого сумма чисел на нечётных позициях в массиве {0}",SumNumbers);
