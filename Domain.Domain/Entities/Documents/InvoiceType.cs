using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities.Documents
{
    public class InvoiceType
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public bool SalesInvoices { get; set; } = true; // *** Table SalesInvoice on the saft
        public bool WorkDocuments { get; set; } = false; // *** table WorkDocuments on the saft
        public bool Payments { get; set; } = false; // *** Table Payments on the saft
        public bool Purchase { get; set; } = false; // Documents for purchase
        public bool Seller { get; set; } = true; // Documents for seller
        public bool Stock { get; set; } = false; // Movments of Stock
        public virtual ICollection<Invoice> Faturas { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
