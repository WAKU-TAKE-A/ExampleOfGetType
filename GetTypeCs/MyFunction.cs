using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtil
{
    public class MyFunction
    {
        public static string GetTypeCs(object obj)
        {
            try
            {
                return obj.GetType().ToString();
            }
            catch (Exception ex)
            {
                string msg = "Exception " + System.Reflection.MethodBase.GetCurrentMethod().Name + " : " + ex.Message;
                throw new ApplicationException(msg);
            }
        }

        public static string GetTypeCs_IList(IList<object> obj)
        {
            try
            {
                return obj[0].GetType().ToString();
            }
            catch (Exception ex)
            {
                string msg = "Exception " + System.Reflection.MethodBase.GetCurrentMethod().Name + " : " + ex.Message;
                throw new ApplicationException(msg);
            }
        }

    }
}
