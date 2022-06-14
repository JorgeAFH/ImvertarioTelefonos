class Imprecion:Factura
{
    public string Numerofactura;
    public string AsesorVenta;
    public string NombreCliente;
    public string NumeroID;
    public string CodProducto;
    public string Direccion;
    public string PrecioVenta;
    public string ModeloTelefonico;
    public override void CrearFactura()
    {
        Console.Clear();
        Console.WriteLine("numero de factura");
        Numerofactura=Console.ReadLine();
        Console.WriteLine("Asesor de ventas");
        AsesorVenta=Console.ReadLine();
        Console.WriteLine("Nombre del Cliente");
        NombreCliente=Console.ReadLine();
        Console.WriteLine("Numero de dentificacion/cedula");
        NumeroID=Console.ReadLine();
        Console.WriteLine("Codigo de producto");
        CodProducto=Console.ReadLine();
        Console.WriteLine("Direccion");
        Direccion=Console.ReadLine();
        Console.WriteLine("Precio de venta");
        PrecioVenta=Console.ReadLine();
        Console.WriteLine("modelo telefonico");
        ModeloTelefonico=Console.ReadLine();
        Console.Clear();
    }
    public override void Imprimir()
    {
        Console.WriteLine("numero de factura");
        Console.WriteLine(Numerofactura);
        Console.WriteLine("Asesor de ventas");
        Console.WriteLine(AsesorVenta);
        Console.WriteLine("Nombre del Cliente");
        Console.WriteLine(NombreCliente);
        Console.WriteLine("Numero de dentificacion/cedula");
        Console.WriteLine(NumeroID);
        Console.WriteLine("Codigo de producto");
        Console.WriteLine(CodProducto);
        Console.WriteLine("Direccion");
        Console.WriteLine(Direccion);
        Console.WriteLine("Precio de venta");
        Console.WriteLine(PrecioVenta);
        Console.WriteLine("modelo telefonico");
        Console.WriteLine(ModeloTelefonico);
        Console.ReadLine();
    }
}