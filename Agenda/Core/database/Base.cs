using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.database
{
    public class Base
    {
        public void myTryCatch(Action action, Action action2)
        {
            try
            {
                action();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                action2();
            }
        }
    }
}
