using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductDescription = command.ProductDescription,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                Status = true,
                ProductStock = command.ProductStock,
            });
            _context.SaveChanges();
        }
    }
}
