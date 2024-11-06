using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Hafta_Generics_Class
{
    public class GenericsClass<T>
    {
        private T _field;

        public GenericsClass(T value)
        {
            _field = value;
        }

        public T GetValue()
        {
            return _field;
        }

    }
}
