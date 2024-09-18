using System;

namespace Business
{
    public class ProductBusiness
    {
        private ProductContext productContext;
        public string GetAll()
        {
            using (productContext = new ProductContext())
            {
                var products = productContext.Products
                    .Select(p => productContext.Products
                    {
                        p.Name,
                        p.Price,
                        category = p.Category.Name,
                    }) .ToList();
            }
        }
    }
}