using System;
using System.Collections.Generic;

#nullable disable

namespace WSVentas.Model
{
    public partial class Producto
    {
        public Producto()
        {
            ConceptoVenta = new HashSet<ConceptoVentum>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Costo { get; set; }

        public virtual ICollection<ConceptoVentum> ConceptoVenta { get; set; }
    }
}
