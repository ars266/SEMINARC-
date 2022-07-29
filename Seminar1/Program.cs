/*
int num, result;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

result = num * num;

Console.WriteLine("Result is " + result);
*/



/* DZ*/

/*
int num1, num2;

Console.WriteLine("Введите число: ");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine("Максимальное число: " + num2);
}
else
{
    Console.WriteLine("Максимальное число: " + num1);
}

*/



/*
int num1, num2, num3, max;

Console.WriteLine("Введите поочерёдно три числа: ");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;
if(num1 < num2) max = num2;
if(num2 < num3) max = num3;

Console.WriteLine("Максимальное число: " + max);
*/

/*
int num, current;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
current = num / 2;
current ++;

if(current == 1) Console.WriteLine("Нечетное число: ");
else
{
   Console.WriteLine("Четное число: "); 
}
*/



/*int N, current;

Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

while(N - 1 == 0)
{
    N = N - 1;
    Console.WriteLine(" N ");
}
current = N / 2;
current ++;
*/





/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 2*/

/*
int CutNumer()
{
    int num = new Random().Next(100,999);
Console.WriteLine($"Выбранное число {num}");

int sot = num / 10;
int result = sot % 10;
return result;
}
*/



/*
int CutNotFhree ()
{
    int num, result;
    Console.WriteLine("Введите любое целое число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 100) Console.WriteLine("Третья цифра отсутствует");
    if (num > 100);
    result = num / 10;
    return result;
}
*/


/*
int WeekDays ()
{
    int num, result;
    Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num >= 6)
    {
    return True;
    }
    else
    {
    return False;
    }

}
*/


/*ДЗ к СЕМИНАРУ 

1 ЗАДАЧА:
*/

/*
int FindPolindrom ()
{
    int num;
    Console.WriteLine ("Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    
    int num5 = num % 10;
    int num4 = num % 100;
    int num2 = num % 1000;
    int num1 = num % 10000;

        if(num1 == num5 && num2 == num4)
        {
        Console.WriteLine("True");
        }
         else
        {
        Console.WriteLine("False");
        }
}
FindPolindrom(num);
*/

/*2 ЗАДАЧА:
*/

/*
double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
    Convert.ToDouble()
    return Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2);
}
*/

/*3 ЗАДАЧА:
*/

/*
void Cube(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write((current * current * current) + " ");
        current++;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/

/*
ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 4

ЗАДАЧА 1:

int Stepen (int a, int b);
int current = 1; current ++;
while (current <= b)
{
Console.WriteLine(a * a);
}

Думаю, задача решена неверно
*/


/*
ЗАДАЧА 2:

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i = i + 1)
{
    array[i] = new Random().Next(0,1000);
}
for (int i = 0; i < size; i = i + 1)
{
    Console.WriteLine(array[i] + " ");
}
*/








/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 5
*/
/*ЗАДАЧА 1:*/

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++)
    {
        newArray[i] = new Random().Next(min = 100, max = 1000);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindCountEvenSum(int[] array,int min, int max)
{
    int count = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count ++;
    }
    return count;
}
*/

/*ЗАДАЧА 2:*/

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindSumNotEvenNum(int[] array,int min, int max, int step = 2)
{
    int sum = 0;
    for( int i = 1; i < array.Length; i + step)
    {
        if(array[i] % 2 == 1) sum ++;
    }
    return sum;
}
*/

/*ЗАДАЧА 3:*/

/*double[] CreateRandomDoubleArray(int size)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i ++)
    {
        newArray[i] = new Random().NextDouble();
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindвDifMaxMin(double[] array, double min, double max, double result)
{
    double minNumber = array[i];
    double maxNumber = array[i];

    for( int i = 0; i < array.Length; i ++)
    {
        if(array[i] < minNumber)
        {
            minNumber = array[i];
        }
        if(array[i] < maxNumber)
        {
            maxNumber = array[i];
        }
        
    }
    Console.WriteLine(maxNumber);
    Console.WriteLine(minNumber);

    double maxNumber - double minNumber = result;
    return resalt;
}
*/



