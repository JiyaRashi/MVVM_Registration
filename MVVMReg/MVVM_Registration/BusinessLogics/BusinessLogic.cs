using MVVM_Registration.DataAccess;
using MVVM_Registration.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Registration.BusinessLogics
{
    public class BusinessLogic
    {
        private UserData userData;
        public BusinessLogic()
        {
            userData = new UserData();
        }

        public ObservableCollection<Users> GetAllUsers()
        {
            return userData.GetUserList();
        }

        public ObservableCollection<Users> DeleteUser(Users users)
        {
            ObservableCollection<Users> updatedList= userData.DeleteUser(users);
            return updatedList;
        }


    }
}
