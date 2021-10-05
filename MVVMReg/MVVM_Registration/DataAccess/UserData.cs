using MVVM_Registration.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Registration.DataAccess
{
    public class UserData
    {

        public ObservableCollection<Users> GetUserList()
        {
            ObservableCollection<Users> UsersList = new ObservableCollection<Users>();
            UsersList.Add(new Users() { FirstName = "Jiyavudeen", LastName = "Junaid", MobileNumber = 8098820270 });
            UsersList.Add(new Users() { FirstName = "Rasheetha Begam", LastName = "Junaid", MobileNumber = 7358847004 });
            return UsersList;
        }

    }
}