class Program
{
    static void Main()
    {
        DecimalNumber number = new DecimalNumber(50);
        number.Show();
    }
}

public struct DecimalNumber
{
    private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }

    public DecimalNumber(int value)
    {
        this.value = value;
    }

    public string ToBinary() 
    { 
        return Convert.ToString(value, 2);
    }
    public string ToOctal()
    {
        return Convert.ToString(value, 8);
    }

    public string ToHexadecimal()
    {
        return Convert.ToString(value, 16).ToUpper();
    }

    public void Show()
    {
        Console.WriteLine($"Десяткове число: {value}"  );
        Console.WriteLine($"У двійковій системі: {ToBinary()}" );
        Console.WriteLine($"У вісімковій системі: {ToOctal()};");
        Console.WriteLine($"У шістнадцятковій системі: {ToHexadecimal()} ");
    }
}