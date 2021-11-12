using MVVM_Registration.DataAccess.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Registration.DataAccess
{
   public class SqlDataAccess
    {
        public IList<User> GetAllUsers()
        {
            using (var context = new EF_JIYA_DBEntities())
            {
                return context.Users.ToList();
            }
        }
    }
}
