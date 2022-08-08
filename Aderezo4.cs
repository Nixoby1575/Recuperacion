class Adrezo4 : Decorator
{
    public Adrezo4(OrdenBase orden) : base(orden)
    {

    }
/*Método herdedado de la clase OrdenBase a través del decorator para poder cambiar su código interno*/
    public override double CalcularPrecioTotal()
    {
        return base.CalcularPrecioTotal() + 0.71;
    }
}