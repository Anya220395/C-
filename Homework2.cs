/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Нужно сделать через числа, без индексов строк.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Digit = num / 10;
int secondDigit = Digit % 10;

if (num >=100 || num <= 999) Console.WriteLine($"Вторая цифра в данном числе: {secondDigit} ");

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int thirdDigit = num % 10;

if (num >99 || num <1000  ) Console.WriteLine($"Третья цифра в данном числе: {thirdDigit} "); // упорно не поняла как все-таки сделать для чисел >999
if (num <100) Console.WriteLine(" Третьей цифры нет ");


/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число дня недели: ");
int NameOfDay = Convert.ToInt32(Console.ReadLine());

if (NameOfDay == 7 || NameOfDay == 6) Console.WriteLine(" Выходной ");
else Console.WriteLine("День не является выходным"); 


