using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Telefonos
{
    class Factura
    {
        string NombreCliente { get; set; }
        string ModeloTelefo { get; set; }
        string AsesorVenta { get; set; }
        string Direccion { get; set; }
        int NumeroCedula { get; set; }
        int NumeroFactura { get; set; }
        int PrecioDVenta { get; set; }
        int CodProducto { get; set; }
        public void Ingresar() 
        {
            
            Console.WriteLine("Ingrese el numero de Factura");
            NumeroFactura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del Asesor de Venta");
            AsesorVenta=Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Cliente");
            NombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de cedula del Cliente");
            NumeroCedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la direccion del Cliente");
            Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el Codigo de Producto");
            CodProducto = int.Parse(Console.ReadLine());     
            Console.WriteLine("Ingrese el precio del telefono");
            PrecioDVenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el modelo del telefono");
            ModeloTelefo = Console.ReadLine();

        }
        public void Imprimir() 
        {
            Console.Clear();
            Console.WriteLine("--------- SISTEMA DE FACTURIZACIÓN - VENTAS TELEFONICAS---------");
            Console.WriteLine("- Asesor de Venta: "+ AsesorVenta +"\n- Nombre Cliente: " + NombreCliente+ "\n- #de Identificación: " + NumeroCedula + "\n- # Factura: " + NumeroFactura);
            Console.WriteLine("- COD Producto: "+ CodProducto + "\n- Dirección: " + Direccion + "\n- Precio de Venta: " + PrecioDVenta+ "$");
            Console.WriteLine("- Modelo Telefonico: "+ModeloTelefo);
        }
    }
}