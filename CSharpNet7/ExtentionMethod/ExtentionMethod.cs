using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod;
internal static class ExtentionMethod
{
    // 1 class mà static thì toàn bộ bên trong nó phải là static 
    public static void CheckIsGreaterThan(this int i, int value)
    {
        if (i > value)
        {
            Console.WriteLine($"{i} đúng là lớn hơn {value}");
        }
    }

    public static void Hello(this Program pro)
    {
        Console.WriteLine("hello");
    }
}
