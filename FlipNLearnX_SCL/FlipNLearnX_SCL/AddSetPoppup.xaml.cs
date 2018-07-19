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
	public partial class AddSetPoppup : ContentPage
	{
		public AddSetPoppup ()
		{
			InitializeComponent ();
		}

        async private void createButton_Tapped(object sender, EventArgs e)
        {
            Set a = new Set()
            {
                Name = setName.Text,
                Color = Color.Aqua,
                Decks = new ObservableCollection<Deck>() {
                            new Deck() {
                                Name = "Blank Deck",
                                Cards = new ObservableCollection<Card>() {
                                    new Card() {
                                        Color = Color.Aqua,
                                        FrontText="Card front",
                                        BackText="Card back"
                                    }
                                }
                            }
                        }
            };
            ViewModel.instance.Sets.Add(a);

            await Navigation.PopModalAsync();
        }

        async private void dismissButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}