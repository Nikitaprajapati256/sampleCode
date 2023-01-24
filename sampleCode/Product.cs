using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleCode
{
    public class Product
    {
        private int pid;
        private string name;
        private int price;
        private double dis,disPrice;

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

      /*  public Product()
        {
            pid = 101;
            pname = "Chair";
            price = 2500;
        }
        public Product(int pid, string pname, int price)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
           
        }

        public void Discount()
        {
            if (price > 2000)
            {
                dis= (double)price*0.15;

            }
            else
            {
                dis = (double)price * 0.05;
            }
             disPrice= (double)price-dis;
        }
        public string Display()
        {
            return $"product id {pid}  Product Name {pname} Product Price {price} Discount {dis} Price After Discount {disPrice}";
        }*/
    }
}
