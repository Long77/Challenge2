/**
Something's wrong with the below function! Refactor it to make the code work as expected.
**/

using System;

public class Program
{
    static int sum(int a, int b)
    {return a+b;}

    //int result = a + b;
    static int sum2(int a, int b) => a + b;

    public static Func<int, int, int> sum3 = (a,b) => a+b;
    public static void Main()
    {
        Console.WriteLine(sum(1, 2) == 3);

        Func < int, int, int> add = (int a, int b) => a + b;

        Console.WriteLine(sum2(1, 2) == 3);
        Console.WriteLine(sum3(1, 2) == 3);
        Console.ReadLine();
    }
}


//Part 2: re-write sum as a lambda or Func<int, int, int>