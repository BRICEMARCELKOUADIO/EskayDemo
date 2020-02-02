using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace EskayDemo.Model
{
    public class RechercherType : INotifyPropertyChanged
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        private Color _sideCoor;
        public Color SideColor
        {
            get => _sideCoor;
            set
            {
                _sideCoor = value;
                OnPropertyChanged("SideColor");
            }
        }

        private string _iconRechercherType;
        public string IconRechercherType
        {
            get => _iconRechercherType;
            set
            {
                _iconRechercherType = value;
                OnPropertyChanged("IconRechercherType");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
