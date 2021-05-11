using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Documents
{
    public class StockTransition
    {

        public int Id { get; set; }
        public string StockTransitionTypeId { get; set; } // Entry, Out, Transition
        public int InvoiceId { get; set; }

        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Custo { get; set; }
        public decimal Taxa { get; set; }

        public decimal CustoIncidencia
        {
            get
            {
                return Custo * Quantidade;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return CustoIncidencia * (1 + Taxa/100);
            }
        }

        /* Utilizar esses elementos quando utilizarmos controle de Lotes
        public DateTime DataCriacao { get; set; }
        public DateTime DataExpiracao { get; set; }
        */
        public virtual Product Produto { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual StockTransitionType StockTransitionType { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
