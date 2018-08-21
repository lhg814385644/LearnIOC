using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOClearn.DAL;
using IOClearn.Orders;

namespace IOClearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //高层模块依赖低层模块
            //var order = new Order();
            //order.Add();

            //DI,构造函数注入方式
            //var  dal = new SqlServerDal();//在外部创建依赖对象
            ////这样依赖对象在Order的外部创建绑定，不影响Order内部的逻辑，可以随时切换数据访问类
            ////如：var accessdal=new AccessDal();
            //Order order = new Order(dal);//通过构造函数注入依赖
            //order.Add();

            //DI 属性注入方式
            //AccessDal dal = new AccessDal();//在外部创建依赖对象
            //Order order = new Order();
            //order.Ida = dal;//给属性赋值
            //order.Add();

            //DI 接口注入方式      
            var dal=new SqlServerDal(); //在外部创建依赖对象
            Order order = new Order();
            order.SetDependence(dal); //传递依赖
            order.Add();



            Console.ReadKey();
        }
    }
}
