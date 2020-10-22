using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shop.Database;

namespace Shop.Application.StockAdmin
{
    public class GetStocks
    {
        private ApplicationDbContext _ctx;

        public GetStocks(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<StockViewModel> Do(int productId)
        {
            var stock = _ctx.Stocks
                .Where(x => x.ProductId == productId).
                Select(x=>new StockViewModel()
                {
                    Id = x.Id,
                    Descriprion = x.Descriprion,
                    Qty = x.Qty
                })
                .ToList();

            return stock;
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public string Descriprion { get; set; }
            public int Qty { get; set; }
            public int ProductId { get; set; }
        }
    }
}
