using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +  "eklendi");
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
                                        //ikisi arasındaki fark, bir değeri başka yerde de kullanmak istedigimizde
                                        //1. metodu kullanırız. 2. yöntemde sadece sonucu yazar bize.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }


    }
}
