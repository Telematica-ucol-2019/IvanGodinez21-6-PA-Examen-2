﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Banking6796.Models6796
{
    public class Account6796
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Balance { get; set; }
        public ObservableCollection<Transaction6796> Transactions { get; set; }

    }
}
