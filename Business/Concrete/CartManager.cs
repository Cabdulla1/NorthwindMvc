using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.SingleOrDefault(c=>c.Product.ProductId == product.ProductId);
            if(cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine { Product = product,Quantity = 1});
            }

            
        
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.SingleOrDefault(c=>c.Product.ProductId == product.ProductId);
            if (cartLine.Quantity > 1)
            {
                cartLine.Quantity--;
                return;
            }
            else
            {
                cart.CartLines.Remove(cart.CartLines.SingleOrDefault(c=>c.Product.ProductId == product.ProductId));
            }
        }
    }
}
