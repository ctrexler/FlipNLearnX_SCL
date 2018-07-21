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
        private Guid Id { get; set; } = Guid.NewGuid();
        public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;
        public string Name { get; set; }
        public string Description { get; set; } = "no description";
        public Color Color { get; set; } = Color.Azure;
        public ObservableCollection<Deck> Decks { get; set; }
    }
}
