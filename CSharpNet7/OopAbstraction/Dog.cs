using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstraction;
internal abstract class Dog : Animal
{
    // thực thi lại cái phương thức abstract của animal 
    // buộc phải dùng từ khóa overrive vào 
    public overrive void ShowInfor()
    {
        Console.WriteLine("this is a dog");
    }
}
