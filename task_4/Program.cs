//Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
using static System.Console;
Clear();
WriteLine("Введите первое число");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int number2 = Convert.ToInt32(ReadLine());
WriteLine("Введите третье число");
int number3 = Convert.ToInt32(ReadLine());
int max;
if (number1>number2) max=number1;
else max=number2;
if (max>number3)
{
    WriteLine($"Максимальное число из трех равно {max}");
   // Write(max);
}
else
{
    WriteLine($"Максимальное число из трех равно {number3}");
    //Write(max);
}