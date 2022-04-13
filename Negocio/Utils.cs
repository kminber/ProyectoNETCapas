using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Negocio
{
    public class Utils
    {
        
        public static void parse<T>(object sourceObject, ref T desObject)
        {
            if(sourceObject == null || desObject == null)
            {
                return;
            }

            Type sourceType = sourceObject.GetType();
            Type targetType = desObject.GetType();

            foreach(PropertyInfo p in sourceType.GetProperties())
            {
                PropertyInfo targetObj = targetType.GetProperty(p.Name);

                if(targetObj == null)
                {
                    continue;
                }
                targetObj.SetValue(desObject, p.GetValue(sourceObject, null), null);
            }

        }

    }
}
