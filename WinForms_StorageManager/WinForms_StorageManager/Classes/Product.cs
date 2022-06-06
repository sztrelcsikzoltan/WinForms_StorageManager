using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_StorageManager.Classes
{
    class Product
    {
        public int productId;
        public string productName;
        public int price;

        public Product(int productId, string productName, int price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }
    }
}
