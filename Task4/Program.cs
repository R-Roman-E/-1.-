// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите 3 произвольных числа");
string NumberA = Console.ReadLine ();
string NumberB = Console.ReadLine ();
string NumberC = Console.ReadLine ();
int Number1 = Convert.ToInt32 (NumberA);
int Number2 = Convert.ToInt32 (NumberB);
int Number3 = Convert.ToInt32 (NumberC);
int max = Number1;
if (Number1>max) max = Number1;
if (Number2>max) max = Number2;
if (Number3>max) max = Number3;
Console.WriteLine ($"Максимальным числом является {max}");