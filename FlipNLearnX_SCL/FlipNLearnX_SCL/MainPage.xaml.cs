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
            ListViewDecks.ItemsSource = ViewModel.instance.SelectedSet.Decks;
        }

        async private void Button_AddSet_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddSetPoppup(), true);
        }

        async private void Button_AddDeck_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddDeckPoppup(), true);
        }

        async private void Deck_Tapped(object sender, EventArgs e)
        {
            ViewModel.instance.SelectedDeck = (ListViewDecks.SelectedItem as Deck);
            await this.Navigation.PushAsync(new ViewDeck(), true);
        }

        async private void Button_Profile_Tapped(object sender, EventArgs e)
        {
            // todo maybe
        }

        async private void Button_Schedule_Tapped(object sender, EventArgs e)
        {
            // todo maybe
        }

        private void Button_Sort_Tapped(object sender, EventArgs e)
        {
            //await this.Navigation.PushAsync(new Settings(), true);
            //new PromptConfig
            //{
            //    OnTextChanged = args =>
            //    {
            //        args.IsValid = true; // setting this to false will disable the OK/Positive button
            //        args.Text = ""; // you can read the current value as well as replace the textbox value here
            //    }
            //}

            //PromptResult pResult = await UserDialogs.Instance.PromptAsync(new PromptConfig
            //{
            //    InputType = InputType.Name,
            //    OkText = "Create",
            //    Title = "Create Folder",
            //});
            //if (pResult.Ok && !string.IsNullOrWhiteSpace(pResult.Text))
            //{
            //    var toastConfig = new ToastConfig(pResult.Text);
            //    toastConfig.SetDuration(3000);
            //    toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(12, 131, 193));

            //    UserDialogs.Instance.Toast(toastConfig);
            //}


            //var result = await UserDialogs.Instance.ActionSheetAsync("Sort Sets and Decks", "Cancel", null, null, "Reverse Alphabetically", "Creation Date", "Score");
            //if (result.Equals("Reverse Alphabetically"))
            //{
            //    ViewModel.instance.SelectedSet = ViewModel.instance.SelectedSet.Decks.OrderByDescending(y => y.Name) as Set;
            //    ListViewDecks.ItemsSource = ViewModel.instance.SelectedSet.Decks.OrderByDescending(y => y.Name);
            //    ListViewDecks.ItemsSource = null;
            //    ListViewDecks.ItemsSource = ViewModel.instance.SelectedSet.Decks;
            //    foreach (Deck d in ViewModel.instance.SelectedSet.Decks)
            //    {
            //        ListViewDecks.ItemsSource.Add(d);
            //    }
            //}
            //else if (result.Equals("Cancel"))
            //{
            //    result = "Canceled!";
            //}
            //else
            //{
            //    result = "bloop";
            //}
            //var toastConfig = new ToastConfig(result);
            //toastConfig.SetDuration(3000);
            //toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(12, 131, 193));

            //UserDialogs.Instance.Toast(toastConfig);
        }

        async private void Button_Settings_Tapped(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Settings(), true);
        }
    }
}

