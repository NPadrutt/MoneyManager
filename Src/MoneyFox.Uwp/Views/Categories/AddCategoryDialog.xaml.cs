﻿using Windows.UI.Xaml.Controls;

#nullable enable
namespace MoneyFox.Uwp.Views.Categories
{
    public sealed partial class AddCategoryDialog : ContentDialog
    {
        public AddCategoryDialog()
        {
            InitializeComponent();
            DataContext = ViewModelLocator.AddCategoryVm;
        }
    }
}
