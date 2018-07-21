using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlipNLearnX_SCL.Models
{
    public class Deck
    {
        public enum DeckType { standard, pic, chronological, custom };
        public enum DeckMode { ordered, shuffled, mixedFocused };

        private Guid Id { get; set; } = Guid.NewGuid();
        public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;
        public string Name { get; set; }
        public string Description { get; set; } = "no description";
        public Color Color { get; set; }
        public int Type { get; set; } = (int)DeckType.standard;
        public int Mode { get; set; } = (int)DeckMode.ordered;
        public ObservableCollection<Card> Cards { get; set; }

        //TODO: More properties for scorekeeping

        //TODO: More default properties for card contents
    }
}
