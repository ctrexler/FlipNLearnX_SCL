using FlipNLearnX_SCL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlipNLearnX_SCL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddDeckPoppup : ContentPage
    {
        public AddDeckPoppup()
        {
            InitializeComponent();
        }

        async private void createButton_Tapped(object sender, EventArgs e)
        {
            Deck d = new Deck()
            {
                Name = deckName.Text,
                Cards = new ObservableCollection<Card>() {
                    new Card() {
                        Color = Color.Black,
                        FrontText="Card front",
                        BackText="Card back"
                    }
                }
            };
            ViewModel.instance.SelectedSet.Decks.Add(d);

            await Navigation.PopModalAsync();
        }

        async private void dismissButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}