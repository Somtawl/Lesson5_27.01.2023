var rand = new Random();
int[] NumArray = new int[rand.Next(2,11)];
int CountNumbers = 0;

void FillArray(int[] SomeArray)
{
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] = rand.Next(100,1000);
    }
}

void CheckNumbers(int[] SomeArray)
{
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if (SomeArray[i] % 2 == 0)
        {
            CountNumbers = CountNumbers + 1;
        }
    }
}

FillArray(NumArray);
CheckNumbers(NumArray);
Console.WriteLine("Массив {0}", String.Join(" ",NumArray));
Console.WriteLine("Итого четных сичел в массиве {0}",CountNumbers);
