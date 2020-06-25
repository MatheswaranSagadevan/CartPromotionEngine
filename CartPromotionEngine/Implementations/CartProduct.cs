using CartPromotionEngine.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.Implementations
{
    public class CartProduct : ICartProduct
    {
        public char ProductId { get; set; }
        public int Quantity { get; set; }
        public int ItemPrice { get; set; }
        public int TotalItemsPrice { get; set; }
        public bool IsPromotionApplied { get; set; }
        public PromotionTypeEnum PromotionType { get; set; }

        public int GetItemCost()
        {
            throw new NotImplementedException();
        }
    }
}
