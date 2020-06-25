using CartPromotionEngine.Implementations;
using CartPromotionEngine.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace CartPromotionEngine
{
    class Program
    {
        private UnityContainer container;
        Program()
        {
            container = new UnityContainer();

            container.RegisterType<ICartProduct, CartProduct>();
            container.RegisterType<ICart, Cart>();
            container.RegisterType<IPriceCalculator, PriceCalculator>();
           
        }
        static void Bootstrap() {
            
        }
        static void Main(string[] args)
        {
            //Bootstrap();
            Program program = new Program();

            Console.WriteLine("Enter number of items to added");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Item codes separated by space");
            List<char> itemCodes = new List<char>();
            do
            {
                char code = Convert.ToChar(Console.Read());
                if (char.IsWhiteSpace(code) && n > 0)
                    continue;
                else
                {
                    itemCodes.Add(code);
                    n--;
                }
            } while (n > 0);

            foreach (char item in itemCodes)
                Console.WriteLine("Item = " + item);

            // Create the cart
            var cart = program.container.Resolve<Cart>();
            cart.AddItemsToCart(itemCodes); // add the items to the cart
            cart.CalculatePrice();
            
            var cartProducts = cart.GetCartDetails();

            foreach (ICartProduct product in cartProducts)
                Console.WriteLine("Product Item: {0} Quantity: {1} Unit Price: {2} Item Total Price: {3}",product.ProductId, product.Quantity, product.ItemPrice, product.TotalItemsPrice);
            Console.WriteLine("Total Cart Order Value:{0}", cart.CartTotalValue);

            Console.ReadKey();
            

        }
    }
}
