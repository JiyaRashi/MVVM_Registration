using MVVM_Registration.BusinessLogics;
using MVVM_Registration.Commands;
using MVVM_Registration.DataAccess;
using MVVM_Registration.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Registration.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private ICommand addCommand;

        private ICommand loadUserCommand;

        private ObservableCollection<Users> _users;

        private string _firstName;
        private string _lastName;
        private Int64 _mobileNumber;

        public RegistrationViewModel()
        {
            Users = new BusinessLogic().GetAllUsers();
        }

        public Int64 MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public ICommand AddCommand
        {
            get 
            {
                if(addCommand==null)
                   addCommand = new AddCommand(this);
                return addCommand;
            }
            set 
            { 
                addCommand = value; 
            }
        }

        public ICommand LoadUserCommand
        {
            get
            {
                if (loadUserCommand == null)
                    loadUserCommand = new LoadUserCommand(this);
                return loadUserCommand;
            }
            set
            {
                loadUserCommand = value;
            }
        }
        
        public ObservableCollection<Users> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;

            }
        }

        public void AddUsers()
        {
            Users.Add(new Users() { FirstName = FirstName, LastName = LastName, MobileNumber = MobileNumber });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
