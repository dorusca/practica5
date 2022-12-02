// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
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
    for (int j=0; j<array.GetLength(0); j++)
    {
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }

Console.WriteLine(); //отступ от массива

} 
Console.WriteLine ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());

int [,] newArray = Create2Array (rows,colums , min, max );

Show2Array (newArray);


// Задайте двумерный массив размером m×n, заполненный  числами пользователя.

int [,] Create2Array (int row, int column)
{
int [ , ] create2Array= new int [row,column];

for (int i =0; i< row; i++)
     for (int j =0; j < column; j++)
     {
        Console.Write($" Введите елемент [{i+1}, {j+1}] в массиве  ->  ");
        create2Array [i,j] = Convert.ToInt32(Console.ReadLine());
     }

return create2Array;
}
void Show2Array (int [,] array)
{
 for (int i= 0; i< array.GetLength(0); i++ )
 {
    for (int j=0; j<array.GetLength(0); j++)
    {
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }

Console.WriteLine(); //отступ от массива

} 
Console.WriteLine ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());


int [,] newArray = Create2Array (rows,colums );

Show2Array (newArray);



Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


int [,] Created2dArray ( int row, int column)
{
    int [,] created2dArray =new int [row , column];
    for( int i =0; i< row; i++)
       for (int j=0; j< column; j++)
            created2dArray [i,j] = i + j;
    return created2dArray;
}
void Show2dArray (int [,] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Show2dArray (Created2dArray (5,6)); // вводим произвольно цифры 

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//и замените эти элементы на их квадраты.


int [,] Create2dArray (int row, int column, int minVal, int maxVal)
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
    for (int j=0; j<array.GetLength(0); j++)
    {
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }

Console.WriteLine(); //отступ от массива

} 

int [,] EvenNumbers (int [,] array)
{
  for (int i=0; i<array.GetLength (0); i++)
  {
    for (int j=0; j<array.GetLength (1); j++)
    {
        if ( i % 2 ==0 && j % 2==0)
        {
            array[i,j]=array [i,j] *array [i,j]; 
        }
    }
  }
   return array;
}

Console.WriteLine ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());

int [,] newArray = Create2dArray (rows,colums , min, max );

Show2Array (newArray);
EvenNumbers (newArray);
Show2Array (newArray);

Найти сумму элементов главной диагонали*/

int [,] Create2dArray (int row, int column, int minVal, int maxVal)
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
    for (int j=0; j<array.GetLength(0); j++)
    {
        Console.Write(array[i,j] + " "); //вывод значения
    }
    Console.WriteLine(); //переход на новую строку
 }

Console.WriteLine(); //отступ от массива

} 
int SumNumber (int [,] array)
{
    int sum =0;
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j< array.GetLength(1); j++ )
        {
            if(i==j)
            {
                sum= sum+array[i,j];
            }
        }
    }
    return sum;
}

Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n Введите  минимальное значение: ");
int min = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("\n Введите  максимальное значение: ");
int max = Convert.ToInt32 (Console.ReadLine ());

int [,] newArray = Create2dArray (rows,colums , min, max );

Show2Array (newArray);
int sum= SumNumber (newArray);
Console.WriteLine($" \n Сумма элементов главной диагонали  -> {sum}");
