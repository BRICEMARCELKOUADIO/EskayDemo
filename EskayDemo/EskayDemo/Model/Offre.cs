using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EskayDemo.Model
{
    public class Offre : INotifyPropertyChanged
    {
        private string _country;
        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged("Country");
            }
        }

        private string _countryDestination;
        public string CountryDestination
        {
            get => _countryDestination;
            set
            {
                _countryDestination = value;
                OnPropertyChanged("CountryDestination");
            }
        }

        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        private string _cityImage;
        public string CityImage
        {
            get => _cityImage;
            set
            {
                _cityImage = value;
                OnPropertyChanged("CityImage");
            }
        }


        private int _price;
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged("Price");
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
