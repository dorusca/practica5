/* Домашняя работа


Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

int [] NewArray (int size)
{
int [] array = new int [size];
for (int i =0; i < size; i++)
array [i] = new Random (). Next (100,1000);
return array;
}
void ShowArray (int [] array)
{
    for (int i =0; i< array.Length; i++)
    Console.Write (array [i] + "  "); 
}

int CountElement (int [] array)
{
    int count =0;
    for (int i=0; i < array.Length; i++)
    if (array [i] % 2==0)
        count++;
    return count;
}

Console.Write ("Введите колличество элементов: ");
int count_elem = Convert.ToInt32 (Console.ReadLine ());

int [] array1 = NewArray(count_elem);
ShowArray (array1);
int  elem = CountElement (array1);
Console.Write ($"колличество четных элементов в массиве -> {elem} ");


Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 



int [] NewArray (int size)
{
int [] array = new int [size];
for (int i =0; i < size; i++)
array [i] = new Random (). Next (1,1000);
return array;
}
void ShowArray (int [] array)
{
    for (int i =0; i< array.Length; i++)
    Console.Write (array [i] + "  "); 
}

int SumOddIndex (int [] array)
{
    int sumIndex=0;
for (int i =0; i< array.Length; i++)
if ( i %2 !=0)
    sumIndex += array [i];
return sumIndex;
}
Console.Write ("Введите колличество элементов: ");
int count_elem = Convert.ToInt32 (Console.ReadLine ());

int [] array1 = NewArray(count_elem);
ShowArray (array1);
int  elem = SumOddIndex (array1);
Console.Write ($"Сумма  элементов , стоящих на нечётных позициях  -> {elem} "); 


Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//Создаем новый массив, используем генератор случайных дробных чисел,
double[] NewArray (int size)
{
    double[] array = new double [size];
    var rand = new Random();
    for (int i =0; i < size; i++){
        array[i] = Math.Round(rand.NextDouble()*10000,2);
        //умножаем на 10000 - чтобы числа были от 0 до 10000
    }
    return array;
}
//Выведем на экран наш сгенерированный массив
void ShowArray (double[] array)
{
    for (int i =0; i< array.Length; i++)
        Console.Write (array [i] + "  "); 
        //  "\n" для перевода на другую строчку, чтобы красиво выводилось
        // в следующую строчку
    Console.Write ("\n");
}

// Находим индекс максимального элемента
int MaxValue(double[] array){
    int max = 0;
    for(int i=1; i<array.Length; i++){
        if(array[i]>array[max]) 
            max = i;
    }
    return max;
}
//Аналогично для минимального
int MinValue(double[] array){
    int min = 0;
    for(int i=1; i<array.Length; i++){
        if(array[i]<array[min]) 
            min = i;
    }
    return min;
}
    Console.Write("Введите колличество элементов: ");
    int count_elem = Convert.ToInt32 (Console.ReadLine ());

    double[] array1 = NewArray(count_elem);
    ShowArray(array1);
    int max = MaxValue(array1);
    int min = MinValue(array1);
    double result = array1[max] - array1[min];
    Console.Write($"максимальное число {array1[max]}, минимальное число {array1[min]}\n");
    Console.Write($"разница между максимальным и минимальным числом {result:f2}");
