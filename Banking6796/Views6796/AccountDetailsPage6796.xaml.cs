﻿using Banking6796.ViewModels6796;
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
    public partial class AccountDetailsPage6796 : ContentPage
    {
        public AccountDetailsPage6796(MainViewModel6796  vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}