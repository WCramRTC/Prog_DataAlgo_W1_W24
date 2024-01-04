using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Prog_DataAlgo_W1_W24
{
    public class CustomList<T>
    {
        T[] internalArray;
        int count;

        // Constructor
        public CustomList() : this(10) { }

        public CustomList(int index)
        {
            internalArray = new T[index];
            count = 0;
        }

        // Add to our list
        public void Add(T item)
        {
            // Pre and post increment
            // count++
            CheckCapacity();
            internalArray[count++] = item;
 
        }

        private void CheckCapacity()
        {
            // If over 80% of our array is used, run this code
            if(count / (double)internalArray.Length > .8)
            {
                // Doubling the size
                T[] tempArray = new T[internalArray.Length * 2];

                for (int i = 0; i < internalArray.Length; i++)
                {
                    tempArray[i] = internalArray[i];
                }

                internalArray = tempArray;
            }
        }

        public T GetAtIndex(int index)
        {

            if (index < 0 || index > count) return default(T);

            return internalArray[index];
        }

        public T this[int index]
        {
            get => internalArray[index];
        }

        public void RemoveAt(int index)
        {
            //internalArray[index] = default(T);

            int current = index;

            while(current < count)
            {
                internalArray[current] = internalArray[current + 1];

                current++;
            }

            count--;

        }



        public void DisplayInformation()
        {
            for(int i = 0; i < internalArray.Length; i++)
            {
                Console.WriteLine($"{i}: {internalArray[i]}");
            }
        }

        public int Capacity
        {
            get => internalArray.Length;
        }

        // Array
        // Pros
        // fast
        // efficent
        // Cons
        // Does not expand
        // Not real built in functionality
        // Hard to work with 
    }
}
