/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double [,] Create2Array (int row, int column, int minVal, int maxVal)
{
double [,] create2Array= new double [row,column];

for (int i =0; i< row; i++)
     for (int j =0; j < column; j++)
     {
     create2Array [i,j] = new Random().Next (minVal, maxVal + 1) + new Random().NextDouble();
     create2Array [i,j] = Math.Round(create2Array [i,j], 2);
     
     }
 return create2Array;
}
void Show2Array (double [,] array)
{
 for (int i= 0; i< array.GetLength(0); i++ )
 {
    for (int j=0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }

Console.WriteLine(); //отступ от массива

} 
Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());

Console.Write("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());

Console.Write("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());

double [,] newArray = Create2Array (rows,colums , min, max );

Show2Array (newArray);


Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

int [,] Create2Array (int row, int column, int minVal, int maxVal)
{
int [ , ] create2Array= new int [row,column];

for (int i =0; i< row; i++)
     for (int j =0; j < column; j++)
     create2Array [i,j] =new Random().Next(minVal,maxVal+1);
return create2Array;
}
void Show2Array (int [,] array)
{
 for (int i= 0; i< array.GetLength(0); i++ )
 {
    for (int j=0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }

Console.WriteLine(); //отступ от массива

} 

void  Show2dNumbers (int [,] array)
{
        Console.Write ("\n Введите  индекс строки:  ");
        int rows1 = Convert.ToInt32 (Console.ReadLine ());
        Console.Write ("\n Введите  индекс столбца:  ");
        int column1 = Convert.ToInt32 (Console.ReadLine ());
    
        if ( rows1 < array.GetLength (0) && column1 <array.GetLength (1))
        {
        Console. Write ($"\n значение этого элемента: {array [rows1,column1]} ");
        }
        else Console. Write ("\n  Числа  с такими индексами  нет в массиве.");
    
}
   

Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());

Console.Write("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());

int [,] newArray = Create2Array (rows,colums , min, max );

Show2Array (newArray);

Show2dNumbers (newArray);



Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] Create2dArray (int row, int column, int minVal, int maxVal)
{
int [,] create2Array= new int [row,column];
for (int i =0; i< row; i++)
     for (int j =0; j < column; j++){
     create2Array [i,j] = new Random().Next (minVal, maxVal + 1) ;
     }
 return create2Array;
}
void Show2Array (int [,] array)
{
 for (int i= 0; i< array.GetLength(0); i++ )
 {
    for (int j=0; j<array.GetLength(0); j++){
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }
Console.WriteLine(); //отступ от массива
} 

double [] AvgColumn (int [,] array1)
{  
    double [] avgSum= new double [array1.GetLength(1)];
    for (int j = 0; j < array1.GetLength(1); j++)
    {
     double summ = 0;
         for (int i = 0; i < array1.GetLength(0); i++)
        {
        summ += array1[i,j]; 
        }
        avgSum[j] = Math.Round (summ/array1.GetLength (0),2); 
    } 
    return avgSum;  
}  
    
void ShowArray (double []array)
{
    for (int i=0; i < array.Length; i++)
         Console.Write (array[i] + " ");
}

 
Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());
Console.Write("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());

int[,] array2d = Create2dArray (rows,colums , min, max );
Show2Array (array2d);
double [] array1d= AvgColumn (array2d);
ShowArray (array1d);
