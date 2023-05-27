using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Models;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.Services.Implementations
{
    public class NotificationService : INotificationService
    {
        public async Task<List<NotificationTile>> GetAllNotifications()
        {
            var notifications = new List<NotificationTile>();
            notifications.Add(GetUploadNotification("Call of Duty: Modern Warfare II", "https://assetsio.reedpopcdn.com/warzone-2-mw2-season-3-header-size.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp", "2 Mo"));
            notifications.Add(GetUploadNotification("Fortnite", "https://image.api.playstation.com/vulcan/ap/rnd/202303/0621/d3c11818a78c6495e84a3d8e8dd6dc652721be36e0eb8c0a.png", "3 Mo"));
            notifications.Add(GetFriendNotification("User14356434", "https://www.mecgale.com/wp-content/uploads/2017/08/dummy-profile.png", "2 Mo"));
            notifications.Add(GetFriendNotification("User14356434", "https://www.mecgale.com/wp-content/uploads/2017/08/dummy-profile.png", "2 Mo"));
            notifications.Add(GetUploadNotification("2 Plants vs. Zombies: Battle for Neighborville", "https://image.api.playstation.com/vulcan/img/rnd/202008/3107/m04V1Wbq0ag6IAp3UozdjSCh.png", "3 Mo"));
            notifications.Add(GetUploadNotification("Minecraft", "https://assets-prd.ignimgs.com/2021/12/14/minecraft-1639513933156.jpg", "3 Mo"));
            notifications.Add(GetUploadNotification("5 Cooking Simulator", "https://image.api.playstation.com/vulcan/ap/rnd/202105/0411/L6AeZM046ZKczkKIR2En9lrx.png", "4 Mo"));
            notifications.Add(GetUploadNotification("2 High on Life", "https://media.vandal.net/i/1440x1080/12-2022/2022121616391531_1.jpg", "5 Mo"));
            notifications.Add(GetFriendNotification("User14356434", "https://www.mecgale.com/wp-content/uploads/2017/08/dummy-profile.png", "6 Mo"));
            notifications.Add(GetUploadNotification("Marvel's Guardians of the Galaxy", "https://media.titanbooks.com/catalog/products/MapleCover_small.jpg", "7 Mo"));
            notifications.Add(GetUploadNotification("Grounded", "https://static.tvtropes.org/pmwiki/pub/images/grounded_1.png", "7 Mo"));
            notifications.Add(GetFriendNotification("User14356434", "https://www.mecgale.com/wp-content/uploads/2017/08/dummy-profile.png", "8 Mo"));
            return notifications;
        }

        private NotificationTile GetUploadNotification(string gameName, string imageUrl, string timeStamp)
        {
            var notificationTile = new NotificationTile();
            notificationTile.Title = $"{gameName} capture ready to share";
            notificationTile.ImageUrl = imageUrl;
            notificationTile.Type = "Capture";
            notificationTile.Destination = "ScreenshotsPage";
            notificationTile.TimeStamp = timeStamp;
            return notificationTile;
        }

        private NotificationTile GetFriendNotification(string userName, string imageUrl, string timeStamp)
        {
            var notificationTile = new NotificationTile();
            notificationTile.Title = $"{userName} has added you as their friend";
            notificationTile.ImageUrl = imageUrl;
            notificationTile.Type = "Friend";
            notificationTile.Destination = "FriendPage";
            notificationTile.TimeStamp = timeStamp;
            return notificationTile;
        }
    }
}
