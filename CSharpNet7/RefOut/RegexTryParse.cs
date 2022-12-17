namespace RefOutRegexTryParse;
internal class RegexTryParse
{
    public static void CheckNumberByRegex()
    {
        string? str = null;
        Console.WriteLine("vui long nhap so: ");
        str = Console.ReadLine();
        
        Regex formula = new Regex("[0-9]+$");
        if (formula.IsMatch(str))
        {
            int result = int.Parse(str);
            Console.WriteLine($"{nameof(result)}={result}");
        }
    }
    public static void CheckStringByTryParse()
    {
        string? str = null;
        Console.WriteLine("vui long nhap so: ");
        str = Console.ReadLine();

        if (int.TryParse(str, out int i))
        {
            Console.WriteLine($"{nameof(i)}={i}");
        }
    }
    public static void TryCatchBug()
    {
        Console.WriteLine("vui long nhap so: ");
        String? amount = Console.ReadLine();
        try
        {
            int total = int.Parse(amount);
            if(total <= 0)
            {
                throw new Exception("phai nho hon 0");
            }
        }
        catch(Exception) when (amount.Contains("$"))
        {
            Console.WriteLine("amount ko dc co dau $");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.GetType()} : {e.Message}");
        }
    }
}
