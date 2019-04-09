using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class CustomList<T>
    {
        //member variables
        public int Count;
        public int Capacity;
        private T[] items;
        public int startingListCapacity = 4;

        //constructor
        public CustomList()
        {
            Capacity = startingListCapacity;
            items = new T[startingListCapacity];
            //Capacity = items.Length;
            Count = 0;

        }

        //member methods
        //public void Add(T value)
        //{
        //    for (var i = 0; i < items.Length; i++)
        //    {
        //        if (items[i] != null)
        //        {
        //            i++;

        //        }
        //        else
        //        {
        //            items[i] = value;

        //        }


        //    }


        //}
        public void Add(T value)
        {
            CheckCapacity();
            items[Count] = value;
            Count++;
        }
        private void CheckCapacity()
        {
            if (Capacity == Count)
            {
                items = IncreaseCapacity();
            }
        }
        private T[] IncreaseCapacity()
        {
            T[] temparray = new T[Capacity * 2];

            Capacity = (Capacity * 2);
            return temparray;
        }



    }
}
