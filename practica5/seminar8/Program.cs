// задайте двумерный массив. Напишите программу, которая 
//поменяет любые две строки массива. 
/*
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

int [,] ChangeArrayRows( int[,] array1)
{
   Console.Write ("\n Введите  номер первой строки для перестановки:  ");
   int row1 = Convert.ToInt32 (Console.ReadLine ());
   Console.Write ("\n Введите  номер 2 строки для перестановки:  ");
   int row2 = Convert.ToInt32 (Console.ReadLine ());
   
    if (row1>=0 && row1< array1.GetLength(0)&& row2>=0 && row2< array1.GetLength(0) && row1 !=row2)
    {
        for (int j=0; j<array1.GetLength(0); j++)
        {
            int temp = array1[row1,j];
            array1 [row1,j] = array1 [row2,j];
            array1 [row2,j] = temp;
        }
        return array1;
    }
    else 
    {
        Console.WriteLine ("Неправильное введение");
        ChangeArrayRows(array1);
        return array1;
    }
}


Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());
Console.Write("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());




int[,] createdArray = Create2dArray (rows,colums , min, max );
Show2Array (createdArray);
Show2Array (ChangeArrayRows(createdArray));



// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя. 


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
void ChangeArray(int [,]array2)
{
    if (array2.GetLength(0)<=0 || array2.GetLength(1) <=0)
    {
        Console.WriteLine(" Это должна быть матрица");
    }
    else
    {
        int [,]array3=new int [array2.GetLength(1), array2.GetLength(0)];
        for (int i= 0; i< array2.GetLength(0); i++ )
        for (int j=0; j<array2.GetLength(1); j++)
        {
            array3[j,i]=array2[i,j];
        }
        Show2Array (array3);

    }
}
Console.Write ("\n Введите  количество строчек:  ");
int rows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("\n Введите  количество столбцов:  ");
int colums = Convert.ToInt32 (Console.ReadLine ());
Console.Write("\n Введите  минимальное значение:  ");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write("\n Введите  максимальное значение:  ");
int max = Convert.ToInt32 (Console.ReadLine ());


int[,] newMatrix = Create2dArray (rows,colums , min, max );
Show2Array (newMatrix);
ChangeArray(newMatrix);



// Задайте двумерный массив из целых чисел. Напишите программу, 
которая обнулит строку и столбец,  
на пересечении которых расположен первый наименьший элемент массива.*/

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

int []GetMinIndex(int [,]inArray)
{
    int iMin=0;
    int jMin=0;
    for (int i=0; i< inArray.GetLength(0); i++)
    for (int j =0; j< inArray.GetLength(1); j++)
    {
        if (inArray[i,j]< inArray[iMin, jMin])
        {
            iMin =i;
            jMin =j;
        }
    }
    return new [] {iMin, jMin};

}
void GetZero (int [,] arrayStart, int [] minInd)
{
for (int i =0; i< arrayStart.GetLength(0); i++)
{
    arrayStart [i,minInd[1]]=0;
    for (int j=0; j< arrayStart.GetLength(1); j++)
    arrayStart [minInd[0], j]=0;
}
Show2Array (arrayStart);
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
Show2Array (firstArray);
int [] minIndexArray= GetMinIndex(firstArray);
GetZero (firstArray, minIndexArray);