using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOClearn.DAL;

namespace IOClearn.Orders
{
    /// <summary>
    /// 订单逻辑处理类
    /// 如：订单入库操作
    /// </summary>
    public class Order
    {
        #region 组件高度耦合，违背DIP原则，高层模块Order不应该依赖于低层模块AccessDal等，二者应该依赖于抽象IoC有2种常见的实现方式：依赖注入和服务定位
        //私有变量保存数据库操作对象
        //private  readonly  SqlServerDal sqlServerDal=new SqlServerDal();
        //切换数据库操作类
        private readonly AccessDal accessDal = new AccessDal();

        /// <summary>
        /// 订单入库操作
        /// </summary>
        public void Add()
        {
            //sqlServerDal.Add();
            accessDal.Add();
        } 
        #endregion

    }
}
