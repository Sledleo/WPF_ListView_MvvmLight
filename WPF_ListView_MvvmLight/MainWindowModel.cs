using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_ListView_MvvmLight
{
    public class MainWindowModel 
    {
        public string Title { get { return "ListView - App"; } }

        public ObservableCollection<Book> Books { get; private set; }

        public MainWindowModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book{Title = "Qwerty", Pages = 100 },
                new Book{Title = "Asdf", Pages = 200 }
            };
        }

        private ICommand changeCommand;

        public ICommand ChangeCommand
        {
            get
            {
                return changeCommand ?? (changeCommand = new RelayCommand( () =>
                    {
                        Books.Add(new Book { Title = "Zzz", Pages = 111 });
                        Books.First().Pages += 1;
                    }
                ));
            }
        }

    }
}
