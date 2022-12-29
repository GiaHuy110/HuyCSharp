using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstraction;
internal class Cat : Animal
{
    // con kế thừa cha, cha abstract, con phải thực thi lại các phương thức abstract nếu không con cũng là abstract
    private bool gender;

    // 1 phương thức mà chỉ có 1 câu lệnh duy nhất 
    // => chuyển thành expression body
    public void ShowCat() => Console.Write("helo");
}
