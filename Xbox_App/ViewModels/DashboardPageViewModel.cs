using MauiMicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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

        public DashboardPageViewModel(IDashboardTileService dashboardTileService, ViewModelContext context) : base(context)
        {
            _dashboardTileService = dashboardTileService;
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            DashboardTiles = _dashboardTileService.GetAllTileSets();
            var test = 0;
        }
    }
}
