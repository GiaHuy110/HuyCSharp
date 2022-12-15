using System.Collections;
using System.Text;

Console.InputEncoding= Encoding.Unicode;
Console.OutputEncoding= Encoding.Unicode;

int number1 = Random.Shared.Next(0, 9);
int number2 = Random.Shared.Next(0, 9);

Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");
Console.WriteLine("vui lòng nhập dấu của phép toán: ");
string? dau = Console.ReadLine();

switch (dau)
{
    case "+" when number1 > 0 && number2 > 0:
        Console.WriteLine(number1 + number2); break;
    case "-" when number1 >= number2:
        Console.WriteLine(number1 - number2); break;
    case "*":
        Console.WriteLine(number1 * number2); break;
    case "/" when number2 != 0: 
        Console.WriteLine(number1 / number2); break;
    default:
        Console.WriteLine("hi, i can'n"); break;
}
// swich exprestion
Console.WriteLine(
    dau switch
    {
    "+" when number1 > 0 && number2 > 0 => number1 + number2,
    "-" when number1 >= number2 => number1 - number2,
    "*" => number1 * number2,
    "/" when number2 != 0 => number1 / number2,
    _=> "hi, i can't"
    }
);

string[] arrs = { "Tín", "THiện", "Chương", "Huy", "Toàn" };
foreach(var t in arrs)
{
    Console.WriteLine(t);
}

IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = e.Current.ToString();
    Console.WriteLine(s);
}
