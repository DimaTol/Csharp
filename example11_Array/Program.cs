void FillArray(int[]collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random ().Next(1.9);
        index++;
    }
}

int [] array = new int[9];

void PrintArray(int[] col) 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int [] array = new int [9];

FillArray(array);
PrintArray(array);