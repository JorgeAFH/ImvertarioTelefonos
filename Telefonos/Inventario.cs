using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Telefonos 
{
     class Inventario
    {
        public int Codigo {get; set;}
        public string NombreProducto { get; set;}
        public int Cantidad {get; set;}
        public Inventario(int Codigo, string NombreProducto, int Cantidad)
        {
            this.Codigo = Codigo;
            this.NombreProducto = NombreProducto;   
            this.Cantidad = Cantidad;
        }
        public void MostrarInve() 
        {
            Console.WriteLine(" "+Codigo+ " "+ NombreProducto +" " + Cantidad );
        }
    }
}
