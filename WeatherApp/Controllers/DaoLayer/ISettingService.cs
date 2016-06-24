﻿using Sequencing.WeatherApp.Controllers.OAuth;
using Sequencing.WeatherApp.Controllers.PushNotification;
using Sequencing.WeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sequencing.WeatherApp.Controllers.DaoLayer
{
    interface ISettingService
    {
        void SubscribePushNotification(string token, DeviceType deviceType, SendInfo info);
        void SetUserLocation(string city, string name);
        void SetUserLocationExt(string city, string userToken);
        void SetUserDataFile(string selectedName, string selectedId, string name);
        void SetUserDataFileExt(string selectedName, string selectedId, string token);
        SendInfo GetInfo(string name);
        void UpdateUserSettings(SendInfo info);
        decimal ParseTimeZoneOffset(string offset);
        string DeviceTokenSetting(string oldToken, string newToken, bool sendPush, DeviceType deviceType, string accessToken, long userId);
        SendInfo RetrieveSettings(string accessToken, string expiresIn, string tokenType, string scope, string refreshToken);
    }
}