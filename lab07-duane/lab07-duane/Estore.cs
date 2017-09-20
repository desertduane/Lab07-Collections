using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_duane
{
    class Estore<T> : IEnumerable<T>
    {
        T[] products = new T[10];
        int productCount = 0;

        public void Add(T product)
        {
            if(productCount == products.Length)
            {
                Array.Resize(ref products, products.Length * 2);
            }
            products[productCount++] = product;

            
        }

        public void Remove(T product)
        {
            for (var i = 0; i < products.Length; i++)
            {
                

            }   
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < productCount; i++)
            {
                yield return products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