/*

ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 6

ЗАДАЧА 1:

int FindNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine ("Введите любое количество целых чисел: ");
int array = Convert.ToInt32(Console.ReadLine());



ЗАДАЧА 2:

int ArrayCopy(int[] FirsArray, int[] SecondArray, int size)
{
    int[] FirstArray = new int[size];
    for(int i = 0; i <size; i ++);
    int[] SecondArray = new int[size];
    for(int j = 0; j <size; j ++);
    {
        [j] == [i]; if ++; j ++;
    }
    return SecondArray;

}
*/


/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 7

ЗАДАЧА 1:
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

/*double[,] CreateTwoArray(double n, double m, double min, double max)
{
double[,] newMatrix = new double (n,m);
for(double i = 0; i < n; i++)
{
    for(double j = 0; j < m; j++)
    {
        newMatrix[i,j] = new Random().NextDouble(min, max + 1);
        Console.Write(newMatrix[i,j] + " ")
    }
    Console.WriteLine();
}
return newMatrix;
}
*/

/*
ЗАДАЧА 2:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] NewMatrix(int a, int b)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            if
            {
                [i] < a && [j] < b;
            }
            else
            {
                return Console.WriteLine (" Такого элемента нет ")
            }
        }
    Console.WriteLine();
    }
    return newMatrix;
}
*/

/*
ЗАДАЧА 3:
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArrayIntegSumСolumns(int a, int b)
{

int[,] newMatrix = new int (a,b);
 for(int i = 0; i < a; i++)
 {
    for(int j = 0; j < a; j++)
    {
      while j < b
      (for(i = 0; i < array.Get.Length; i++)) / a;
    }
 }
}

*/





/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 8*/

/*ЗАДАЧА 1:
Задайте двумерный массив. 
Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.*/

/*
int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];
 
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
        array[i,j] = new Random().Next(min, max + 1);
 
    return array;
}
 
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
int[,] BubbleSorting(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          for(int k = 0; k < array.GetLength(1)-1; k++)
          {
            if(array[i,k] < array[i,k + 1])
            {
                int temp = array[i, k+1];
                array[i,k+1] = array[i,k];
                array[i,k] = temp;
            }
        }
    }
}
return array;
}
 
int[,] myArray = CreateTwoDimArray(5,8,1,9);
ShowArray(myArray);
Console.WriteLine();
ShowArray(BubbleSorting(myArray));
*/


/* СЕМИНАР 9:*/

/*Найти все числа от 1 до n:

void ShowNums(int n)
{
    if(n !=1)
    {
        ShowNums(n-1);
    }
    Console.Write(n + " ");
}
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/


/*Вывести числа от m до n, где m - меньшее число, а n - большее.*/
/*
void ShowNums(int n, int m)
{
    if(n !=m)
    {
        ShowNums(n-1, m);
    }
    Console.Write(n + " ");
}
Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число: ");
int m = Convert.ToInt32(Console.ReadLine());

ShowNums(n, m);
*/

/*Написать программу, которая на вход будет принимать число, и будет возвращать сумму ёё цифр.*/
/*
int Sum (int num)
{
    if (num == 0)
        return 0;
    return num % 10 + Sum (num / 10);    
}

Console.Write("Введите целое максимальное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(num));
*/

/*Число А возвести в степень В*/
/*
int Degree (int A, int B)
{
    if (B!=0)
        return A * Degree(A, B-1);
    else return 1;    
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ещё одно число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(A,B));
*/


/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 9*/
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/

/*
void ShowSumNums(int n, int m)
{
    if(n !=m)
    {
        ShowSumNums(n-1, m);
    }
    Console.Write(n + " ");
    return n + ShowSumNums(n-1);
}
Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число: ");
int m = Convert.ToInt32(Console.ReadLine());

ShowSumNums(n, m);
*/


/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.*/
/*
int Quantity (int num)
{
    if (num == 0)
        return 0;
    return 1  + Quantity (num % 10);    
}

Console.Write("Введите целое максимальное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quantity(num));
*/




/*СЕМИНАР 10

string[] names = {"Invan", "Anna", "Max", "Denis"};

 Console.WriteLine(names [0][1]);
 */

/*ЗАДАЧА: Написать метод, который выводит количество строк слов из массива больше, чем 5 символов .
*/

