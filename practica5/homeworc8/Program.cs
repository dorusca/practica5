/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.



int [,] Create2dArray (int row, int column, int minVal, int maxVal)
{
int [,] create2Array= new int [row,column];
for (int i =0; i< row; i++)
     for (int j =0; j < column; j++){
     create2Array [i,j] = new Random().Next (minVal, maxVal + 1) ;
     }
 return create2Array;
}
void ShowArray (int [,] array)
{
 for (int i= 0; i< array.GetLength(0); i++ )
 {
    for (int j=0; j<array.GetLength(1); j++){
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }
Console.WriteLine(); //отступ от массива
} 

void  OrderArrayLines(int[,] array1)
{

  for (int i= 0; i< array1.GetLength(0); i++ )
    for (int count = 0; count < array1.GetLength(0); count++ )
      for (int j=0; j<array1.GetLength(1)-1; j++)
            
        if (array1[i, j] < array1[i, j+1])
        {
          int temp = array1[i, j +1];
          array1[i, j + 1] = array1[i, j];
          array1[i, j] = temp;
        }
        
    
}
void Show2Array (int [,] newArray)
{
Console.WriteLine ("\n Новый массив:  ");
 for (int i= 0; i< newArray.GetLength(0); i++ )
 {
    for (int j=0; j<newArray.GetLength(0); j++){
        Console.Write(newArray[i,j] + " "); //вывод значения
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

int [,]firstArray= Create2dArray (rows,colums , min, max );
ShowArray (firstArray);
OrderArrayLines(firstArray);
Show2Array(firstArray);




Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
 с наименьшей суммой элементов: 1 строка 

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

int [] RowSumm (int [,] array1)
{  
    int [] rowSum= new int [array1.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)
   
    {
     int summ = 0;
          for (int j = 0; j < array1.GetLength(1); j++)
        {
        summ += array1[i,j]; 
        }
        rowSum [i]= summ;
    } 

    return rowSum;  
}  
    
void ShowArray (int []array)
{
    for (int i=0; i < array.Length; i++)
         Console.Write (array[i] + " ");
}
int MinValue(int[] array)
{
    int min = 0;
    for(int i=1; i<array.Length; i++){
        if(array[i]<array[min]) 
            min = i;
    }
    return min;
   
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
int [] array1d= RowSumm (array2d);
Console.Write ($"\n Суммы элементов в каждой строке:    " );
ShowArray (array1d); 
int minValue = MinValue (array1d);

Console.Write ($"\n Cтрока с наименьшей суммой элементов: {minValue +1 }" );


Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


*/
void CreateSpiralArray (int row, int column)
{
int [,] array2 = new int [row, column];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= array2.GetLength(0) * array2.GetLength(1)) // узнаем количество индексов
{
  array2[i, j] = temp;//  [0,0]=1
  temp++;
  if (i <= j + 1 && i + j < array2.GetLength(1) - 1)
    j++;     // array[i,j] = [0,1]=2; [0,2]= 3; [0,3] =4  ///  2 виток спирали: [1,1]=13; [1,2] =14
  else if (i < j && i + j >= array2.GetLength(0) - 1)
    i++;  // [1,3]=5; [2,3] =6; [3,3]=7                   /// [2,2] =15;
  else if (i >= j && i + j > array2.GetLength(1) - 1)
    j--; //  [3,2]=8; [3,1] =9; [3,0]=10                 /// [2,1] =16; 16 =16 -> конец спирали
  else
    i--; // [2,0] =11; [1,0]=12;  /// конец первого витка спирали
}
WriteArray(array2);
}
void WriteArray (int[,] array2)
{
  for (int i = 0; i < array2.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
      if (array2[i,j] / 10 <= 0)    // ??????  чтобы выравнить столбцы ?????
      Console.Write($" {array2[i,j]} ");

      else Console.Write($"{array2[i,j]} ");
    
    Console.WriteLine();
  }
}
Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());
CreateSpiralArray (rows,colums);

