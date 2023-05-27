using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbox_App.Models
{
    public class NotificationTile
    {
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Destination { get; set; }
        public string TimeStamp { get; set; }
        public bool IsCaptureNotification => Type == "Capture";
        public bool IsFriendNotification => Type == "Friend";
        public string TypeImageUrl => IsCaptureNotification ? "icon_upload.png" : "icon_users.png";
    }
}
