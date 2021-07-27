using System;
using System.Collections.Generic;
using System.Text;

namespace LogiMapper.Helpers
{
    public class EnumHelper
    {

        //gets all enums and puts them in list
        public static List<T> GetValues<T>()
        {
            List<T> result = new List<T>();
            foreach(T t in (T[])Enum.GetValues(typeof(T)))
            {
                result.Add(t);
            }
            return result;
             
        }
    }
}
