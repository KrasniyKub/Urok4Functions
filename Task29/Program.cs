// Программа которая задает массив из 8-ми чисел и выводит их на экран.
int[] CreateArray(int arrayLength, int max, int min)
{
    int[] arrayA = new int[arrayLength];
    Random rand = new Random();
    for(int i = 0; i < arrayA.Length; i++)
    {
        arrayA[i] = rand.Next(min, max);
    }
    return arrayA;
}
int[] array = CreateArray(8, 100, 0);
int Length = array.Length;

for(int i = 0; i < Length; i++)
{
    Console.WriteLine(array[i]);
}