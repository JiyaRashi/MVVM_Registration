using MVVM_Registration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Registration.ViewModels
{
    public class UserViewodel
    {
        public IList<Users> UsersList { get; set; }
        public UserViewodel()
        {
            UsersList = new List<Users>();
            UsersList.Add( new Users() { FirstName = "Jiyavudeen", LastName = "Junaid" ,MobileNumber=8098820270});
            UsersList.Add(new Users() { FirstName = "Rasheetha Begam", LastName = "Junaid", MobileNumber = 7358847004 });

        }
    }
}
