// напишите программу , которая перевернет одномерный массив 
//(последний элемент будет на первом месте , а первый на последнем и.т.д)

/*int [] CreatNewArray (int size, int min, int max)
{
int []array = new int [size];
for (int i =0; i< size; i++)
{
array[i] = new Random().Next (min, max+1);
}
return array;
}
void ShowNewArray (int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
}
int [] ReverseArray (int [] array)
{
    int k = array.Length;
    for (int i=0; i<k / 2; i++)
    {
        int temp = array[i];
        array [i]= array [k-1-i];
        array [k-1-i] = temp;
    }
    return array;
}
Console.WriteLine ("Введите размер массива: ");
int count_elem = Convert. ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное значение элементов: ");
int min_value = Convert. ToInt32(Console.ReadLine());

Console.WriteLine ("Введите максимальное значение элементов: ");
int max_value = Convert. ToInt32(Console.ReadLine());

int [] new_array = CreatNewArray (count_elem, min_value,max_value);
ShowNewArray (new_array);
Console.WriteLine (); 
int [] revers_array = ReverseArray(new_array);
ShowNewArray (revers_array);


Задача 2
не используя рекурсию, выведите первые N чисел Фибоначи.
Первые числа а и в, задает пользователь.

void Fibonachi (int count, int a, int b)
{
    int [] fibArray = new int [count];
    fibArray [0]=a;
    fibArray [1]=b;
    for (int i=2; i< count; i++)
    fibArray [i] = fibArray[i-1]+ fibArray [i-2]; //формула Фибоначи
    ShowArray (fibArray); //вызвали следуйщий метод, кот. показывает массив.
}
void ShowArray (int []array)
{
    for (int i =0; i<array.Length; i++)
    Console.Write(array [i] + " ");
}
 Console.WriteLine ("Введите размер массива: ");
int count_elem = Convert. ToInt32(Console.ReadLine());

Console.WriteLine ("Введите первый элемент: ");
int first_value = Convert. ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второй элемент: ");
int second_value = Convert. ToInt32(Console.ReadLine());
Fibonachi (count_elem,first_value, second_value );




Задача 3
//Напишите программу, которая принимает на вход три числа и проверяет,  
//может ли существовать треугольник с сторонами такой длины. 
// каждая сторона треугольника меньше суммы двух других сторон.

bool Triangle (int side1, int side2, int side3)
{
    if (side1 +side2>side3 && side2+side3>side1 && side3+side1> side2)
    return true;
    else return false;
}
Console.WriteLine ("Введите первое число: ");
int first_side = Convert. ToInt32(Console.ReadLine());

Console.WriteLine ("Введите 2-ое число: ");
int second_side = Convert. ToInt32(Console.ReadLine());

Console.WriteLine ("Введите 3-е число: ");
int third_side = Convert. ToInt32(Console.ReadLine());

bool result = Triangle (first_side, second_side,third_side);
if (result ==true)
Console.WriteLine ("Триугольник существует ");
else Console.WriteLine ("Триугольник  не существует ");

Задача 4
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
 //45 -> 101101 //3  -> 11

string BinarSystem (int num)
{
    string binResult = string.Empty;
    while (num !=0)
    {
        binResult = num % 2 + binResult;
        num/=2;
    }
    return binResult ;
}
Console.WriteLine ("Введите  число: ");
int number = Convert. ToInt32(Console.ReadLine());
string res = BinarSystem (number);
Console.WriteLine ($"Ваше  число {number} в бинарной системе  ->   {res}: "); 


Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double [] CreateArray (int size) 
{
double [] newArr = new double[size];
for (int i =0; i < size; i++)
{
    newArr [i] = new Random().Next (1,1000) + new Random().NextDouble();
    newArr [i]= Math.Round( newArr [i],2);
}
     return newArr;
}
void ShowArray (double [] array)
{
    for (int i =0; i< array.Length; i++)
    Console.Write ($"{array [i]} "); 
    Console.WriteLine();
}
double DifNum (double []array)
{
  double res = 0;
  double min= array[0];
  double max = array[0];
  for (int i = 0; i< array.Length; i++)
  {
    if (array [i]>max)  max= array[i];
    if(array [i] < min) min = array [i];
  res = max - min;
  }
  return res;

}

Console.WriteLine ("Введите  число: ");
int array_new = Convert.ToInt32 (Console.ReadLine ());

double [] arrayCreat = CreateArray (array_new);
ShowArray (arrayCreat);
double dif = DifNum (arrayCreat);
Console.WriteLine ($" Разница между максимальным и минимальным элементами массива  -> {dif:f2}");