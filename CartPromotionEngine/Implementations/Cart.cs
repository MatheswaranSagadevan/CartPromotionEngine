using CartPromotionEngine.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.Implementations
{
    public class Cart : ICart
    {
        public List<ICartProduct> CartProducts { get; set; }
        public int CartTotalValue { get; set; }

        private IPriceCalculator PriceCalculator;
        
        public Cart() { 
        }
        public Cart(IPriceCalculator priceCalculator)
        {
            CartProducts = new List<ICartProduct>();
            PriceCalculator = priceCalculator;
        }

        public void AddItemsToCart(List<char> productIds)
        {
            foreach (char item in productIds)
            {
                var existingItem = CartProducts.SingleOrDefault(x => x.ProductId == item);
                if (existingItem != null)
                    existingItem.Quantity++;
                else
                CartProducts.Add(new CartProduct() { ProductId = item, Quantity = 1 });
            }
        }

        public void CalculatePrice()
        {
            PriceCalculator = PriceCalculator.CalculatePrice(CartProducts);
            CartProducts = PriceCalculator.UpdatedCartProducts;
            CartTotalValue = PriceCalculator.TotalOrderValue;
        }

        public List<ICartProduct> GetCartDetails()
        {
            return CartProducts;
        }
    }
}
