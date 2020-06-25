using CartPromotionEngine.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.Implementations
{
    // Referential Master Data, should be taken from DB in reality
    public class Product : IProduct
    {
        public int GetItemCost(char productId) {
            if (productId == 'A')
            {
                return 50;
            }
            else if (productId == 'B')
            {
                return 30;
            }
            else if (productId == 'C')
            {
                return 20;
            }
            else if (productId == 'D')
            {
                return 15;
            }
            else
                return -1;


        }
    }
}
