using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    public class Customer
    {
         public Customer(string name, string telephone)
        {
            Name = name;
            Telephone = telephone;
        }
        public Customer()
        {
        }
        public string Name
        {
            get;set;
        }
        public string Telephone
        {
            get; set;
        }
        

        public override string ToString()
        {
            return $"客户名称：{Name} 联系方式：{Telephone}";
        }
    }
}
