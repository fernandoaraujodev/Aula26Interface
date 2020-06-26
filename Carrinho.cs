using System.Collections.Generic;
using System;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {

        public float Subtotal {get;set;}

        List<Product> carrinho = new List<Product>();
        public void Create(Product product)
        {
            carrinho.Add(product);
        }

        public void Delete(Product product)
        {
            carrinho.Remove(product);
        }

        public void Read()
        {
            foreach(Product item in carrinho){
                System.Console.WriteLine($"US$ {item.Price} - {item.Name}");
            }
        }

        public void Update(int _code, Product product)
        {
            carrinho.Find(p => p.Code == _code).Name = product.Name;
            carrinho.Find(p => p.Code == _code).Price = product.Price;

        }

        public void ShowSubtotal(){
            foreach(Product item in carrinho){
                Subtotal += item.Price;
            } 

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Subtotal => US${Subtotal}");
            Console.ResetColor();
            
        }
    }
}