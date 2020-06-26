using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("PS4 Control Dualsense", 1, 49.98f);
            Product p2 = new Product("XboxOne Control ", 2, 59.98f);
            Product p3 = new Product("Kinect", 3, 49.98f);

        
            Carrinho c = new Carrinho();
            c.Create(p1);
            c.Create(p2);
            c.Create(p3);

            c.Read();

            c.ShowSubtotal();
        }
    }
}
