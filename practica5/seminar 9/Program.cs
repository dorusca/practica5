// задайте значение N. Напишите программу 
//которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNumbers (int n)
{
    if (n>1) ShowNumbers(n-1); // номер должен быть на 1 < чем изначально, иначе программа вылетет
    Console.Write (n+ " ");
}

Console.Write ("\n  Задайте значение N: ");
int numb = Convert.ToInt32 (Console.ReadLine ());
ShowNumbers (numb); 

//задайте значение N. Напишите программу 
//которая выведет все натуральные числа в промежутке от 1 до N ( в обратном порядке).

void ShowNumbers (int n)
{
    Console.Write (n+ " ");
    if (n>1) ShowNumbers(n-1); 
}

Console.Write ("\n  Задайте значение N: ");
int numb = Convert.ToInt32 (Console.ReadLine ());
ShowNumbers (numb);





//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumDIgits (int n)
{
    if (n<0) n*=(-1);
    if (n>0) return SumDIgits(n/10)+n%10;
    else return 0;
}
Console.Write ("\n  Введите число: ");
int numb = Convert.ToInt32 (Console.ReadLine ());
int result = SumDIgits (numb);
Console.Write (result);


//Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. // N < M, N = M, M < N
void ShowNumbersNM (int n, int m)
{
    if(Math.Max(n,m)!= Math.Min(n,m)) ShowNumbersNM(Math.Max(n,m), Math.Min(n,m)+1); //+1 чтобы результат был по наростающей
    //ShowNumbersNM(Math.Max(n,m)-1, Math.Min(n,m)) чтобы результат был по уменьшающей
    Console.Write ($"{Math.Min(n,m)}  ");
}
Console.Write ("\n  Введите число n: ");
int n1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n  Введите число m: ");
int m1 = Convert.ToInt32 (Console.ReadLine ());
ShowNumbersNM(n1,m1);




//Напишите программу, которая на вход принимает два числа A и B,  
//и возводит число А в степень B с помощью рекурсии.*/
double APowB (int a, int b)
{
    if (b>0) return APowB (a,b-1) *a ;
    if (b<0) return APowB (a,b+1) /a;
    return 1;  // если b=0
}
Console.Write ("\n  Введите число a: ");
int n1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n  Введите число b: ");
int m1 = Convert.ToInt32 (Console.ReadLine ());

double res = APowB (n1,m1);
Console.Write ($"\n число {n1} в {m1}  степени  равна-> {res}");
