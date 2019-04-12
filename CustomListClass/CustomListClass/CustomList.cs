using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable//, IComparable //ICollection, IEquatable<T>
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
        public CustomList(IEnumerable<T> collection)
        {

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
        //private bool RemoveAt(this T[] a, T[] b, T[] temp,)
        //{

        //}
        public override string ToString()
        {
            string message = "Contents : ";
            for (var i = 0; i < count; i++)
            {
                message += items[i] + " ";

            }

            return message;
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return items[index];
            }
            throw new System.ArgumentOutOfRangeException("Index out of Range!");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)items).GetEnumerator();
        }

      

        //public int CompareTo(CustomList<T> firstList, CustomList<T> secondList)
        //{
        //    var j = 0;

        //    for (var i = 0; i < Capacity; i++)
        //    {
        //        if (firstList[i] > secondList[i])
        //        {
        //             = items[i];
        //            j++;

        //        }
        //        else
        //        {

        //            found = true;

        //        }

        //    }

        //}

        public static bool Equals(T a, T b)
        {

            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //return new CustomList<T>(a + b);
            CustomList<T> temp = new CustomList<T>();
            for (var i = 0; i < firstList.count; i++)
            {
                temp.Add(firstList[i]);
            }
            for (var i = 0; i < secondList.count; i++)
            {
                temp.Add(secondList[i]);
            }
            return temp;
            
        }
        //public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        //{
        //    CustomList<T> temp = new CustomList<T>();
        //    for (var i = 0; i < firstList.count; i++)
        //    {
        //        bool addedToTemp = false;
        //        for (var j = 0; j < secondList.count; j++)
        //        {                    
        //            if ((!firstList[i].Equals(secondList[j])) && (!addedToTemp))
        //            {
        //                temp.Add(firstList[i]);
        //                addedToTemp = true;
                        
        //            }
        //            if ((firstList[i].Equals(secondList[j])) && (addedToTemp))
        //            {
        //                temp.Remove(firstList[i]);
        //                addedToTemp = false;

        //            }


        //        }          
                                
          
        //    }
        //    return temp;
        //}
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> temp = new CustomList<T>();
            for (var i = 0; i < firstList.count; i++)
            {
                temp.Add(firstList[i]);
                for (var j = 0; j < secondList.count; j++)
                {                                     
                    if (firstList[i].Equals(secondList[j]))
                    {
                        temp.Remove(firstList[i]);                        
                    }

                }

            }
            return temp;
        }
        public void Zip(CustomList<T> zipList)
        {
            items = CheckLengthReturnZipped(this, zipList);
            
            
            
        }
        private T[] CheckLengthReturnZipped(CustomList<T> ListOne, CustomList<T> ListTwo)
        {
            
            CustomList<T> largerList = new CustomList<T>();
            CustomList<T> smallerList = new CustomList<T>();
            if (ListOne.count.Equals(ListTwo.count))
            {
                return EqualLengthZipper(ListOne, ListTwo);
            }
            if (ListOne.count > ListTwo.count)
            {
                largerList = ListOne;
                smallerList = ListTwo;
                return DifferentLengthZipper(largerList, smallerList);


            }
            else
            {
                largerList = ListTwo;
                smallerList = ListOne;
                return DifferentLengthZipper(largerList, smallerList);

            }
            //return Zipper(largerList, smallerList);

        }
        private T[] EqualLengthZipper(CustomList<T> ListOne, CustomList<T> ListTwo)
        {

            int j = 0;
            int pairCount = ListOne.count + ListTwo.count;
            T[] temp = new T[pairCount];


            for (var i = 0; i < pairCount; i++)
            {
                temp[i] = ListOne[j];
                i++;
                temp[i] = ListTwo[j];
                j++;


            }
            return temp;


        }
        private T[] DifferentLengthZipper(CustomList<T> largerList, CustomList<T> smallerList)
        {
            int arraySize = largerList.count + smallerList.count;
            T[] temp = new T[arraySize];
            int listDifference = largerList.count - smallerList.count;
            int pairCount = listDifference * 2;
            int j = 0;

            for (var i = 0; i < pairCount; i++)
            {
                temp[i] = smallerList[j];
                i++;
                temp[i] = largerList[j];
                j++;


            }
            for (var k = count * 2; k < arraySize; k++)
            {
                temp[k] = largerList[listDifference];
                listDifference++;

            }
           
            count = arraySize;
            return temp;

        }
        //    T[] temp = ToArray(a);
        //    int n = a.count;
        //    int mid = n / 2;
        //    return SplitArray(temp, n, mid);
            

        //}
        //private T[] ToArray(CustomList<T> a)
        //{
        //    T[] temp = new T[a.count];
        //    for (var i = 0; i < a.count; i++)
        //    {
        //        temp[i] = a[i];
        //    }
        //    return temp;
        //}
        //private CustomList<T> SplitArray(T[] temp, int n, int mid)
        //{

        //    T[] left = new T[mid];
        //    T[] right = new T[n - mid];
        //    for (var i = 0; i < mid - 1; i++)
        //    {
        //        left[i] = temp[i];
        //    }
        //    for (var i = mid; i < n - 1; i++)
        //    {
        //        right[i - mid] = temp[i];
        //    }
        //    return MergeArray(left, right);

        //}
        //private CustomList<T> MergeArray(T[] left,T[] right, int n, int mid)
        //{
        //    CustomList<T> temp = new CustomList<T>();
        //    int j = 0;
        //    int i = 0;
        //    int k = 0;

        //    while (i < mid && j < n - mid)
        //    {
        //        if (left[i] <= right[i])
        //        {
        //            temp[k] = left[i];
        //            i++;
        //            k++;

        //        }
        //        else
        //        {
        //            temp[k] = right[j];
        //            j++;
        //            k++;
        //        }
        //    }
        //}
        
        

    }
}
