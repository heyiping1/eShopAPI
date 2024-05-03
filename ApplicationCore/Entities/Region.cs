using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ShipperRegion> ShipperRegions { get; set; } = new List<ShipperRegion>();
    }
}
