﻿namespace Shop.UIForms.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xamarin.Forms.Xaml;

    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
    }
}
