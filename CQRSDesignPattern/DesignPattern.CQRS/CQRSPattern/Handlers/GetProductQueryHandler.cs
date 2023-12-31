﻿using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values=_context.Products.Select(x=>new GetProductQueryResult
            {
                ID=x.ProductID, 
                ProductName=x.ProductName,
                Price=x.ProductPrice,
                Stock=x.ProductStock
            }).ToList();
            return values;
        }
    }
}
