using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlipNLearnX_SCL.Models
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public ObservableCollection<Deck> Decks { get; set; }
    }
}
