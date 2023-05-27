﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Models;

namespace Xbox_App.Services.Interfaces
{
    public interface INotificationService
    {
        public Task<List<NotificationTile>> GetAllNotifications();
    }
}
