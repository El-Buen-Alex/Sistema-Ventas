using System;
using System.Collections.Generic;

#nullable disable

namespace WSVentas.Model
{
    public partial class Ventum
    {
        public Ventum()
        {
            ConceptoVenta = new HashSet<ConceptoVentum>();
        }

        public long IdVenta { get; set; }
        public long? IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<ConceptoVentum> ConceptoVenta { get; set; }
    }
}
