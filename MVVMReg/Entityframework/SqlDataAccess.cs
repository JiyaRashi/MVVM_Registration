using Entityframework.EF_DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework
{
    public class SqlDataAccess
    {
        public IList<User> GetAllUsers()
        {
            using(var context= new EF_JIYA_DBEntities())
            {
                return context.Users.ToList();
            }
        }
    }
}
