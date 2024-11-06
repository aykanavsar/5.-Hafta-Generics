using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _5._Hafta_Generics_Class
{
    public class GenericStack<T>
    {
        private List<T> _elements = new List<T>();

        public void Push(T item)
        {
            _elements.Add(item); 
        }

        public T Pop()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("stack boş");
            }

            T item = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count - 1);

            return item;

        }
        public T Peek()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("stack boş");
            }
            return _elements[_elements.Count - 1];
        }

        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }
    }
}
