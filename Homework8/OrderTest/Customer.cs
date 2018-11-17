using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OrderTest
{
    public class Customer
    {
         public Customer(string name, string telephone)
        {
            Regex idRegex = new Regex(@"^\d{11}$");
            if (idRegex.IsMatch(telephone) == true)
            {
                Name = name;
                Telephone = telephone;
            }
            else
            {
                Console.WriteLine("电话无效！");
            }
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
        public override bool Equals(object obj)
        {
            Customer a = (Customer)obj;
            if (Telephone == a.Telephone && Name == a.Name)
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"客户名称：{Name} 联系方式：{Telephone}";
        }
    }
}
