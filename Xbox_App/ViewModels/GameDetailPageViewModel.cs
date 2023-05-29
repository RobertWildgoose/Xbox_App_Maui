using MauiMicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xbox_App.Models;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.ViewModels
{
    class GameDetailPageViewModel : BaseViewModel
    {
        public ICommand NavigateBackCommand
        {
            get => Get<ICommand>();
            set => Set(value);
        }

        public List<DashboardTile> Friends
        {
            get => Get<List<DashboardTile>>();
            set => Set(value);
        }

        public async override void OnAppearing()
        {
            base.OnAppearing();
            NavigateBackCommand = new Command(NavigateBack_Pressed);
            Friends = new List<DashboardTile>() { new DashboardTile(), new DashboardTile(), new DashboardTile(), new DashboardTile(), };
        }

        private async void NavigateBack_Pressed()
        {
            await Navigation.GoToAsync("..");
        }

        public GameDetailPageViewModel(IApiRequestService requestService, ViewModelContext context) : base(requestService, context)
        {

        }
    }
}
