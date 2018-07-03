using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using technicalInterview.api.beans;

namespace technicalInterview.api
{
    public interface IGeolocationService
    {
        Location Geolocate(string address);
    }
}
