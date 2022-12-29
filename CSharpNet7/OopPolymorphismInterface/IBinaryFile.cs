using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal interface IBinaryFile
{
    // không dùng bổ từ truy cập (access modify)
    void WriteBinaryFile();
    void ReadFile();
    // có phương thức mặc định tồn tại trong interface
    void ShowInfo() => Console.WriteLine("this is binary");
}
