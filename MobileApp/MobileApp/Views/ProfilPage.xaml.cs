﻿using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilPage : ContentPage
    {
        private readonly ProfilViewModel model = null;
        public ProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new ProfilViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.LoadUser();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.UpdateUser();
        }
    }
}