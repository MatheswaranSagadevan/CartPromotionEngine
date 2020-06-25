using CartPromotionEngine.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartPromotionEngine.Implementations
{
   public class PriceCalculator : IPriceCalculator
    {
        public List<ICartProduct> UpdatedCartProducts { get; set; }
        public int TotalOrderValue { get; set; }
        public IPriceCalculator CalculatePrice(List<ICartProduct> cartProducts)
        {
            var ProductA = cartProducts.SingleOrDefault(x => x.ProductId == 'A');
            var ProductB = cartProducts.SingleOrDefault(x => x.ProductId == 'B');
            var ProductC = cartProducts.SingleOrDefault(x => x.ProductId == 'C');
            var ProductD = cartProducts.SingleOrDefault(x => x.ProductId == 'D');

            if (ProductA != null)
            {
                var count = ProductA.Quantity;
                var promotionApplicableItems = count / 3;
                var nonPromotionItems = count % 3;

                var offerTotalCost = promotionApplicableItems * 130;
                var nonOfferTotalCost = nonPromotionItems * 50;
                ProductA.TotalItemsPrice = offerTotalCost + nonOfferTotalCost;
            }
            if (ProductB != null)
            {
                var count = ProductB.Quantity;
                var promotionApplicableItems = count / 2;
                var nonPromotionItems = count % 2;

                var offerTotalCost = promotionApplicableItems * 45;
                var nonOfferTotalCost = nonPromotionItems * 30;
                ProductB.TotalItemsPrice = offerTotalCost + nonOfferTotalCost;
            }
            if (ProductC != null || ProductD != null)
            {
                int offerTotalCost = 0; 
                int nonOfferTotalCost = 0;
                if (ProductC.Quantity == ProductD.Quantity)
                {
                    offerTotalCost = ProductC.Quantity * 30;
                    ProductC.TotalItemsPrice = offerTotalCost;
                }
                else if (ProductC.Quantity < ProductD.Quantity)
                {
                    offerTotalCost = ProductC.Quantity * 30;
                    nonOfferTotalCost = (ProductD.Quantity - ProductC.Quantity) * 15;
                    ProductC.TotalItemsPrice = offerTotalCost + nonOfferTotalCost;
                }
                else //if (ProductC.Quantity > ProductD.Quantity)
                {
                    offerTotalCost = ProductD.Quantity * 30;
                    nonOfferTotalCost = (ProductC.Quantity - ProductD.Quantity) * 20;
                    ProductC.TotalItemsPrice = offerTotalCost + nonOfferTotalCost;
                }
            }

            List<ICartProduct> updatedCartProducts = new List<ICartProduct>();
            updatedCartProducts.Add(ProductA);
            updatedCartProducts.Add(ProductB);
            updatedCartProducts.Add(ProductC);
            updatedCartProducts.Add(ProductD);

            this.TotalOrderValue = updatedCartProducts.Sum(x => x.TotalItemsPrice);
            this.UpdatedCartProducts = updatedCartProducts;

            return this;
        }

       
    }
}
