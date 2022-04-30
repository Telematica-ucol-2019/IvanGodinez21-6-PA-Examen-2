using Banking6796.Models6796;
using Banking6796.ViewModels6796;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Banking6796.Views6796
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionPage6796 : ContentPage
    {
        public TransactionPage6796(Account6796 account, MainViewModel6796 vm)
        {
            InitializeComponent();
            vm.Account = account;
            BindingContext = vm;
        }
    }
}