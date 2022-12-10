/* Задача 64: Задайте значение N. Напишите программу, которая
 выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void ShowNumbers (int n)
{
    Console.Write (n+ " ");
    if (n>1) ShowNumbers(n-1); 
}

Console.Write ("\n  Задайте значение N: ");
int numb = Convert.ToInt32 (Console.ReadLine ());
ShowNumbers (numb);



 Задача: Написать рекурсивную функцию 
 перевода из десятичной системы исчисления в двоичную



Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N. 
int CalculateSumm(int m, int n)
    {
        int first = m;
        int last = n;
        if(m > n)
        {
            (m, n) = (n, m);
            first = n;
            last = m;
        }
        if (first <= last) return CalculateSumm(first+1, last) + first;
        else return 0;
    }

Console.Write ("\n  Введите число m: ");
        int m1 = Convert.ToInt32 (Console.ReadLine ());
        Console.Write ("\n  Введите число n: ");
        int n1 = Convert.ToInt32 (Console.ReadLine ());
        Console.WriteLine($"\n Сумма чисел равна->{CalculateSumm(m1, n1)}");


Задача: Написать рекурсивную функцию 
 перевода из десятичной системы исчисления в двоичную*/


string BinarSystem (int num)
    {
        if (num == 0) 
            return "";
        return BinarSystem(num/2) + (num%2).ToString();
        
    }

Console.WriteLine ("Введите  число: ");
int number = Convert. ToInt32(Console.ReadLine());
string res = BinarSystem (number);
Console.WriteLine ($"Ваше  число {number} в бинарной системе  ->   {res}: ");

