using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var ans = 0;
        for(int i= 0; i < n; i++)
        {
            var In = int.Parse(Console.ReadLine());
            if (IsPrime(In) == true) ans++;
        }
        Console.WriteLine(ans);
    }
    static bool IsPrime(int a)
    {
        if(a == 2) return true;

        else if(a < 2 || a % 2 == 0) return false;

        var i = 3;
        while(i <= Math.Sqrt(a))
        {
            if (a % i == 0) return false;

            i += 2;
        }
        return true;
    }
}