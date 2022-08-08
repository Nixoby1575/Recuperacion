
internal class Program
{
    private static void Main(string[] args)
    {
     
        Console.WriteLine("");
       var taco1 = new Tacos();
       Console.WriteLine($"El precio del taco es de: {taco1.CalcularPrecioTotal()}");
       var aderezo1 = new Adrezo1(taco1);
       Console.WriteLine($"El precio del taco con chile es de: {aderezo1.CalcularPrecioTotal()}");
       var aderezo2 = new Adrezo2(taco1);
       Console.WriteLine($"El precio del taco con dos aderezos es de: {aderezo2.CalcularPrecioTotal()}");
       var aderezo3 = new Adrezo3(taco1);
       Console.WriteLine($"El precio del taco con tres aderezos es de: {aderezo3.CalcularPrecioTotal()}");
       Console.WriteLine();
    }
}