﻿using Banking6796.Models6796;
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
            get { return this.User.Name; }
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
            get { return new RelayCommand<User6796>(inpUserDetailsNameValidate); }
            set { }
        }
        public ICommand cmdInpUserDetailsFLastNameValidate
        {
            get { return new RelayCommand<User6796>(inpUserDetailsFLastNameValidate); }
            set { }
        }
        public ICommand cmdInpUserDetailsMLastNameValidate
        {
            get { return new RelayCommand<User6796>(inpUserDetailsMLastNameValidate); }
            set { }
        }
        public ICommand cmdInpUserDetailsPhoneValidate
        {
            get { return new RelayCommand<User6796>(inpUserDetailsPhoneValidate); }
            set { }
        }
        public ICommand cmdBtnUserDetailsRegister
        {
            get { return new RelayCommand<User6796>(btnUserDetailsRegister); }
            set { }
        }
        #endregion
        #region Methods
        async private void inpUserDetailsNameValidate(User6796 user6796)
        {
            Console.WriteLine();
        }
        async private void inpUserDetailsFLastNameValidate(User6796 user6796)
        {
            Console.WriteLine();
        }
        async private void inpUserDetailsMLastNameValidate(User6796 user6796)
        {
            Console.WriteLine();
        }
        async private void inpUserDetailsPhoneValidate(User6796 user6796)
        {
            Console.WriteLine();
        }
        async private void btnUserDetailsRegister(User6796 user6796)
        {
            Console.WriteLine("Hop");
        }
        #endregion
        #region Constructor
        #endregion
        #endregion
    }
}
