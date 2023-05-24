using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Models;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.Services.Implementations
{
    public class DashboardTileService : IDashboardTileService
    {
        public List<DashboardTileSet> GetAllTileSets()
        {
            var Tiles = new List<DashboardTileSet>()
            {
                new DashboardTileSet()
                {
                    Title = "",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://images.ctfassets.net/vfkpgemp7ek3/1lqVpXAGDXmXIZT0jLgUls/f158d27e3452fa2e2b575b31533122e1/league-of-legends-wild-rift-500-million.jpeg",
                            WidthRequest = 250,
                            HeightRequest = 250,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.nme.com/wp-content/uploads/2022/08/Fall-Guys-x-Sonic.jpg",
                            WidthRequest = 250,
                            HeightRequest = 250,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202108/1607/czGau6hOvx9iQYOOkACdxqDl.png",
                            WidthRequest = 250,
                            HeightRequest = 250,
                            MarginRequest = 5
                        }
                    }
                },
                new DashboardTileSet()
                {
                    Title = "Official posts from games",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://assetsio.reedpopcdn.com/warzone-2-mw2-season-3-header-size.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202203/1520/GxoUQHbrinQCjkNmBqwgr7Ij.jpg",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.gamespot.com/a/uploads/scale_landscape/1595/15950357/3942946-forzahorizon.jpeg",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://assetsio.reedpopcdn.com/sea-of-thieves-what-to-do-voyages-tall-tales-quests-5001-1591358974477.jpg",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/red-dead-redemption-2-1539704658.jpg",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.cnet.com/a/img/resize/82e4b355aa266e7fab84f770422b74c2c42cb161/hub/2021/12/06/3239ee51-4844-4df4-8ee6-9daad3bcf830/halo-lead.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/overwatch-2/3/33/OW2-Launch_Key_Art.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://assetsio.reedpopcdn.com/apex-legends-season-16-header.jpg",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://cdn1.epicgames.com/offer/9773aa1aa54f4f7b80e44bef04986cea/EGS_RocketLeague_PsyonixLLC_S3_2560x1440-1434001758900f513cab0c885121744a",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 10
                        }
                    }
                },
                new DashboardTileSet()
                {
                    Title = "Active friends",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        }
                    }
                },
                new DashboardTileSet()
                {
                    Title = "Jump back in",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        }
                    }
                },
                new DashboardTileSet()
                {
                    Title = "Popular with friends",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        }
                    }
                },
                new DashboardTileSet()
                {
                    Title = "Recommended from Game Pass",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        }
                    }
                },
                new DashboardTileSet()
                {
                    Title = "Popular on Xbox",
                    Tiles = new List<DashboardTile>
                    {
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            WidthRequest = 80,
                            HeightRequest = 80,
                            MarginRequest = 5
                        }
                    }
                }
            };
            return Tiles;
            
        }
    }
}
