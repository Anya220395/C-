/*Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < secondNumber) 
{
    Console.WriteLine(secondNumber +  " является max числом ");
}
else
{
    Console.WriteLine(secondNumber +  "  является min числом ");
}



/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine(number +  "  является четным числом ");
}
else
{
  Console.WriteLine(number +  "  является НЕчетным числом ");  
}

/*Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

int MaxNumber = 0;

if (Number1 > Number2)
   {
    MaxNumber = Number1;
   }
    else
   {
    MaxNumber = Number2;
   }
if ( MaxNumber > Number3 )
   {
   Console.WriteLine("Максимальное число: " + MaxNumber);
   }
   else
   {
   MaxNumber = Number3;
   Console.WriteLine("Максимальное число: " + MaxNumber);
   }
