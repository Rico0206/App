using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolApp
{
    class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand( MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "SignUp")
            {
                viewModel.SelectedViewModel = new SignupViewModel();
            }
            else if(parameter.ToString() == "Enrolment")
            {
                viewModel.SelectedViewModel = new EnrolmentViewModel();
            }            
            else if(parameter.ToString() == "Profile")
            {
                viewModel.SelectedViewModel = new ProfileViewModel();
            }            
            else if(parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }            
        }
    }
}
