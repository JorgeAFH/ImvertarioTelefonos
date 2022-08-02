using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonos
{
    class Dispositivo3 : InventarioDecorador
    {
        public Dispositivo3(OrdenBase orden) : base(orden)
        {

        }
        public override string MostrarInve()
        {
            var inv = base.MostrarInve();
            return inv;
        }
    }
}
