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
    class NotificationsPageViewModel : BaseViewModel
    {
        private readonly INotificationService _notificationService;

        public ICommand NavigateBackCommand
        {
            get => Get<ICommand>();
            set => Set(value);
        }

        public List<NotificationTile> Notifications
        {
            get => Get<List<NotificationTile>>();
            set => Set(value);
        }

        public NotificationsPageViewModel(INotificationService notificationService, ViewModelContext context) : base(context)
        {
            _notificationService = notificationService;
        }

        public async override void OnAppearing()
        {
            base.OnAppearing();
            NavigateBackCommand = new Command(NavigateBack_Pressed);
            Notifications = await _notificationService.GetAllNotifications();
        }


        private async void NavigateBack_Pressed()
        {
            await Navigation.GoToAsync("..");
        }
    }
}
