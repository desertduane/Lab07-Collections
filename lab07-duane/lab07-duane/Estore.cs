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
            int removeAt = Array.IndexOf(products, product);
            bool remove = false;
            T[] newArray = new T[products.Length];

            for (var i = 0; i < products.Length; i++)
            {
                 if (remove)
                {
                    newArray[i - 1] = products[i];
                }

                 if (i != removeAt && !remove)
                {
                    newArray[i] = products[i];
                }
                else
                {
                    remove = true;
                }

            }
            products = newArray;
            productCount--;
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
