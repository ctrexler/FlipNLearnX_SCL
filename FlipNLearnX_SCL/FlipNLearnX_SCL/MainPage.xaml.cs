using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlipNLearnX_SCL.Models;

using Xamarin.Forms;

namespace FlipNLearnX_SCL
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
        {
            InitializeComponent();
        }

        private void Set_Tapped(object sender, EventArgs e)
        {
            ViewModel.instance.SelectedSet = (ListViewSets.SelectedItem as Set);
        }

        private void Button_AddSet_Tapped(object sender, EventArgs e)
        {
            Set a = new Set()
            {
                Name = "Geography",
                Color = Color.ForestGreen,
                Decks = new ObservableCollection<Deck>() {
                            new Deck() {
                                Name = "South America Capitals",
                                Cards = new ObservableCollection<Card>() {
                                    new Card() {
                                        Color = Color.Black,
                                        FrontText="Buenos Aires",
                                        BackText="Argentina"
                                    }
                                }
                            }
                        }
            };
            ViewModel.instance.Sets.Add(a);
        }

        private void Button_AddDeck_Tapped(object sender, EventArgs e)
        {
            Deck d = new Deck()
            {
                Name = "South America Capitals",
                Cards = new ObservableCollection<Card>() {
                    new Card() {
                        Color = Color.Black,
                        FrontText="Buenos Aires",
                        BackText="Argentina"
                    }
                }
            };
            ViewModel.instance.SelectedSet.Decks.Add(d);
        }

        async void Deck_Tapped(object sender, EventArgs e)
        {
            ViewModel.instance.SelectedDeck = (ListViewDecks.SelectedItem as Deck);
            await this.Navigation.PushAsync(new ViewDeck(), true);
        }

        async void Button_Settings_Tapped(object sender, EventArgs e)
        {
            //await this.Navigation.PushAsync(new Settings(), true);
        }
    }
}

