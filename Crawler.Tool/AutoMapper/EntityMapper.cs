using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Tool.AutoMapper
{
    public class EntityMapper
    {
        public static TTo EntityMapperMethod<TTo, TFrom>(TFrom from)
        {
            var to = Activator.CreateInstance<TTo>();
            var tTo = typeof(TTo);
            var psFrom = typeof(TFrom).GetProperties();
            foreach (var pFrom in psFrom)
            {
                var vFrom = pFrom.GetValue(from, null);
                if (vFrom != null)
                {
                    var pTo = tTo.GetProperty(pFrom.Name);
                    if (pTo != null)
                    {
                        var pToType = pTo.PropertyType;
                        if (pToType.IsGenericType && pToType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            var vTo = Convert.ChangeType(vFrom, pToType.GetGenericArguments()[0]);
                            pTo.SetValue(to, vTo, null);
                        }
                        else
                        {
                            var vTo = Convert.ChangeType(vFrom, pTo.PropertyType);
                            pTo.SetValue(to, vTo, null);
                        }
                    }
                }
            }
            return to;
        }  
    }
}
