// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12м
int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number1 = ReadInt("Введиете число");
int result = 0;
while (number1 > 0)
{
    result += number1 % 10;
    number1 /= 10;
}
System.Console.WriteLine(result);
