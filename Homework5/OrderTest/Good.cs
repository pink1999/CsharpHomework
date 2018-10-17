using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    class Good
    {
        //构造函数
        public Good(string name = " ", double price = 0 )
        {
            Price = price;
            Name = name;
        }
        public double Price
        {
            get;set;
        }
        public string Name
        {
            get; set;
        }
       
        //重写equals()
        public override bool Equals(object obj)
        {
            Good a = (Good)obj;
            if (Price == a.Price && Name == a.Name)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "商品名称："+Name+" "+"商品价格："+Price;
        }
    }
}
