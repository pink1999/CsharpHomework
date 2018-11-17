using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace OrderTest
{
    class Program
    {
//        1、为订单添加数据验证功能，要求
//  （1）订单号不能为空、不能重复、并且是”年月日+三位流水号”的形式。
//  （2）客户的电话号码是正确的格式。
//        2、将订单导出为HTML文件，在浏览器打开并显示。（备注：使用XSLT进行转换）
        static void Main(string[] args)
        {
            try
            {
                Customer cust1 = new Customer("Lily", "16788980981");
                Good apple = new Good("apple", 2.5);
                Good milk = new Good("milk", 3.5);
                Order order1 = new Order(20180422, cust1);
                OrderDetails detail1 = new OrderDetails(1, apple, 10000);
                OrderDetails detail2 = new OrderDetails(2, milk, 500);
                order1.AddDetail(detail1);
                order1.AddDetail(detail2);
                OrderService service1 = new OrderService();
                service1.AddOrder(order1);
                //序列化过程
                List<Order> orderList = service1.orderDict.Values.ToList<Order>();
                service1.Export(orderList);
                //使用XSLT转化
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"D:\s.xml");
                XPathNavigator nav = xDoc.CreateNavigator();
                nav.MoveToRoot();
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"D:\s.xslt");
                XmlTextWriter writer = new XmlTextWriter(Console.Out);
                xt.Transform(nav, null, writer);
                writer.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
