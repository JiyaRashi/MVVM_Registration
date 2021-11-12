using MVVM_Registration.Commands;
using MVVM_Registration.DataAccess;
using MVVM_Registration.DataAccess.EntityFrameWork;
using MVVM_Registration.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_Registration.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private ICommand addCommand;

        private ICommand loadUserCommand;

        private ICommand deleteUserCommand;

        private IList<User> _users;

        private string _firstName;
        private string _lastName;
        private Int64 _mobileNumber;
        private string _fullName;
        private Language _language;
        private Country _country;
        private Int64 _pinCode;

        private Users _selectedUser;

        private string _email;
        private bool HasFirstName => !string.IsNullOrEmpty(FirstName);

        public RegistrationViewModel()
        {
            //Users = new BusinessLogic().GetAllUsers();
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            Users = sqlDataAccess.GetAllUsers();

        }

        public Int64 MobileNumber
        {
            get { return _mobileNumber; }
            set { 
                _mobileNumber = value;
                OnPropertyRaised("MobileNumber");

            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { 
                _firstName = value;
                OnPropertyRaised("FirstName");

            }
        }


        public string LastName
        {
            get { return _lastName; }
            set {
                _lastName = value;
                OnPropertyRaised("LastName");

            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyRaised("Email");

            }
        }

        public string FullName
        {
            get { 
                return _firstName + " " + _lastName; ;
            }
            set
            {
                _fullName = value;
                OnPropertyRaised("FullName");

            }
        }


        public Language Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public Country Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public Int64 PinCode
        {
            get { return _pinCode; }
            set { _pinCode = value; }
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
                OnPropertyRaised("AddCommand");
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
                OnPropertyRaised("LoadUserCommand");

            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteUserCommand == null)
                    deleteUserCommand = new DeleteCommand(this);
                return deleteUserCommand;
            }
            set
            {
                deleteUserCommand = value;
                OnPropertyRaised("DeleteCommand");

            }
        }

        public IList<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
               // OnPropertyRaised("Users");
            }
        }

        public Users SelectedUser
        {
            get
            {
                return _selectedUser;
            }
            set
            {
                _selectedUser = value;
                OnPropertyRaised("SelectedUser");

            }
        }



        public string Error => throw new NotImplementedException();

        public string this[string columnName] => throw new NotImplementedException();

        public void AddUsers()
        {
            //Users.Add(new Users() 
            //{
            //    FirstName = FirstName, 
            //    LastName = LastName, 
            //    FullName=FullName,
            //    Language=Language,
            //    Email=Email,
            //    MobileNumber = MobileNumber,
            //    Country=Country,
            //    Pincode=PinCode
            //});
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
