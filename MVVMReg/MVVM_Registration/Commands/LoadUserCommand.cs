using MVVM_Registration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Registration.BusinessLogics;

namespace MVVM_Registration.Commands
{
    public class LoadUserCommand : ICommand
    {
        private RegistrationViewModel _regViewModel { get; set; }

        private BusinessLogic BusinessLogic { get; set; }
        public LoadUserCommand(RegistrationViewModel regViewModel)
        {
            _regViewModel = regViewModel;
            BusinessLogic = new BusinessLogic();
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _regViewModel.Users = BusinessLogic.GetAllUsers();
        }
    }
}
