using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Net;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            statusUpdates();
            //showLocation();
            //getMetData(lat, lon);
        }

        static void statusUpdates()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.Start();

            watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_statusChanged);

            watcher.

            showLocation();
            /*
            
            Console.WriteLine("Enter any key to quit.");
            Console.ReadLine();*/

        }

        static void watcher_statusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case GeoPositionStatus.Initializing:
                    Console.WriteLine("Searching for location . . . ");
                    break;
                case GeoPositionStatus.Ready:
                    Console.WriteLine("Location aquired . . .");
                    break;
                case GeoPositionStatus.NoData:
                    Console.WriteLine("No Data . . .");
                    break;
                case GeoPositionStatus.Disabled:
                    Console.WriteLine("Geolocation DISABLED . . .");
                    break;
            }
        }

        static Tuple<double,double> showLocation()
        {
            GeoCoordinateWatcher geoCoordinate = new GeoCoordinateWatcher();

            geoCoordinate.Start();

            System.Threading.Thread.Sleep(1000);


            GeoCoordinate loc = geoCoordinate.Position.Location;
            
            if (loc.IsUnknown != true)
            {
                double lat = loc.Latitude;
                double lon = loc.Longitude;
                

                Console.WriteLine($"Lat: {lat} Lon: {lon}");
            }
            else
            {
                Console.WriteLine("Position Unknown...");
            }

            return new Tuple<double, double>(loc.Latitude,loc.Longitude);
        }

         

        static void getMetData(double lat, double lon)
        {
            string strLat = string.Format("{0:0.00}", Convert.ToString(lat));
            string strLon = string.Format("{0:0.00}", Convert.ToString(lon));

            WebClient webClient = new WebClient();

            string file = "https://api.met.no/weatherapi/locationforecast/2.0/compact?lat="+strLat+"&lon="+strLon;

            webClient.DownloadFile(file, @"metData.json");

        }
    
    }
}
