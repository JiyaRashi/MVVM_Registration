using MVVM_Registration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Registration.Commands
{
    public class AddCommand : ICommand
    {
        private RegistrationViewModel _regViewModel { get; set; }

        public AddCommand(RegistrationViewModel regViewModel)
        {
            _regViewModel = regViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _regViewModel.AddUsers();
        }
    }
}
