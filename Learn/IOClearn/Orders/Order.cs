using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOClearn.DAL;
using IOClearn.Dependent;

namespace IOClearn.Orders
{
    /// <summary>
    /// 订单逻辑处理类
    /// 如：订单入库操作
    /// </summary>
    public class Order : IDependent
    {
        #region 组件高度耦合，违背DIP原则，高层模块Order不应该依赖于低层模块AccessDal等，二者应该依赖于抽象IoC有2种常见的实现方式：依赖注入和服务定位
        //私有变量保存数据库操作对象
        //private  readonly  SqlServerDal sqlServerDal=new SqlServerDal();
        //切换数据库操作类
        //private readonly AccessDal accessDal = new AccessDal();

        ///// <summary>
        ///// 订单入库操作
        ///// </summary>
        //public void Add()
        //{
        //    //sqlServerDal.Add();
        //    accessDal.Add();
        //} 
        #endregion

        #region DI方式操作

        private readonly IDataAccess _idataAccess;
        //todo:将依赖对象的创建和绑定转移到被依赖对象类的外部来实现

        /// <summary>
        /// DI 构造函数注入方式
        /// </summary>
        /// <param name="idataAccess"></param>
        //public Order(IDataAccess idataAccess)
        //{
        //    _idataAccess = idataAccess;
        //}

        //public void Add()
        //{
        //     _idataAccess.Add();
        //}

        #endregion

        #region DI 属性注入方式
        private IDataAccess _ida;//定义一个私有变量保存抽象

        //属性，接受依赖
        public IDataAccess Ida
        {
            set { _ida = value; }
            get { return _ida; }
        }

        //public void Add()
        //{
        //    _ida.Add();
        //}

        #endregion


        #region DI 接口注入方式
        //TODO:相比构造函数注入和属性注入，接口注入显得有些复杂，使用也不常见。具体思路是先定义一个接口，包含一个设置依赖的方法。然后依赖类，继承并实现这个接口。
        private IDataAccess _idal;//定义一个私有变量保存抽象
        public void SetDependence(IDataAccess idal)
        {
            _idal = idal;
        }

        public void Add()
        {
            _idal.Add();
        }

        #endregion


    }
}
