void FillArray(int[]collection);
{
    int length = collection.length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

int [] array = new int [10];