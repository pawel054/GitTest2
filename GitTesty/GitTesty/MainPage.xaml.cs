using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GitTesty
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private void Dodaj_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new ManageProduct(wybranyProdukt));
        }
        private void Edytuj_Clicked(object sender, EventArgs e)
        {
            wybranyProdukt = (Produkt)lista.SelectedItem;
            Navigation.PushAsync(new ManageProduct(wybranyProdukt));
        }
        private void Usun_Clicked(object sender,EventArgs e)
        {
            wybranyProdukt = (Produkt)lista.selectedItem;
            produkty.Remove(wybranyProdukt);
        }
    }
}
