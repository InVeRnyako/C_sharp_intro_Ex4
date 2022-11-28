// задача 27: напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12

Console.WriteLine("Сумма цифр в числе.");
int num = GetIntFromUser("Введите целое число: ");

Console.WriteLine($"{num} -> {SumOfDigitInNum(num)}");

static int SumOfDigitInNum(int inputNum)
{
    int res = 0;
    inputNum = IgnoreNegativeNumber(inputNum);
    for (int i = 1; i <= NumLength(inputNum); i++)
    {
        res += DigitAtPossitionNumber(inputNum, i);
    }
    return res;
}

static int NumLength(int numLengthInput)
{
    int i = 0;
    do 
    {
        i++;
        numLengthInput = numLengthInput / 10;
    }
    while(numLengthInput != 0);
    
    return i;
}

static int DigitAtPossitionNumber(int inputNumb, int lfNumPos)
{
    inputNumb = IgnoreNegativeNumber(inputNumb);
    if (lfNumPos > NumLength(inputNumb))
        return -1;
    else 
        return inputNumb / Convert.ToInt32(Math.Pow(10, NumLength(inputNumb) - lfNumPos)) % 10;
}

static int GetIntFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        
        Console.WriteLine("Ошибка ввода!");
    }
}

static int IgnoreNegativeNumber(int inNum)
{
    if (inNum < 0) inNum *= -1;
    return inNum;
}