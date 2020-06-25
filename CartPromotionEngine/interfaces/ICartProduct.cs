using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.interfaces
{
    public interface ICartProduct 
    {
        char ProductId { get; set; }
        int Quantity { get; set; }
        int ItemPrice { get; set; }
        int TotalItemsPrice { get; set; }
        bool IsPromotionApplied { get; set; }
        Implementations.PromotionTypeEnum PromotionType { get; set; }

        int GetItemCost();
    }
}
