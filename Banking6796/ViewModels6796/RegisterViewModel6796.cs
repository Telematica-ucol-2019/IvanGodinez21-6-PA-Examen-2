using Banking6796.Models6796;
using GalaSoft.MvvmLight.Command;
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
    internal class RegisterViewModel6796 : BaseViewModel6796
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
        public ICommand cmdBtnRegister
        {
            get { return new RelayCommand(checkValidations); }
            set { }
        }
        #endregion
        #region Methods
        private void checkValidations()
        {
            if (inpName?.Length > 0 && inpFLastName?.Length > 0 && inpMLastName?.Length > 0 && inpPhone?.Length > 0)
            {
                if (Regex.IsMatch(inpName, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Yea");
                }
                else
                {
                    Console.WriteLine("Yea");
                }
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Missing information", "Please fill all the form", "Ok");
            }
        }
        #endregion
        #region Constructor
        #endregion
    }
}
