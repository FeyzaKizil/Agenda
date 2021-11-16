using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.businessLogicService
{
    public class BaseService<T>
    {
        public SqlCommand cmd;
        public SqlDataReader reader;
        public int result;
        public object obj;
        public List<T> list;
        public T data;

    }
}
