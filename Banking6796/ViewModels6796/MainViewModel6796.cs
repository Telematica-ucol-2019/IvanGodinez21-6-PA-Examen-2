using Banking6796.Models6796;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Banking6796.ViewModels6796
{
    public class MainViewModel6796 : BaseViewModel6796
    {
        #region Main
        #region Attributes
        private User6796 user;
        #endregion
        #region Properties
        public User6796 User
        {
            get { return this.user; }
            set { this.user = value; OnPropertyChanged(); }
        }
        #endregion
        #region Commads
        public ICommand cmdTapAccount
        {
            get { return new RelayCommand<Account6796>(navigateToAccountDetails); }
            set { }
        }
        public ICommand cmdBtnCreateAccount
        {
            get { return new RelayCommand(navigateToCreateAccountPage); }
            set { }
        }
        public ICommand cmdBtnEditAccount
        {
            get { return new RelayCommand<User6796>(navigateToEditAccount); }
            set { }
        }
        #endregion
        #region Methods
        async private void navigateToAccountDetails(Account6796 _account)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views6796.AccountDetailsPage6796(_account, this));
        }
        async private void navigateToEditAccount(User6796 _user)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views6796.UserDetailsPage6796(_user, this));
        }
        async private void navigateToCreateAccountPage()
        {
            var modal = new Views6796.CreateAccount6796(this);
            await Application.Current.MainPage.Navigation.PushAsync(modal);
        }
        async private void navigateToTransferPage()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views6796.RegisterPage6796());

        }
        #endregion
        #region Constructor
        public MainViewModel6796(User6796 userPassed)
        {
            user = userPassed;
        }
        #endregion
        #endregion
        #region CreateAccount
        #region Attributes
        private string accountName;
        #endregion
        #region Properties
        public string inpAccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; OnPropertyChanged(); }
        }
        public Account6796 Account { get; set; }
        #endregion
        #region Commads
        public ICommand cmdInpAccountNameValidate
        {
            get { return new RelayCommand(inpNameValidate); }
            set { }
        }
        public ICommand cmdBtnCreate
        {
            get { return new RelayCommand(createAccount); }
            set { }
        }
        #endregion
        #region Methods
        private void inpNameValidate()
        {
            if (inpAccountName.Length > 0)
            {
                string lastCharacter = inpAccountName[inpAccountName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z]+$"))
                {
                    inpAccountName = inpAccountName.Substring(0, inpAccountName.Length - 1);
                }
            }
        }
        async private void createAccount()
        {
            User.Accounts.Add(
                new Account6796()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = inpAccountName,
                    Number = new Random().Next(1000, 4000),
                    Balance = new Random().Next(0, 100),
                    Transactions = new ObservableCollection<Transaction6796>()
                }
              );
            await Application.Current.MainPage.Navigation.PopAsync();
        }
        #endregion
        #region Constructor
        #endregion
        #endregion
        #region AccountDetails
        #region Attributes
        #endregion
        #region Properties
        #endregion
        #region Commands
        public ICommand cmdBtnDeposit
        {
            get { return new RelayCommand<Account6796>(depositBalance); }
            set { }
        }
        public ICommand cmdBtnWithdraw
        {
            get { return new RelayCommand<Account6796>(withdrawBalance); }
            set { }
        }
        public ICommand cmdBtnDeleteAccount
        {
            get { return new RelayCommand<Account6796>(deleteAccount); }
            set { }
        }
        #endregion
        #region Methods
        async private void depositBalance(Account6796 _account)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
        async private void withdrawBalance(Account6796 _account)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
        async private void deleteAccount(Account6796 _account)
        {
            if (_account.Balance == 0)
            {
                User.Accounts.Remove(_account);
                await Application.Current.MainPage.Navigation.PopAsync();
            } else
            {
                await Application.Current.MainPage.DisplayAlert("Balance detected", "You can't delete an account with balance", "Ok");
            }
        }
        #endregion
        #region Constructor
        #endregion
        #endregion
        #region EditAccount
        #region Attributes
        #endregion
        #region Properties
        public string inpUserDetailsName
        {
            get { return this.User.Name; }
            set { this.User.Name = value; OnPropertyChanged(); }
        }
        public string inpUserDetailsFLastName
        {
            get { return this.User.FLastName; }
            set { this.User.FLastName = value; OnPropertyChanged(); }
        }
        public string inpUserDetailsMLastName
        {
            get { return this.User.MLastName; }
            set { this.User.MLastName = value; OnPropertyChanged(); }
        }
        public string inpUserDetailsPhone
        {
            get { return this.User.Phone; }
            set { this.User.Phone = value; OnPropertyChanged(); }
        }
        #endregion
        #region Commands
        public ICommand cmdInpUserDetailsNameValidate
        {
            get { return new RelayCommand(inpUserDetailsNameValidate); }
            set { }
        }
        public ICommand cmdInpUserDetailsFLastNameValidate
        {
            get { return new RelayCommand(inpUserDetailsFLastNameValidate); }
            set { }
        }
        public ICommand cmdInpUserDetailsMLastNameValidate
        {
            get { return new RelayCommand(inpUserDetailsMLastNameValidate); }
            set { }
        }
        public ICommand cmdInpUserDetailsPhoneValidate
        {
            get { return new RelayCommand(inpUserDetailsPhoneValidate); }
            set { }
        }
        public ICommand cmdBtnUserDetailsEdit
        {
            get { return new RelayCommand<User6796>(btnUserDetailsEdit); }
            set { }
        }
        #endregion
        #region Methods
        private void inpUserDetailsNameValidate()
        {
            if (inpUserDetailsName.Length > 0)
            {
                string lastCharacter = inpUserDetailsName[inpUserDetailsName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z ]+$"))
                {
                    inpUserDetailsName = inpUserDetailsName.Substring(0, inpUserDetailsName.Length - 1);
                }
            }
        }
        private void inpUserDetailsFLastNameValidate()
        {
            if (inpUserDetailsFLastName.Length > 0)
            {
                string lastCharacter = inpUserDetailsFLastName[inpUserDetailsFLastName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z ]+$"))
                {
                    inpUserDetailsFLastName = inpUserDetailsFLastName.Substring(0, inpUserDetailsFLastName.Length - 1);
                }
            }
        }
        private void inpUserDetailsMLastNameValidate()
        {
            if (inpUserDetailsMLastName.Length > 0)
            {
                string lastCharacter = inpUserDetailsMLastName[inpUserDetailsMLastName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z ]+$"))
                {
                    inpUserDetailsMLastName = inpUserDetailsMLastName.Substring(0, inpUserDetailsMLastName.Length - 1);
                }
            }
        }
        private void inpUserDetailsPhoneValidate()
        {
            if (inpUserDetailsPhone.Length > 0)
            {
                if (inpUserDetailsPhone.Length <= 10)
                {
                    string lastCharacter = inpUserDetailsPhone[inpUserDetailsPhone.Length - 1].ToString();
                    if (!Regex.IsMatch(lastCharacter, @"^[0-9]*$"))
                    {
                        inpUserDetailsPhone = inpUserDetailsPhone.Substring(0, inpUserDetailsPhone.Length - 1);
                    }
                }
                else
                {
                    inpUserDetailsPhone = inpUserDetailsPhone.Substring(0, 10);
                }
            }
        }
        async private void btnUserDetailsEdit(User6796 user6796)
        {
            if (inpUserDetailsName?.Length > 0 && inpUserDetailsFLastName?.Length > 0 && inpUserDetailsMLastName?.Length > 0 && inpUserDetailsPhone?.Length > 0)
            {
                User = user;
                await Application.Current.MainPage.DisplayAlert("Done", "Modified correctly", "Ok");
                await Application.Current.MainPage.Navigation.PopAsync();
            } 
            else
            {
                await Application.Current.MainPage.DisplayAlert("Missing information", "Please fill all the form", "Ok");
            }
        }
        #endregion
        #region Constructor
        #endregion
        #endregion
    }
}
