using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitTesty
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageProduct : ContentPage
    {
        internal ObservableCollection<Produkt> produkty = new ObservableCollection<Produkt>();
        private Produkt wybranyProdukt;

        public ManageProduct(ObservableCollection<Produkt> produkty)
        {
            InitializeComponent();
            this.produkty = produkty;
        }

        public ManageProduct(Produkt wybranyProdukt)
        {
            InitializeComponent();
            labelTytul.Text = "Edytuj produkt";
            btnDodaj.IsVisible = false;
            btnEdytuj.IsVisible = true;
            this.wybranyProdukt = wybranyProdukt;
            entryNazwa.Text = wybranyProdukt.Nazwa;
            entryCena.Text = wybranyProdukt.Cena.ToString();
            entryIlosc.Text = wybranyProdukt.Ilosc.ToString();
        }

        private void BtnDodajClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNazwa.Text) && !string.IsNullOrEmpty(entryCena.Text) && !string.IsNullOrEmpty(entryIlosc.Text))
            {
                if (int.TryParse(entryIlosc.Text, out int _) && decimal.TryParse(entryCena.Text, out decimal _))
                {
                    var produkt = new Produkt()
                    {
                        Nazwa = entryNazwa.Text,
                        Cena = double.Parse(entryCena.Text),
                        Ilosc = int.Parse(entryIlosc.Text)
                    };

                    produkty.Add(produkt);

                    entryNazwa.Text = string.Empty;

                    entryCena.Text = string.Empty;

                    entryIlosc.Text = string.Empty;

                    Navigation.PopAsync();

                }
                else
                {
                    DisplayAlert("Niepoprawne dane", "Pole cena lub ilość nie jest liczbą", "OK");
                }
            }
            else
            {
                DisplayAlert("Niepoprawne dane", "Pola nie mogą byc puste", "OK");
            }

        }

        private void BtnEdytujClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNazwa.Text) && !string.IsNullOrEmpty(entryCena.Text) && !string.IsNullOrEmpty(entryIlosc.Text))
            {
                if (int.TryParse(entryIlosc.Text, out int _) && decimal.TryParse(entryCena.Text, out decimal _))
                {
                    wybranyProdukt.Nazwa = entryNazwa.Text;
                    wybranyProdukt.Cena = double.Parse(entryCena.Text);
                    wybranyProdukt.Ilosc = int.Parse(entryIlosc.Text);

                    entryNazwa.Text = string.Empty;
                    entryCena.Text = string.Empty;
                    entryIlosc.Text = string.Empty;

                    Navigation.PopAsync();
                }
                else
                {
                    DisplayAlert("Niepoprawne dane", "Pole cena lub ilość nie jest liczbą", "OK");
                }
            }
            else
            {
                DisplayAlert("Niepoprawne dane", "Pola nie mogą byc puste", "OK");
            }

        }
    }
}