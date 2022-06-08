// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using static System.Console;
Clear();
WriteLine("Введите первое число");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int number2 = Convert.ToInt32(ReadLine());
if (number1>number2) 
{
    WriteLine("Первое число больше второго");
    Write("max=");
    Write(number1);
}
else if (number1<number2)
{
    WriteLine("Второе число больше первого");
    Write("max=");
    Write(number2);
}
else WriteLine("Первое и второе числа равны");