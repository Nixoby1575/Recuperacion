class Decorator : OrdenBase
{
    /*Se protege la clase OrdenBase*/
    protected OrdenBase orden;
/*El método de la OrdenBase se pasa a tavés del Decorator y poder heredarlo a las clases hijas*/
    public Decorator (OrdenBase orden)
    {
        this.orden = orden;
    }
    /*Permite heredar el método a las clases hijas*/
    public virtual double CalcularPrecioTotal()
    {
        Console.WriteLine("Precio Calculado desde el decorador");
        return orden.CalcularPrecioTotal();
    }
}