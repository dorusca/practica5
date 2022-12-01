/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  

int [] CreatNewArray (int size)
{
int []array = new int [size];
for (int i =0; i< size; i++)
{
Console.Write($"\n Введите элементы массива под индексом {i}: "); 
array [i] =  Convert.ToInt32(Console.ReadLine());
}
return array;
}
void ShowArray (int [] array)
{
Console.Write ("\n Вывод массива: ");
for (int i =0; i<= array.Length; i++){
   Console.WriteLine ($"\n {array [i] + " " }  ");
}
}
int  СheckNumb (int [] array)
{
int count = 0;
for (int i=0; i < array.Length; i++)
if (array [i] > 0) 
{
count ++;
}
return count;
}

Console.Write("Введите число элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int []array1 = CreatNewArray (numbers);

int  check  = СheckNumb(array1);
Console.WriteLine ($"\n Количество чисел больше нуля -> {check}: "); 
ShowArray (array1);



Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// даны две прямые: y = k1 * x + b1;
                    y = k2 * x + b2; 

так как в левой части значения равны, значит правые части можно приравнять. 
Преобразуем уравнение:
k1 * x + b1= k2 * x + b2
дальше решаем: все неизвестные переносим в левую сторону
(знаки меняются при переносе), все известные  - в правую.
(k1 * x) - (k2 * x) =b2 -b1
x(k1 - k2) = b2 -b1
x= (b2 -b1) /(k1 - k2)
значение для х которое получим, заменим в одном из уравнений, которые были даны.
Если k1 = k2, то прямые паралельны , значит программа не запустится.

*/

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
if (k1!=k2) 
{
double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1; 
Console.WriteLine ($"\n Координаты точки пересечения двух прямых: -> ({x};{y}) ");
}
else 
Console.WriteLine ("\n прямые паралельны ");

}

Console.WriteLine ("\n Введите  координаты для b1:  ");
double ab1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите  координаты для k1:  ");
double ak1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите  координаты для b2:  ");
double ab2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите  координаты для k2:  ");
double ak2 = Convert.ToInt32 (Console.ReadLine ());
IntersectionPoint (ab1, ak1, ab2 ,ak2);