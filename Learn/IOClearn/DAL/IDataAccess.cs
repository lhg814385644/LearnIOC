using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOClearn.DAL
{
    /// <summary>
    /// 根据DIP原则，高层模块不应该依赖于低层模块，二者都应该引来于抽象
    /// 因此对低层模块抽象出一个数据访问接口
    /// 所有数据库访问类都实现这个抽象出来的抽象
    /// </summary>
    public interface IDataAccess
    {
        void Add();
    }
}
