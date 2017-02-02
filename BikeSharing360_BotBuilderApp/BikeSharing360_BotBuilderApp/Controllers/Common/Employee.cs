﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeSharing360_BotBuilderApp.Common
{
    public class Employee
    {
        public string id;
        public string name;
        public string serviceUrl;
        public string conversationId;
        public GeoLocation location;
        public BotUser customer;
    }
}