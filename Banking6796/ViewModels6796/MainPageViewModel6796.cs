using Banking6796.Models6796;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Banking6796.ViewModels6796
{
    internal class MainPageViewModel6796 : BaseViewModel6796
    {
        public MainPageViewModel6796(User6796 user)
        {
            name = user.Name;
            fLastName = user.FLastName;
            mLastName = user.MLastName;
            phone = user.Phone;
            accounts = user.Accounts;
        }
        #region Attributes
        private string name;
        private string fLastName;
        private string mLastName;
        private string phone;
        private ObservableCollection<Account6796> accounts;
        #endregion
        #region Properties
        public string lblName
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        #endregion
        #region Commads
        #endregion
        #region Methods
        #endregion
        #region Constructor
        #endregion
    }
}
