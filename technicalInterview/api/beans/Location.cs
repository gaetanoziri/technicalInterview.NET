using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.api.beans
{
    public class Location
    {
        private float lat;
        private float lng;

        public float Lat { get => lat; set => lat = value; }
        public float Lng { get => lng; set => lng = value; }

        public Location(float lat, float lng)
        {
            this.lat = lat;
            this.lng = lng;
        }
    }
}
