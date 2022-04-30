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
    public class RegisterViewModel6796 : BaseViewModel6796
    {

        #region Attributes
        private string name;
        private string fLastName;
        private string mLastName;
        private string phone;
        #endregion
        #region Properties
        public string inpName
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string inpFLastName
        {
            get { return this.fLastName; }
            set { SetValue(ref this.fLastName, value); }
        }
        public string inpMLastName
        {
            get { return this.mLastName; }
            set { SetValue(ref this.mLastName, value); }
        }
        public string inpPhone
        {
            get { return this.phone; }
            set { SetValue(ref this.phone, value); }
        }
        #endregion
        #region Commads
        public ICommand cmdInpNameValidate
        {
            get { return new RelayCommand(inpNameValidate); }
            set { }
        }
        public ICommand cmdInpFLastNameValidate
        {
            get { return new RelayCommand(inpFLastNameValidate); }
            set { }
        }
        public ICommand cmdInpMLastNameValidate
        {
            get { return new RelayCommand(inpMLastNameValidate); }
            set { }
        }
        public ICommand cmdInpPhone
        {
            get { return new RelayCommand(inpPhoneValidate); }
            set { }
        }
        public ICommand cmdBtnRegister
        {
            get { return new RelayCommand(checkValidations); }
            set { }
        }
        #endregion
        #region Methods
        private void inpNameValidate()
        {
            if (inpName.Length > 0)
            {
                string lastCharacter = inpName[inpName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z ]+$"))
                {
                    inpName = inpName.Substring(0, inpName.Length - 1);
                }
            }
        }
        private void inpFLastNameValidate()
        {
            if (inpFLastName.Length > 0)
            {
                string lastCharacter = inpFLastName[inpFLastName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z ]+$"))
                {
                    inpFLastName = inpFLastName.Substring(0, inpFLastName.Length - 1);
                }
            }
        }
        private void inpMLastNameValidate()
        {
            if (inpMLastName.Length > 0)
            {
                string lastCharacter = inpMLastName[inpMLastName.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z ]+$"))
                {
                    inpMLastName = inpMLastName.Substring(0, inpMLastName.Length - 1);
                }
            }
        }
        private void inpPhoneValidate()
        {
            if (inpPhone.Length > 0)
            {
                if (inpPhone.Length <= 10)
                {
                    string lastCharacter = inpPhone[inpPhone.Length - 1].ToString();
                    if (!Regex.IsMatch(lastCharacter, @"^[0-9]*$"))
                    {
                        inpPhone = inpPhone.Substring(0, inpPhone.Length - 1);
                    }
                }
                else
                {
                    inpPhone = inpPhone.Substring(0, 10);
                }
            }
        }
        async private void checkValidations()
        {
            if (inpName?.Length > 0 && inpFLastName?.Length > 0 && inpMLastName?.Length > 0 && inpPhone?.Length > 0)
            {
                if (inpPhone.Length > 8)
                {
                    User6796 user = new User6796()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = inpName,
                        FLastName = inpFLastName,
                        MLastName = inpMLastName,
                        Phone = inpPhone,
                        Accounts = new ObservableCollection<Account6796>()
                    {
                        new Account6796()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Test",
                            Balance = 100,
                            Number = 5400000000000000,
                            Transactions = new ObservableCollection<Transaction6796>()
                            {
                                new Transaction6796()
                                {
                                    Id = Guid.NewGuid().ToString(),
                                    Value = 51,
                                    Type = "Deposit",
                                    Date = "28/04/2022",
                                    Hour = "12:00",
                                },
                                new Transaction6796()
                                {
                                    Id = Guid.NewGuid().ToString(),
                                    Value = 50,
                                    Type = "Deposit",
                                    Date = "28/04/2022",
                                    Hour = "12:02",
                                },
                                new Transaction6796()
                                {
                                    Id = Guid.NewGuid().ToString(),
                                    Value = 1,
                                    Type = "Withdraw",
                                    Date = "28/04/2022",
                                    Hour = "12:11",
                                }
                            }
                        }
                    }
                    };
                    await Application.Current.MainPage.DisplayAlert("Done", "Registred correctly", "Ok");
                    Application.Current.MainPage = new NavigationPage(new Views6796.MainPage6796(user));
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "The phone must have between 8-10 digits", "Ok");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Missing information", "Please fill all the form", "Ok");
            }
        }
        #endregion
        #region Constructor
        #endregion
    }
}
