using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> where T : IComparable
    {
        //member variables
        private int count;
        public int Count
        {
            get { return count; }
        }
        public int Capacity;
        private T[] items;

        //constructor
        public CustomList()
        {
            int startingListCapacity = 4;
            Capacity = startingListCapacity;
            items = new T[startingListCapacity];
            count = 0;

        }

        public CustomList(int startingListCapacity)
        {
         
            Capacity = startingListCapacity;
            items = new T[startingListCapacity];
            count = 0;

        }
        //member methods
        public void Add(T value)
        {
            CheckCapacity();
            items[count] = value;



            count++;
        }
        private void CheckCapacity()
        {
            if (Capacity == count)
            {
                items = IncreaseCapacity();
            }

        }
        private T[] IncreaseCapacity()
        {

            Capacity = (Capacity * 2);
            T[] tempArray = new T[Capacity];
            return Copy(tempArray);
            
        }
        private T[] Copy(T[] tempArray)
        {
            for (var i = 0; i < count; i++)
            {
                tempArray[i] = items[i];
            }
            return tempArray;

        }
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        public bool Remove(T value) 
        {
            T[] tempArray = new T[Capacity];
            var j = 0;
            bool found = false;            

            for (var i = 0; i < Capacity; i++)
            {
                if ((!value.Equals(items[i])) || found)
                {
                    tempArray[j] = items[i];
                    j++;

                }
                else
                {

                found = true;

                }
                
            }
            items = tempArray;
            count = count - 1;
            return found;

        }
        public override string ToString()
        {
            string message = "Contents : ";
            for (var i = 0; i < count; i++)
            {
                message += items[i] + " ";

            }

            return message;
            
        }

    }
}
