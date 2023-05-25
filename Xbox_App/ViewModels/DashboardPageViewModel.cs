using MauiMicroMvvm;
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
    public class DashboardPageViewModel : MauiMicroViewModel
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

        public DashboardPageViewModel(IDashboardTileService dashboardTileService, ViewModelContext context) : base(context)
        {
            _dashboardTileService = dashboardTileService;
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            if (DashboardTiles == null){ DashboardTiles = _dashboardTileService.GetAllTileSets();}
            NotificationsCommand = new Command(NotificationsButton_Clicked);
        }

        private async void NotificationsButton_Clicked(object obj)
        {
            await Navigation.GoToAsync("NotificationsPage");
        }
    }
}
