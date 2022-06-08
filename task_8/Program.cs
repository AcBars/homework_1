// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using static System.Console;
Clear();
WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());
for (int count=2; count<=number; count=count+2)
{
    WriteLine(count);
}