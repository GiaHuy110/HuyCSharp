using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class ManyFile : IBinaryFile, ITextFile
{
    // bỏ từ truy cập, sau đó thêm tên interface 
    void IBinaryFile.ReadFile() => Console.WriteLine("read file");

    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTextFile() => Console.WriteLine("write text file");

}
