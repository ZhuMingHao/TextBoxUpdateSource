using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string quantity;

        public string Quantity
        {
            get { return quantity; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (int.Parse(value) > int.Parse(Stock))
                    {
                        quantity = Stock;
                    }
                    else
                    {
                        quantity = value;
                    }
                    OnPropertyChanged();
                }
            }
        }

        private string stock;

        public string Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }

        private string info;

        public string Info
        {
            get { return info; }

            set
            {
                info = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}