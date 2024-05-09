﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class ShipperRegion
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; } = new Region();
        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; } = new Shipper();
    }
}
