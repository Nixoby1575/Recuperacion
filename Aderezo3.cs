class Adrezo3 : Decorator
{
    public Adrezo3(OrdenBase orden) : base(orden)
    {

    }
/*Método herdedado de la clase OrdenBase a través del decorator para poder cambiar su código interno*/
    public override double CalcularPrecioTotal()
    {
        return base.CalcularPrecioTotal() + 0.91;
    }
}