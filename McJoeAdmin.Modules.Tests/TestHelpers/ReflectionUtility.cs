using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestHelpers
{
    public class ReflectionUtility
    {

        public static void SetNonPublicInstanceFieldValue(object pObject, string pField, object pValue)
        {
        }

        public static void SetNonPublicInstancePropertyValue(object pObject, string pField, object pValue)
        {
        }

        public static object InvokeNonPublicInstanceMethod(object pObject, string pMethod, params object[] pParameters)
        {
            if (pObject == null)
                throw new ArgumentNullException("pObject");

            var method = pObject.GetType().GetMethod(pMethod, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return method.Invoke(pObject, pParameters);
        }
    }
}
