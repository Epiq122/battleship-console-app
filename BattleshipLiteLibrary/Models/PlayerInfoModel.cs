using System.Collections.Generic;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string Username { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; }
        public List<GridSpotModel> ShotGrid { get; set; }

    }
}
