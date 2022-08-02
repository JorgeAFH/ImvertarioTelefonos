using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonos
{
     class InventarioDecorador:OrdenBase
    {
        protected OrdenBase orden;
        public InventarioDecorador(OrdenBase orden)
        {
            this.orden = orden;
        }
        public virtual string MostrarInve() 
        {
            Console.WriteLine("--------------- INVENTARIO ---------------");
            return orden.MostrarInve();
        }
    }
}
