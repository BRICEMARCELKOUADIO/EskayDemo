using EskayDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EskayDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rechercher : ContentPage
    {
        public ObservableCollection<RechercherType> RecherchertypeItems { get; set; }
        public ObservableCollection<Offre> Offfres { get; set; }
        public Rechercher()
        {
            InitializeComponent();
            RecherchertypeItems = new ObservableCollection<RechercherType>();
            Offfres = new ObservableCollection<Offre>();
            RecherchertypeItems = LoadDataRecherche();
            Offfres = LoadDataOffre();    
            BindingContext = this;
        }

        private ObservableCollection<RechercherType> LoadDataRecherche()
        {
            var recherchert = new ObservableCollection<RechercherType>()
            {
                new RechercherType(){Title="Vols",SideColor=Color.FromHex("#5198E8"),IconRechercherType="vol.png"},
                new RechercherType(){Title="Hôtels",SideColor=Color.FromHex("#ED4991"),IconRechercherType="hotel.png"},
                new RechercherType(){Title="Offres",SideColor=Color.FromHex("#00DAE7"),IconRechercherType="offre.png"},
                new RechercherType(){Title="Voitures",SideColor=Color.FromHex("#F1B267"),IconRechercherType="voiture.png"}
            };

            return recherchert;
        }

        private ObservableCollection<Offre> LoadDataOffre()
        {
            var offres = new ObservableCollection<Offre>()
            {
                new Offre(){CountryDestination="CROATIE", City="Rijeka", Country="Paris",Price=646,CityImage="image1.png", },
                new Offre(){CountryDestination="TUNISIE", City="Debrecen", Country="Paris",Price=256,CityImage="image2.png" },
                new Offre(){CountryDestination="ROUMANIE", City="Sibiu", Country="Paris",Price=400,CityImage="image3.png" },
                //new Offre(){CountryDestination="DANEMARK", City="Copenhage", Country="Paris",Price=700,CityImage="image4.png" },
            };
            return offres;
        }
    }
}