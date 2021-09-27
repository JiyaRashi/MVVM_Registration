using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateScore.Respository
{
    public interface IBatsmanRespository
    {
        IEnumerable<Batsman> GetAll();
    }
    public class BatsmanRespository : IBatsmanRespository
    {
        public IEnumerable<Batsman> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
