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
        public int WidthRequest { get; set; }
        public string CornerRadiusRequest { get; set; }
        public int HeightRequest { get; set; }
        public int MarginRequest { get; set; }
    }
}
