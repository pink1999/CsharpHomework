using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTest;


namespace OrderApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Order> Create()
        {
            string s = textBox1.Text;
            string[] orders = s.Split('*');
            OrderService service1 = new OrderService();
            List<Order> list = new List<Order>();
            foreach (string order in orders)
            {
                string[] lines = order.Split('\n');
                string[] s1 = lines[0].Split('-');
                string s3 = s1[0].Trim('*', '-');
                uint i1 = (uint)int.Parse(s3);
                string cusname = s1[1].Trim('*', '-');
                string custele = s1[2].Trim('*', '-');
                Customer customer = new Customer(cusname, custele);
                Order order1 = new Order(i1, customer);
                service1.AddOrder(order1);
                for (int i = 1; i < lines.Length - 1; i++)
                {
                    string[] s2 = lines[i].Split('-');
                    OrderDetails detail1 = new OrderDetails((uint)int.Parse(s2[0].Trim('*', '-')), new Good(s2[1].Trim('*', '-'), double.Parse(s2[2].Trim('*', '-'))), (uint)int.Parse(s2[3].Trim('*', '-')));
                    order1.AddDetail(detail1);
                }
                list.Add(order1);
            }
            return list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = Create();
            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //点击单元格时显示此单元格的具体信息
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前选中的行
            int rowindex = e.RowIndex;
            int i = 0;
            string value = "";
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                value = value + dataGridView1.Rows[rowindex].Cells[i].Value.ToString();
            }
            MessageBox.Show(value);

        }
        //删除订单按钮事件
        //无法删除 暂未能解决
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //选中的行数
                int iCount = dataGridView1.Rows.Count;
                if (iCount < 1)
                {
                    MessageBox.Show("Delete Data Fail!", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                else if (DialogResult.Yes == MessageBox.Show("是否删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)  //循环遍历所有行
                    {    //当前单元格处于选中状态，则将其删除
                        if (true == this.dataGridView1.Rows[i].Selected)
                            this.dataGridView1.Rows.RemoveAt(i);
                    }
                    //删除任意行数据后，应该刷新dataGridView表格，使索引值从上至下按大小顺序排序
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //按客户名查询订单
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string s = " ";
                List<Order> list = Create();
                List<Order> list1 = new List<Order>();
                OrderService service = new OrderService();
                foreach (Order order in list)
                {
                    if (order.Customer.Name == textBox2.Text)
                    {
                        list1.Add(order);
                    }

                }
                foreach (Order order in list1)
                {
                    s = s + order.ToString();
                }
                MessageBox.Show(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
