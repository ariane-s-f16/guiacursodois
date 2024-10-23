using guiacursodois.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace guiacursodois.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<CardModel> Cards { get; set; }
        public ICommand NavigateToDetailCommand { get; set; }

        public MainPageViewModel()
        {
            Cards = new ObservableCollection<CardModel>
            {
                new CardModel { Title = "Card 1", ImageSource = "logo1d.png", Description = "", Detail = "Detalhes sobre Card 1" },
                new CardModel { Title = "Card 2", ImageSource = "logo2e.png", Description = "", Detail = "Detalhes sobre Card 2" },
                new CardModel { Title = "Card 3", ImageSource = "logo3a.png", Description = "", Detail = "Detalhes sobre Card 3" },
                new CardModel { Title = "Card 4", ImageSource = "logo4m.png", Description = "", Detail = "Detalhes sobre Card 4" }
            };

            NavigateToDetailCommand = new Command<CardModel>(NavigateToDetail);
        }

        private async void NavigateToDetail(CardModel card)
        {
            if (card != null)
            {
                if (card != null)
                {
                    // Passando parâmetros na URL
                    await Shell.Current.GoToAsync($"detail?title={Uri.EscapeDataString(card.Title)}&detail={Uri.EscapeDataString(card.Detail)}");
                }
            }
        }
    }
}
