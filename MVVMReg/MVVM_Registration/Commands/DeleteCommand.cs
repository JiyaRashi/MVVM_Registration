using MVVM_Registration.BusinessLogics;
using MVVM_Registration.Model;
using MVVM_Registration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Registration.Commands
{
    public class DeleteCommand : ICommand
    {
        private RegistrationViewModel _regViewModel { get; set; }


        public DeleteCommand(RegistrationViewModel regViewModel)
        {
            _regViewModel = regViewModel;
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
            Users users = _regViewModel.SelectedUser;
        }
    }
}