/*
string[] names = {"Invan", "Anna", "Max", "Denis"}; //сгенерировали 

string[] CreateStringArreay (int size)
{
    string[] words = new string [size];
    for(int i = 0; i < size; i ++)
    {
        Console.WriteLine($"Input {i + 1} words: ");
        words[i] = Console.ReadLine();
    }
    return words;

}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();    
}

int NumberOfLongWords(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length >= 5)
            count++;

    return count;        
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArreay;

Console.WriteLine("Number of long words is " + NumberOfLongWords(names));
*/
/*
Задача:
Написать программу, которая на вход принимает 2 массива строк и возвращает массив из попарно объединенных исходных элементов.
*/

/*
string[] ArrayCombination(string [] array1, string [] array2)
{
    int minsize;
    if (array1.Length > array2.Length)
    {
        minsize = array2.Length;
        for(int i = 0; i < minsize; i++)
            array1[i] += array2[i];
        return array1;    
    }
    else
    {
        minsize = array1.Length;
        for(int i = 0; i < minsize; i++)
            array2[i] += array1[i];
        return array2;    
    }
}
*/

/*Задача:
Написать программу, которая считает количество слов, начинающихся на букву Y или W.
*/
/*
string[] CreateStringArreay (int size)
{
    string[] words = new string [size];
    for(int i = 0; i < size; i ++)
    {
        Console.WriteLine($"Input {i + 1} words: ");
        words[i] = Console.ReadLine();
    }
    return words;

}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();    
}

int SymbolOfWords(string[] array, char a, char b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
        if (array[i][0] == a || array[i][0] == b)
            count ++;
    return count;        
}
Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input First Symbol: ");
char a = Convert.ToChar(Console.ReadLine());
Console.Write("Input Second Symbol: ");
char b = Convert.ToChar(Console.ReadLine());
string[] names = CreateStringArreay(size);
Console.WriteLine(" " +  SymbolOfWords(names, a,b));
Console.WriteLine(names[1].ToLower());
*/



/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 10*/

/*Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1*/

/*string[] CreateStringArreay (int size)
{
    string[] words = new string [size];
    for(int i = 0; i < size; i ++)
    {
        Console.WriteLine($"Input {i + 1} words: ");
        words[i] = Console.ReadLine();
    }
    return words;

}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();    
}

int SymbolOfWords(string[] array, char a1, char a2, char a3, char a4, char a5, char a6)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
        if (array[i][0] == a1 || array[i][0] == a2 || array[i][0] == a3 || array[i][0] == a4 || array[i][0] == a5 || array[i][0] == a6)
            count ++;
    return count;        
}
Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input First Symbol: ");
char a1 = Convert.ToChar(Console.ReadLine());
Console.Write("Input Second Symbol: ");
char a2 = Convert.ToChar(Console.ReadLine());
Console.Write("Input Third Symbol: ");
char a3 = Convert.ToChar(Console.ReadLine());
Console.Write("Input Fourth Symbol: ");
char a4 = Convert.ToChar(Console.ReadLine());
Console.Write("Input Fifth Symbol: ");
char a5 = Convert.ToChar(Console.ReadLine());
Console.Write("Input Sixth Symbol: ");
char a6 = Convert.ToChar(Console.ReadLine());
string[] names = CreateStringArreay(size);
Console.WriteLine(" " +  SymbolOfWords(names, a1,a2,a3,a4,a5,a6));
Console.WriteLine(names[1].ToLower());


/*Задача 2: Задайте массив строк. Напишите программу, которая генерирует массив, объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}*/

/*string[] ArrayCombination(string [] arrayFirst, string [] arraySecond)
{
    int minsize;
    if (arrayFirst.Length > arraySecond.Length)
    {
        minsize = arraySecond.Length;
        for(int i = 0; i < minsize; i++)
            arrayFirst[i] += arraySecond[i];
        return arrayFirst;    
    }
    else
    {
        minsize = arrayFirst.Length;
        for(int i = 0; i < minsize; i++)
            arraySecond[i] += arrayFirst[i];
        return arraySecond;    
    }
}
*/
Итоговая контрольная работа.