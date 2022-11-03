// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите два числа");
string NumberA = Console.ReadLine();
string NumberB = Console.ReadLine();
int Number1 = int.Parse(NumberA);
int Number2 = int.Parse(NumberB);
if(Number1>Number2)
{
    Console.WriteLine ($"Число {Number1} больше числа {Number2}");
}    
else
{
    Console.WriteLine ($"Число {Number1} меньше числа {Number2}");
} 

