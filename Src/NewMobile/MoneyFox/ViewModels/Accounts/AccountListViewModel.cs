﻿using MoneyFox.Groups;
using System.Collections.ObjectModel;

namespace MoneyFox.ViewModels.Accounts
{
    public class AccountListViewModel : BaseViewModel
    {
        public ObservableCollection<AlphaGroupListGroupCollection<AccountViewModel>> Accounts { get; set; } = new ObservableCollection<AlphaGroupListGroupCollection<AccountViewModel>>
        {
            new AlphaGroupListGroupCollection<AccountViewModel>("Included")
            {
                new AccountViewModel{ Name = "Income", CurrentBalance = 78542, IsExcluded = false, EndOfMonthBalance = 1234 },
                new AccountViewModel{ Name = "Expenses", CurrentBalance = 2451, IsExcluded = false, EndOfMonthBalance = 7854 },
            },
            new AlphaGroupListGroupCollection<AccountViewModel>("Included")
            {
                new AccountViewModel{ Name = "Investments", CurrentBalance = 1570, IsExcluded = true, EndOfMonthBalance = 2142 },
                new AccountViewModel{ Name = "Safety", CurrentBalance = 4455, IsExcluded = true, EndOfMonthBalance = 5522 }
            }
        };
    }
}
