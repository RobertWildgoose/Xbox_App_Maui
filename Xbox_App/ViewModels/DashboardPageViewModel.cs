using MauiMicroMvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xbox_App.Models;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
    {
        private readonly IDashboardTileService _dashboardTileService;

        public List<DashboardTileSet> DashboardTiles
        {
            get => Get<List<DashboardTileSet>>();
            set => Set(value);
        }

        public ICommand NotificationsCommand
        {
            get => Get<ICommand>();
            set => Set(value);
        }

        public ICommand GameSelectedCommand
        {
            get => Get<ICommand>();
            set => Set(value);
        }

        public DashboardPageViewModel(IDashboardTileService dashboardTileService, IApiRequestService apiRequestService, ViewModelContext context) : base(apiRequestService, context)
        {
            _dashboardTileService = dashboardTileService;
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            await GetAllTiles();
            NotificationsCommand = new Command(NotificationsButton_Clicked);
            GameSelectedCommand = new Command(GameSelected);
        }

        private async void GameSelected(object obj)
        {
            await Navigation.GoToAsync($"GameDetailPage?title={obj.ToString()}");
        }

        private async Task GetAllTiles()
        {
            if (DashboardTiles == null) 
            {
                DashboardTiles = _dashboardTileService.GetAllTileSets();
                var testdd = JsonConvert.SerializeObject(DashboardTiles);
                var test = await _requestService.GetListedData<DashboardTileSet>("https://raw.githubusercontent.com/RobertWildgoose/Xbox_App_Maui/main/Assets/dashboard.json"); 
            }
        }

        private async void NotificationsButton_Clicked(object obj)
        {
            await Navigation.GoToAsync("NotificationsPage");
        }
    }
}
