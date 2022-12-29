using Baitap1.Dal;
using Baitap1.ExtentionMethod;
using Microsoft.Win32.SafeHandles;
using Baitap1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1.Menu;
internal class MainMenu
{
    public static void Show()
    {
        DalProduct dal = new();
        while (true)
        {
            Console.WriteLine("======= Menu ======");
            Console.WriteLine("Please choose: ");
            Console.WriteLine("1- add product: ");
            Console.WriteLine("2- Show list: ");
            var n = Validate<int>.Input("Please enter number");
            switch (n)
            {
                case 1:
                    dal.ChangeColor(ConsoleColor.White, ConsoleColor.Blue);
                    dal.Add();
                    break;
                case 2:
                    dal.ChangeColor(ConsoleColor.White, ConsoleColor.Red);
                    dal.Show();
                    break;
                default:
                    Console.WriteLine("End");
                    return;

            }
        }
    }
}
