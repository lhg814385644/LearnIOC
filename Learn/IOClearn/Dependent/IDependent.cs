using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOClearn.DAL;

namespace IOClearn.Dependent
{
    /// <summary>
    /// DI接口注入方式
    /// 在这个接口中设置依赖项
    /// 然后在依赖的高层模块中实现该接口
    /// </summary>
    public interface IDependent
    {    //设置依赖项
        void SetDependence(IDataAccess ida);
    }
}
