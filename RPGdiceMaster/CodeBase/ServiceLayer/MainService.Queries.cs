using RPGdiceMaster.CodeBase.DataLayer.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGdiceMaster.CodeBase.ServiceLayer
{
    public static partial class MainService
    {
        #region handleQuery
        public static T handleQuery<T>(IQuery<T> query)
        {
            try
            {
                return query.Execute();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return default(T);
            }
        }
        #endregion
    }
}
