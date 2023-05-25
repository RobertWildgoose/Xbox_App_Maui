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
                            Title = "Play Riot Games' mobile titles!",
                            Description = "Receive in-game benefits by linking your riot games account to your Microsoft account.",
                            ImageUrl = "https://images.ctfassets.net/vfkpgemp7ek3/1lqVpXAGDXmXIZT0jLgUls/f158d27e3452fa2e2b575b31533122e1/league-of-legends-wild-rift-500-million.jpeg",
                            IsHeaderTile = true,
                            HeightRequest = 250,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.nme.com/wp-content/uploads/2022/08/Fall-Guys-x-Sonic.jpg",
                            IsHeaderTile = true,
                            HeightRequest = 250,
                        },
                        new DashboardTile()
                        {
                            Title = "SpiderHeck",
                            Description = "Get it with Xbox Game Pass",
                            ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202108/1607/czGau6hOvx9iQYOOkACdxqDl.png",
                            IsHeaderTile = true,
                            HeightRequest = 250
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
                            Title = "Warzone",
                            ImageUrl = "https://assetsio.reedpopcdn.com/warzone-2-mw2-season-3-header-size.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp",
                            HeightRequest = 80,
                            IsGameClipTile = true
                        },
                        new DashboardTile()
                        {
                            Title = "Skyrim",
                            ImageUrl = "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg",
                            HeightRequest = 80,
                            IsGameClipTile = true
                        },
                        new DashboardTile()
                        {
                            Title = "Dead by Daylight",
                            ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202203/1520/GxoUQHbrinQCjkNmBqwgr7Ij.jpg",
                            IsGameClipTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Forza",
                            ImageUrl = "https://www.gamespot.com/a/uploads/scale_landscape/1595/15950357/3942946-forzahorizon.jpeg",
                            IsGameClipTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Sea of Thieves",
                            ImageUrl = "https://assetsio.reedpopcdn.com/sea-of-thieves-what-to-do-voyages-tall-tales-quests-5001-1591358974477.jpg",
                            IsGameClipTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Red Dead 2",
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/red-dead-redemption-2-1539704658.jpg",
                            IsGameClipTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Overwatch 2",
                            ImageUrl = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/overwatch-2/3/33/OW2-Launch_Key_Art.png",
                            IsGameClipTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Rocket League",
                            Description = "Jump back In",
                            ImageUrl = "https://cdn1.epicgames.com/offer/9773aa1aa54f4f7b80e44bef04986cea/EGS_RocketLeague_PsyonixLLC_S3_2560x1440-1434001758900f513cab0c885121744a",
                            IsGameClipTile = true,
                            HeightRequest = 80,
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
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },new DashboardTile()
                        {
                           Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },new DashboardTile()
                        {
                           Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                           Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },new DashboardTile()
                        {
                           Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsActiveFriendsTile = true,
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            HeightRequest = 80,
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
                            IsStandardTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2022/06/12/ravenlok-button-1-1655076488006.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2022/02/04/epi1racer-sq-1644008681390.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://i2-prod.mirror.co.uk/gaming/article29347125.ece/ALTERNATES/s1200c/0_Truberbrook.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2023/03/14/fortnite-1678827457667.jpg?width=300&crop=1%3A1%2Csmart",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/12/14/minecraft-1639513933156.jpg",
                            HeightRequest = 80,
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202109/2216/t9XzGHGabQ2Ym0zbx4m0nEUC.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/09/10/redfall-1631232018892.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/08/19/elder-scrolls-skyrim-button-2017-1629409446732.jpg",
                            HeightRequest = 80,
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
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/08/19/elder-scrolls-skyrim-button-2017-1629409446732.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            IsStandardTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2022/06/12/ravenlok-button-1-1655076488006.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2022/02/04/epi1racer-sq-1644008681390.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://i2-prod.mirror.co.uk/gaming/article29347125.ece/ALTERNATES/s1200c/0_Truberbrook.jpg",
                            HeightRequest = 80,
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202109/2216/t9XzGHGabQ2Ym0zbx4m0nEUC.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/09/10/redfall-1631232018892.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/08/19/elder-scrolls-skyrim-button-2017-1629409446732.jpg",
                            HeightRequest = 80,
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
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/12/14/minecraft-1639513933156.jpg",
                            HeightRequest = 80,
                        },new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202109/2216/t9XzGHGabQ2Ym0zbx4m0nEUC.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/09/10/redfall-1631232018892.png",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/08/19/elder-scrolls-skyrim-button-2017-1629409446732.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            ImageUrl = "https://www.citypng.com/public/uploads/preview/-41603073993w9u8ect0zo.png",
                            IsStandardTile = true,
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2022/06/12/ravenlok-button-1-1655076488006.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2022/02/04/epi1racer-sq-1644008681390.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://i2-prod.mirror.co.uk/gaming/article29347125.ece/ALTERNATES/s1200c/0_Truberbrook.jpg",
                            HeightRequest = 80,
                        },
                        new DashboardTile()
                        {
                            Title = "Fall Guys",
                            Description = "Jump back In",
                            IsStandardTile = true,
                            ImageUrl = "https://assets-prd.ignimgs.com/2023/03/14/fortnite-1678827457667.jpg?width=300&crop=1%3A1%2Csmart",
                            HeightRequest = 80,
                        },
                        
                    }
                }
            };
            return Tiles;
            
        }
    }
}
