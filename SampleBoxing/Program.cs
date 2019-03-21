using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            float aux;
            object t = i;
            aux = (int) t;
            Console.WriteLine("{0}", aux.GetType());

            List<object> mixedList = new List<object>();
            mixedList.Add("First group");
            
            for(int j=1; j<5; j++){
                mixedList.Add(j);
            }

            mixedList.Add("Second group");
            for(int j=1; j<10; j++) {
                mixedList.Add(j);
            }

            foreach(var item in mixedList) {
                Console.WriteLine(item);
            }

            var sum = 0;
            for( var j=1; j<5; j++) {
                Console.WriteLine("> {0}", mixedList[j]);
                sum += (int)mixedList[j] * (int)mixedList[j];
            }
            Console.WriteLine("Sum: {0}", sum);
            int test = int.MaxValue;
            Console.WriteLine("{0}", test + 1);
            Console.Read();
        }
    }
}
