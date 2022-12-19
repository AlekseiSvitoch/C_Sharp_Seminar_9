// int sum(int n, int m)
// {
//     if (m == 0)
//         return n;
//     return sum(n + 1, m - 1);
// }

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(n, m));



// сложение рекурсией
// int sum()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x == 0)
//         return 0;
//     return sum() + x;
// }

// Console.Clear();
// Console.WriteLine(sum());


// решение через процедуру
// void sum(int res)
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     res += x;
//     if (x == 0)
//         Console.WriteLine(res);
//     if (x != 0)
//         sum(res);
// }

// int res = 0;
// Console.Clear();
// sum(res);


// сумма числа от 1 до заданного числа
// int rec(int n)
// {
//     if (n == 1)
//         return 1;
//     return rec(n - 1) + n;
// }

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));


// Task 63
// string rec(int n)
// {
//     if (n == 1)
//         return "1 ";
//     return rec(n - 1) + $"{n} ";
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

// Task 63 через процедуру
// void rec(int n)
// {
//     if (n == 1)
//         Console.Write(n + " ");
//     if (n > 1)
//     {    
//         rec(n - 1);
//         Console.Write(n + " ");
//     }
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// rec(n);

// Task 65 вывести все числа от m до n
// string rec(int m, int n)
// {
//     if (n == m)
//         return $"{m} ";
//     return rec(m, n - 1) + $"{n} ";
// }

// Console.Clear();
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(m, n));


// // Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int rec(int n)
// {
//     if (n % 10 == n || n < 10 || n / 10 == 0)
//         return n;
//     return rec(n / 10) + n % 10;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int rec(int n, int m)
// {
//     if (m == 0)
//         return 1;
//     return rec(n, m - 1) * n;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n, m));



// доп задача с перестановками
void rec(string s2, string c)
{
    string s1;
    int i;
    if (s2.Length == 0)
        Console.WriteLine(c);
    else
    {
        for (i = 0; i < s2.Length; i++)
        {
            c += s2[i];
            s1 = s2;
            s1 = s1.Remove(i, 1);
            rec(s1, c);
            c = c.Remove(c.Length - 1, 1);
        }
    }
}


Console.Clear();
string? s = Console.ReadLine(), c, s2;
for(int i = 0; i < s.Length; i++)
{
    c = s[i].ToString();
    s2 = s;
    s2 = s2.Remove(i, 1);
    //Console.WriteLine(s2);
    rec(s2, c);
}