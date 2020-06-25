using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.interfaces
{
    public interface ICart
    {
        void AddItemsToCart(List<char> productIds);
        void CalculatePrice();
        List<ICartProduct> GetCartDetails();
    }
}
