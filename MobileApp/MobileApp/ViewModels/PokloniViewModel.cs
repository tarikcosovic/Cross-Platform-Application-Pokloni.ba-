using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PokloniViewModel
    {
        public void CreateTable()
        {
            TableView list = new TableView();
            list.RowHeight = 80;
            TableRoot troot = new TableRoot();
            list.Root = troot;
            TableSection section = new TableSection();
            troot.Add(section);
        }
    }
}
