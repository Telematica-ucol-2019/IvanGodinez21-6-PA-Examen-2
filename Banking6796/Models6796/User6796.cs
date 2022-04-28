using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Banking6796.Models6796
{
    public class User6796
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FLastName { get; set; }
        public string MLastName { get; set; }
        public string Phone { get; set; }
        public ObservableCollection<Account6796> Accounts { get; set; }
    }
}
