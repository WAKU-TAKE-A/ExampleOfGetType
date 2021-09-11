using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtil
{
    public class MyFunction
    {
        /// <summary>
        /// Run GetType() on the argument.
        /// </summary>
        /// <param name="obj">The target to investigate.</param>
        /// <returns>The result.</returns>
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

        /// <summary>
        /// Run GetType() on the elements of the list.
        /// </summary>
        /// <param name="obj">The target to investigate.</param>
        /// <returns>The result.</returns>
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
