using MassTransit;
using OrdersAPIContext_OrdersAPI;
using Shared.Models;


namespace OrdersAPI.Consumer
{
    public class ProductCreatedConsumer : IConsumer<ProductCreated>
    {
        private readonly Data_ _context;

        public ProductCreatedConsumer(Data_ context)
        {
            _context = context;
        }

        public async Task Consume(ConsumeContext<ProductCreated> context)
        {
            var product = new Product
            {
                //Id = context.Message.Id,
                Name = context.Message.Name,
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}