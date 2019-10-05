using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ListView_MvvmLight
{
    public class Book  : INotifyPropertyChanged
    {
        private int pages;
        private string title;

        public string Title { get => title; set { title = value; PCh(); } }

        public int Pages { get => pages; set { pages = value; PCh(); } }




        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void PCh([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
