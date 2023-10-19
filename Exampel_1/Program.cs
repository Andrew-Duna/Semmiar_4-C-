// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int number1 = ReadInt("Введиете первое число");
int number2 = ReadInt("Введиете второе число");
int result = 1;
for (int i = 0; i < number2; i++)
{
    result = result * number1;
}
System.Console.WriteLine(result);