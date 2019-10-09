﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Pocetna,
        Pokloni,
        Korpa,
        Narudzbe,
        Profil,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string ItemIcon { get; set; }
    }
}
