using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderApplication
{
//    为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单等功能。
//要求：
//（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
//（2）主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
//（3）尽量通过数据绑定来实现功能。 注：订单明细可以设置DataMember来绑定。
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
