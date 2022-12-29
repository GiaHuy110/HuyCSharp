using ExtentionMethod;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập giá trị cho biến i: ");

int i = int.TryParse(Console.ReadLine(), out int result)? result:0;
CheckNumber.CheckIsGreaterThan(1, 100);
i.CheckIsGreaterThan(100);

Program pro = new();
pro.Hello();
