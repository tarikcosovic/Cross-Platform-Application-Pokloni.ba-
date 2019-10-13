using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Pocetna, Title="Početna stranica", ItemIcon = "iconHome.png" },
                new HomeMenuItem {Id = MenuItemType.Pokloni, Title="Pokloni", ItemIcon = "iconGift.png" },
                new HomeMenuItem {Id = MenuItemType.Korpa, Title="Korpa", ItemIcon = "iconCart.png" },
                new HomeMenuItem {Id = MenuItemType.Narudzbe, Title="Narudžbe", ItemIcon = "iconOrder.png" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Korisnički profil", ItemIcon = "iconProfile.png" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}