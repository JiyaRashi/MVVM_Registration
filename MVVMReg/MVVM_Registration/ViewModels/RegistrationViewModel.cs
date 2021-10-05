﻿using MVVM_Registration.DataAccess;
using MVVM_Registration.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Registration.ViewModels
{
    public class RegistrationViewModel
    {
        public RegistrationViewModel()
        {

        }

        public ObservableCollection<Users> GetAllUsers()
        {
            return new UserData().GetUserList();
        }


    }
}