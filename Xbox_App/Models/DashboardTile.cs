using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbox_App.Models
{
    public class DashboardTile
    {
        public DashboardTile() { }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHeaderTile { get; set; }
        public bool IsActiveFriendsTile { get; set; }
        public bool IsGameClipTile { get; set; }
        public bool IsStandardTile { get; set; }
        public int HeightRequest { get; set; }
    }
}
