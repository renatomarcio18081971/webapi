using System.Collections.Generic;

namespace Cliente.Model
{
    public class VendasModel
    {
        public int Codigo { get; set; }
        public decimal ValorTotal { get; set; }
        public IEnumerable<ItemDaVendaModel> Item { get; set; }
    }
}
