using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.interfaces
{
    public interface IProduct
    {
        int GetItemCost(char productId);
    }
}
