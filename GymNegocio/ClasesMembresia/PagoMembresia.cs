using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymNegocio.ClasesMembresia;

namespace GymNegocio.ClasesMembresia
{
    public class PagoMembresia
    {
        public int Id { get; set; }
        public int MembresiaId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }

        public PagoMembresia()
        {
            FechaPago = DateTime.Now;
        }

        public PagoMembresia(int membresiaId, decimal monto, string metodoPago)
        {
            MembresiaId = membresiaId;
            Monto = monto;
            MetodoPago = metodoPago;
            FechaPago = DateTime.Now; 
        }
    }
}
