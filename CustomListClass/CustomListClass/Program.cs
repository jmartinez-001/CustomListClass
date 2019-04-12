using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> thing = new List<int>();
            //List<int> otherthing = new List<int>();
            //List<int> otherotherthing = thing + otherthing;

            CustomList<int> List1 = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            CustomList<int> List3 = new CustomList<int>();
            List1.Add(5);
            List1.Add(10);
            List1.Add(20);
            List2.Add(20);
            List2.Add(25);
            List2.Add(10);
            List2.Add(10);
            List2.Add(10);
            List2.Add(10);

            List1.Zip(List2);
            Console.WriteLine(List3.ToString());



        }

    }
}
