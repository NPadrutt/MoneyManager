using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using MoneyManager.DataAccess;
using MoneyManager.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MoneyManager.ViewModels
{
    public class AddAccountViewModel : ViewModelBase
    {
        private bool isEdit;

        public bool IsEdit
        {
            get { return isEdit; }
            set
            {
                if (isEdit != value)
                {
                    isEdit = value;
                }

                RaisePropertyChanged();
            }
        }

        public RelayCommand AddAccountCommand { get; private set; }
        public RelayCommand CancelCommand { get; private set; }

        public AddAccountViewModel()
        {
            AddAccountCommand = new RelayCommand(AddAccount);
            CancelCommand = new RelayCommand(Cancel);
        }

        public Account SelectedAccount
        {
            get { return new ViewModelLocator().AccountDataAccess.SelectedAccount; }
        }

        private void AddAccount()
        {
            ServiceLocator.Current.GetInstance<AccountDataAccess>().Save(SelectedAccount);
            ((Frame)Window.Current.Content).GoBack();
        }

        private void Cancel()
        {
            ((Frame)Window.Current.Content).GoBack();
        }
    }
}