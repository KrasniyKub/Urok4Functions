// Программа которая принимает на вход цифру и выдает сумму его чисел
int GetNum()
{
    Console.Write("Введите число/ ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int NumbersSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number%10;
        number = number / 10;
    }
    return sum;
}

int Num = GetNum();
Console.WriteLine(NumbersSum(Num));