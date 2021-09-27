using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateScore
{
   public  static class BatsmanExtension
    {
            public static IEnumerable<Batsman> ToCar(this IEnumerable<string> source)
            {
                foreach (var line in source)
                {

                    var columns = line.Split(',');

                    yield return new Batsman
                    {
                        BatsmanName = columns[0],
                        Details = columns[1],
                        Runs = int.Parse(columns[2]),
                        Balls = int.Parse(columns[3]),
                        SR = double.Parse(columns[4]),                    
                        Fours = int.Parse(columns[5]),
                        Sixes = int.Parse(columns[6])
                    };
                }
            }
       
    }
}
