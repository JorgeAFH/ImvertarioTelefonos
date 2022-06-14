using System;
class inverntario
{
    public string codigoP;
    public string NombreP;
    public int Cantidad;
    public inverntario(string codigoP, String NombreP, int Cantidad)
    {
        this.codigoP = codigoP;
        this.NombreP = NombreP;
        this.Cantidad = Cantidad;
    }
    public void MostrarInventario()
    {
        Console.WriteLine(codigoP+"    "+NombreP+"    "+Cantidad);
    }
}