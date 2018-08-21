using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOClearn.DAL
{
    /// <summary>
    /// sqlserver数据操作层
    /// </summary>
    public class SqlServerDal:IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("向Sqlserver数据库中添加一条订单");
        }
    }
}
