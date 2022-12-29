using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
internal class Sunflower : Plant
{
    static void Main(string[] args)
    {
        Sunflower flower = new Sunflower();
        flower.Protected(); //là con nên đc dùng 
        flower.Internal();  // trong cùng project/asembly
        flower.PrivateProtected();  // hoặc private hoặc protected thì đc dùng 
        flower.ProtectedInternal();
        flower.Public();
        // flower.Private(); => error vì chỉ đứng tại class đó mới đc dùng. 
    }
}
