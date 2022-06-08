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



int N, current;

Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

while(N - 1 == 0)
{
    N = N - 1;
    Console.WriteLine(" N ");
}
current = N / 2;
current ++;
