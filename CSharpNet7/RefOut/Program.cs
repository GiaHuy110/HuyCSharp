
using RefOutRegexTryParse;

//int a = 10;
//int b = 5;

//RefOut.Changevar(ref a, ref b);
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;


RefOut.Changevar(out int a, out int b);
Console.WriteLine("main: ");
Console.WriteLine($"{nameof(a)}={a}, {nameof(b)}={b}");

// pure oop => oop nguyên thủy, thuần oop => C# cũ
//RegexTryParse parse = new RegexTryParse();

// dùng từ var 
//var parse = new RegexTryParse();

// target-type c# new
RegexTryParse p = new();
//parse.CheckNumberByRegex();
//parse.CheckStringByTryParse();
