using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassUV<U,V>
{
    public U Field1 { get; set; }
    public V Field2 { get; set; }
    public void Show()
    {
        Console.WriteLine($"{nameof(Field1)}={Field1}, {nameof(Field2)}={Field2}");
    }
}
