/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8" */

/* int Rec(int n, int m)
{
    if (n == m)
    {
        
        return 1;
    }
    Console.Write(" " + n);


    return Rec(n - 1, m);
}

int M = 5, N = 1;
Console.WriteLine(" "  + Rec(M,N));
 */

////////////////////////////////////////////////


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
N = 1; M = 15 -> 120
N = 4; M = 8. -> 30 */

/* int Rec(int n, int m)
{

   if (n < m )
   {
       return 0;
   }

   Rec((n - 1), m);
   return  Rec((n - 1), m)+ n;
}
int M = 15; int N = 1;



Console.WriteLine(Rec(M,N)); */


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

int N = 3;
int M = 2;
int RecAkr(int n, int m)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return RecAkr(m - 1, n);
    }
    else
    {
        return RecAkr(m - 1, RecAkr(m - 1, n));
    }
    return RecAkr(M, N);
}

Console.WriteLine(RecAkr(M, N));    /// не понимаю где тут ошибка 