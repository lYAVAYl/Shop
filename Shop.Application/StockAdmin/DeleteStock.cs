﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.StockAdmin
{
    class DeleteStock
    {
        private ApplicationDbContext _ctx;

        public DeleteStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var dsdsdfdfs = _ctx.Stocks.FirstOrDefault(x => x.Id == id);

            await _ctx.SaveChangesAsync();
            return true;
        }
    }
}
