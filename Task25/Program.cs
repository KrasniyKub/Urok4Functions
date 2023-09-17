//Программа которая принимает на вход два числа - A и B, а затем возводит A в степень B
int GetNum(string Text)
{
    Console.Write($"Введите число {Text}/ ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int AtoThePowerB(int numA, int numB)
{
    int result = numA;
    while(1 < numB)
    {
        result = result * numA;
        numB--;
    }
    return result;
}

int A = GetNum("A");
int B = GetNum("B");
Console.WriteLine(AtoThePowerB(A, B));