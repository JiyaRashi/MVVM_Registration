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
using System.Collections.Generic;

namespace MVVM_Registration.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged,IDataErrorInfo
    {
        private ICommand addCommand;

        private ICommand loadUserCommand;

        private ObservableCollection<Users> _users;

        private string _firstName;
        private string _lastName;
        private Int64 _mobileNumber;
        private string _fullName;
        private Language _language;
        private Country _country;
        private Int64 _pinCode;

        private string _email;
        private readonly Dictionary<string, List<string>> _propertyNameToErrorsDictionary;
        private bool HasFirstName => !string.IsNullOrEmpty(FirstName);

        public RegistrationViewModel()
        {
            Users = new BusinessLogic().GetAllUsers();
            _propertyNameToErrorsDictionary = new Dictionary<string, List<string>>();
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

        public string Error => throw new NotImplementedException();

        public string this[string columnName] => throw new NotImplementedException();

        public void AddUsers()
        {
            Users.Add(new Users() 
            {
                FirstName = FirstName, 
                LastName = LastName, 
                FullName=FullName,
                Language=Language,
                Email=Email,
                MobileNumber = MobileNumber,
                Country=Country,
                Pincode=PinCode
            });
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
