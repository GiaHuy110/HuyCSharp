namespace RefOutRegexTryParse;
internal class RefOut
{
    public static void Changevar(out int a, out int b)
    {
        a = 10;
        b = 5;
        var tam = a;
        a = b;
        b = tam;
        Console.WriteLine("chang value: ");
        Console.WriteLine($"{nameof(a)}={a}, {nameof(b)}={b}");
    }
}
