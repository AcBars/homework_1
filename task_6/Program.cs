//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

using static System.Console;
Clear();
WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());
if (Math.Abs(number%2)>0) WriteLine("Число нечетное");
else WriteLine("Число четное");