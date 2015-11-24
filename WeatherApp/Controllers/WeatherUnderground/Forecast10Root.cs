﻿using System.Collections.Generic;

namespace Sequencing.WeatherApp.Controllers.WeatherUnderground
{
    public class Forecast10Root
    {
        public Response response { get; set; }
        public Forecast forecast { get; set; }
        public List<Alert> alerts { get; set; }
        public MoonPhase moon_phase { get; set; }

        public class CurrentTime
        {
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class Sunrise
        {
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class Sunset
        {
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class MoonPhase
        {
            public string percentIlluminated { get; set; }
            public string ageOfMoon { get; set; }
            public CurrentTime current_time { get; set; }
            public Sunrise sunrise { get; set; }
            public Sunset sunset { get; set; }
        }

        public class Alert
        {
            public string type { get; set; }
            public string description { get; set; }
            public string date { get; set; }
            public string date_epoch { get; set; }
            public string expires { get; set; }
            public string expires_epoch { get; set; }
            public string message { get; set; }
            public string phenomena { get; set; }
            public string significance { get; set; }
            public List<Zone> ZONES { get; set; }
            public StormBased StormBased { get; set; }

            public string wtype_meteoalarm { get; set; }
            public string wtype_meteoalarm_name { get; set; }
            public string level_meteoalarm { get; set; }
            public string level_meteoalarm_name { get; set; }
            public string level_meteoalarm_description { get; set; }
            public string attribution { get; set; }
        }

        public class Zone
        {
            public string state { get; set; }
            public string ZONE { get; set; }
        }

        public class Vertex
        {
            public string lat { get; set; }
            public string lon { get; set; }
        }

        public class StormInfo
        {
            public string time_epoch { get; set; }
            public string Motion_deg { get; set; }
            public string Motion_spd { get; set; }
            public double position_lat { get; set; }
            public double position_lon { get; set; }
        }

        public class StormBased
        {
            public List<Vertex> vertices { get; set; }
            public string Vertex_count { get; set; }
            public StormInfo stormInfo { get; set; }
        }

        public class Simpleforecast
        {
            public List<Forecastday2> forecastday { get; set; }
        }

        public class Forecast
        {
            public TxtForecast txt_forecast { get; set; }
            public Simpleforecast simpleforecast { get; set; }
        }

        public class Features
        {
            public /*int*/string forecast10day { get; set; }
        }

        public class Response
        {
            public string version { get; set; }
            public string termsofService { get; set; }
            public Features features { get; set; }
        }

        public class Forecastday
        {
            public /*int*/string period { get; set; }
            public string icon { get; set; }
            public string icon_url { get; set; }
            public string title { get; set; }
            public string fcttext { get; set; }
            public string fcttext_metric { get; set; }
            public string pop { get; set; }
        }

        public class TxtForecast
        {
            public string date { get; set; }
            public List<Forecastday> forecastday { get; set; }
        }

        public class Date
        {
            public string epoch { get; set; }
            public string pretty { get; set; }
            public /*int*/string day { get; set; }
            public /*int*/string month { get; set; }
            public /*int*/string year { get; set; }
            public /*int*/string yday { get; set; }
            public /*int*/string hour { get; set; }
            public string min { get; set; }
            public /*int*/string sec { get; set; }
            public string isdst { get; set; }
            public string monthname { get; set; }
            public string monthname_short { get; set; }
            public string weekday_short { get; set; }
            public string weekday { get; set; }
            public string ampm { get; set; }
            public string tz_short { get; set; }
            public string tz_long { get; set; }
        }

        public class High
        {
            public string fahrenheit { get; set; }
            public string celsius { get; set; }
        }

        public class Low
        {
            public string fahrenheit { get; set; }
            public string celsius { get; set; }
        }

        public class QpfAllday
        {
            public /*double*/string @in { get; set; }
            public /*int*/string mm { get; set; }
        }

        public class QpfDay
        {
            public /*double*/string @in { get; set; }
            public /*int*/string mm { get; set; }
        }

        public class QpfNight
        {
            public /*double*/string @in { get; set; }
            public /*int*/string mm { get; set; }
        }

        public class SnowAllday
        {
            public /*double*/string @in { get; set; }
            public /*double*/string cm { get; set; }
        }

        public class SnowDay
        {
            public /*double*/string @in { get; set; }
            public /*double*/string cm { get; set; }
        }

        public class SnowNight
        {
            public /*double*/string @in { get; set; }
            public /*double*/string cm { get; set; }
        }

        public class Maxwind
        {
            public /*int*/string mph { get; set; }
            public /*int*/string kph { get; set; }
            public string dir { get; set; }
            public /*int*/string degrees { get; set; }
        }

        public class Avewind
        {
            public /*int*/string mph { get; set; }
            public /*int*/string kph { get; set; }
            public string dir { get; set; }
            public /*int*/string degrees { get; set; }
        }

        public class Forecastday2
        {
            public Date date { get; set; }
            public /*int*/string period { get; set; }
            public High high { get; set; }
            public Low low { get; set; }
            public string conditions { get; set; }
            public string icon { get; set; }
            public string icon_url { get; set; }
            public string skyicon { get; set; }
            public /*int*/string pop { get; set; }
            public QpfAllday qpf_allday { get; set; }
            public QpfDay qpf_day { get; set; }
            public QpfNight qpf_night { get; set; }
            public SnowAllday snow_allday { get; set; }
            public SnowDay snow_day { get; set; }
            public SnowNight snow_night { get; set; }
            public Maxwind maxwind { get; set; }
            public Avewind avewind { get; set; }
            public /*int*/string avehumidity { get; set; }
            public /*int*/string maxhumidity { get; set; }
            public /*int*/string minhumidity { get; set; }
        }


    }
}