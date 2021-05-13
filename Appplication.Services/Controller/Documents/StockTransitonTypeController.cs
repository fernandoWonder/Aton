using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller.Documents
{
    public class StockTransitonTypeController
    {
        StockTransitionTypeRepository _transitionTypeRepo = new StockTransitionTypeRepository();

        private StockTransitionType getOne(string id)
        {
            return _transitionTypeRepo.listForID(id);
        }

        public List<StockTransition> getStockTransitionForType(string type)
        {
            return getOne(type).Transacoes.ToList();
        }

        public StockTransitionType getOneForInvoiceType(string invoiceTypeId)
        {
            return _transitionTypeRepo.ListAllAsNoTracking().Where(t => t.InvoiceTypeId == invoiceTypeId).FirstOrDefault();
        }

        public List<StockTransition> getStockTransitionForTypeDateRange(string type, DateTime dt1, DateTime dt2)
        {
            return getOne(type).Transacoes.Where(t => t.DataCadastro >= dt1 && t.DataCadastro <= dt2).ToList();
        }
    }
}
