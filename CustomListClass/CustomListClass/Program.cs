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
            for (var i = 0; i < 10; i ++)
            {
                List1.Add(5);
            }
            for (var i = 0; i < 10; i++)
            {
                List2.Add(10);
            }

            CustomList<int> List3 = List1 + List2;
            Console.WriteLine(List3.ToString());



        }

    }
}
