using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int[] intArray = new int[5] {3,5,8,9,1};

            for (int i = 0; i <= intArray.Length -2; i++)
            {

                for (int k = 0; k <= intArray.Length-2; k++)
                {
                    count = count + 1;
                    if (intArray[k] > intArray[k +1])
                    {
                        int temp = intArray[k + 1];
                        intArray[k + 1] = intArray[k];
                        intArray[k] = temp;
                    }

                }
            }

            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }

            List<Test> ts = new List<Test>();
            ts.Add(new Test { Name = "jiya", run = 30 });
            ts.Add(new Test { Name = "rash", run = 12 });
            ts.Add(new Test { Name = "hun", run = 346 });
            ts.Add(new Test { Name = "jiya", run = 20 });
            ts.Add(new Test { Name = "jiya", run = 34 });
            //var result2=ts.Where(j=>j.run).Sum(x => x.run);
            var result = from r in ts
                         group r by r.Name into g
                         select new { Count = g.Sum(x=>x.run), Value = g.Key };

            Console.WriteLine();
            Console.WriteLine("The Loop iterates :" + count);
            Console.ReadKey();
        }
    }

    public class Test
    {
        public int run { get; set; }
        public string Name { get; set; }
    }
}
