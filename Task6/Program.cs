﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите произвольное число");
string Number = Console.ReadLine ();
int NumberI = int.Parse (Number);
if(NumberI%2 == 0)
{
    Console.WriteLine ($"Число {NumberI} является четным");
}    
else
{
    Console.WriteLine ($"Число {NumberI} является нечетным");
} 