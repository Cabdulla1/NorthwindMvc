using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveFromCart(Cart cart,Product product);
        List<CartLine> List(Cart cart); 
    }
}
