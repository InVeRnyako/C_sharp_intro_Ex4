// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16
// Примечание преподавателя: Без Math

Console.WriteLine("Возведение числа А в степень B.");

int A = GetIntFromUser("Введите число A: ");
int B = GetIntNatFromUser("Введите натуральное число B: ");

Console.WriteLine($"{A}, {B} -> {PseudoPow(A,B)}");

static int PseudoPow(int A, int B)
{
    int res = A;
    for(int i=1; i < B; i++)
    {
        res *= A;
    }
    return res;
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

static int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}