using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbox_App.Models
{
    public class DashboardTileSet
    {
        public string Title { get; set; }
        public bool ShowTitle => !string.IsNullOrEmpty(Title);
        public List<DashboardTile> Tiles { get; set; }
        public int HeightRequest => (Tiles.FirstOrDefault()?.HeightRequest ?? 0) + 20;
    }
}
