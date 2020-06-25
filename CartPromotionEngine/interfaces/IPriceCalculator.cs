using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.interfaces
{
   public interface IPriceCalculator
    {
        List<ICartProduct> UpdatedCartProducts { get; set; }
        int TotalOrderValue { get; set; }
        IPriceCalculator CalculatePrice(List<ICartProduct> cartProducts);
    }
}
