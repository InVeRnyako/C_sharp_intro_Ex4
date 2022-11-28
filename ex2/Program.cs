// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = GenerateArrayWithNumbers(8, 0, 100);
Console.WriteLine($"{ArrayToString(array)} -> [{ArrayToString(array)}]");

static int[] GenerateArrayWithNumbers(int arraySize, int lowLimit, int highLimitIncluded)
{
    Random random = new Random();
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.Next(lowLimit, highLimitIncluded + 1);
    }
    return array;
}

static string ArrayToString(int[] array)
{
    // 0, 1, 2, 3
    string result = $"{array[0]}";
    for (int i = 1; i < array.Length; i++)
    {
        result = result + $", {array[i]}";
    }
    return result;
}
