using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlipNLearnX_SCL.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FlipNLearnX_SCL
{
    public class ViewModel : INotifyPropertyChanged
    {
        public static ViewModel instance;

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        // Sets
        private ObservableCollection<Set> _Sets { get; set; }
        public ObservableCollection<Set> Sets
        {
            get { return this._Sets; }
            set
            {
                if (value != this._Sets)
                {
                    this._Sets = value;
                    NotifyPropertyChanged("Sets");
                }
            }
        }

        // Selected Set
        private Set _SelectedSet = null;
        public Set SelectedSet
        {
            get
            {
                if (_SelectedSet == null)
                {
                    _SelectedSet = Sets.FirstOrDefault();
                }
                return _SelectedSet;
            }
            set
            {
                if (value != this._SelectedSet)
                {
                    this._SelectedSet = value;
                    NotifyPropertyChanged("SelectedSet");
                }
            }
        }

        // Selected Deck
        private Deck _SelectedDeck = null;
        public Deck SelectedDeck
        {
            get
            {
                if (_SelectedDeck == null)
                {
                    if (SelectedSet == null)
                    {
                        return null;
                    }
                    _SelectedDeck = SelectedSet.Decks.FirstOrDefault();
                }
                return _SelectedDeck;
            }
            set
            {
                if (value != this._SelectedDeck)
                {
                    this._SelectedDeck = value;
                    NotifyPropertyChanged("SelectedDeck");
                }
            }
        }

        // ViewModel Constructor
        public ViewModel()
        {
            ViewModel.instance = this;

            Sets = new ObservableCollection<Set>()
            {
                new Set() {
                    Name = "Chemistry",
                    Color = Color.OrangeRed,
                    Decks = new ObservableCollection<Deck>() {
                        new Deck() {
                            Name = "Polyatomic Ions",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.DeepPink,
                                    FrontText="C2 H3 O2 ^-1",
                                    BackText="acetate"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Elements",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.SteelBlue,
                                    FrontText="Hydrogen",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Famous Chemists",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.Black,
                                    FrontText="Mendeleev",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.SteelBlue,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.OrangeRed,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.ForestGreen,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.ForestGreen,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.OrangeRed,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.DarkViolet,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.DeepPink,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.SteelBlue,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "Sample Deck 1.1",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.SteelBlue,
                                    FrontText="Sample Card 1.1.1F",
                                    BackText="Sample Card 1.1.2B"
                                }
                            }
                        }
                    }
                },
                new Set() {
                    Name = "History",
                    Color = Color.SteelBlue,
                    Decks = new ObservableCollection<Deck>() {
                        new Deck() {
                            Name = "US Presidents",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.DarkViolet,
                                    FrontText="1. George Washington",
                                    BackText="Sample Card 2.1.1B"
                                },
                                new Card() {
                                    Color = Color.DeepPink,
                                    FrontText="Sample Card 2.1.2F",
                                    BackText="Sample Card 2.1.2B"
                                }
                            }
                        },
                        new Deck() {
                            Name = "The Civil Rights Movement",
                            Cards = new ObservableCollection<Card>() {
                                new Card() {
                                    Color = Color.ForestGreen,
                                    FrontText="This is a really long card just to see what happens when text expands but it probably just goes off the screen instead of wrapping." +
                                    "This is a really long card just to see what happens when text expands but it probably just goes off the screen instead of wrapping. " +
                                    "This is a really long card just to see what happens when text expands but it probably just goes off the screen instead of wrapping. " +
                                    "This is a really long card just to see what happens when text expands but it probably just goes off the screen instead of wrapping. ",
                                    BackText="Sample Card 2.2.1B"
                                },
                                new Card() {
                                    Color = Color.DeepPink,
                                    FrontText="Sample Card 2.2.2F",
                                    BackText="Sample Card 2.2.2B"
                                },
                                new Card() {
                                    Color = Color.DeepPink,
                                    FrontText="Sample Card 2.2.3F",
                                    BackText="Sample Card 2.2.3B"
                                }
                            }
                        }
                    }
                }
            };

            for (int j = 0; j < 1; j++)
            {
                Set a = new Set()
                {
                    Name = "Anatomy & Physiology",
                    Color = Color.DarkViolet,
                    Decks = new ObservableCollection<Deck>() {
                            new Deck() {
                                Name = "Bones of the Hand",
                                Cards = new ObservableCollection<Card>() {
                                    new Card() {
                                        Color = Color.DarkViolet,
                                        FrontText="Metacarpals",
                                        BackText="Sample Card"
                                    }
                                }
                            }
                        }
                };
                this.Sets.Add(a);
            };
        }
    }
}