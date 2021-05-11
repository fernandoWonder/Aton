using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Documents
{
    public class StockTransitionType
    {
        public string Id { get; set; }
        public string Tipo { get; set; } // Entry, Out, Transition
        public string InvoiceTypeId { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }
        public virtual ICollection<StockTransition> Transacoes { get; set; }
    }
}
